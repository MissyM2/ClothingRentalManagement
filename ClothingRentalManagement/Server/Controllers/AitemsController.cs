using ClothingRentalManagement.Server.Interfaces;
using ClothingRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClothingRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AitemsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AitemsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Aitems
        [HttpGet]
        public async Task<IActionResult> GetAitems()
        {
            var includes = new List<string> { "Brand", "ApparelType", "Color", "Season", "Size" };
            var Aitems = await _unitOfWork.Aitems.GetAll();
            return Ok(Aitems);
        }

        // GET: /Aitems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAitem(int id)
        {
            var includes = new List<string> { "Brand", "ApparelType", "Color", "Season", "Size", "Wearings" };
            var Aitem = await _unitOfWork.Aitems.Get(q => q.Id == id);

            if (Aitem == null)
            {
                return NotFound();
            }

            return Ok(Aitem);
        }

        // PUT: api/Aitems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAitem(int id, Aitem Aitem)
        {
            if (id != Aitem.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Aitems.Update(Aitem);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await AitemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Aitems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Aitem>> PostAitem(Aitem Aitem)
        {
            await _unitOfWork.Aitems.Insert(Aitem);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetAitem", new { id = Aitem.Id }, Aitem);
        }

        // DELETE: api/Aitems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAitem(int id)
        {
            var Aitem = await _unitOfWork.Aitems.Get(q => q.Id == id);
            if (Aitem == null)
            {
                return NotFound();
            }
            await _unitOfWork.Aitems.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> AitemExists(int id)
        {
            var Aitem = await _unitOfWork.Aitems.Get(q => q.Id == id);
            return Aitem == null;
        }
    }
}
