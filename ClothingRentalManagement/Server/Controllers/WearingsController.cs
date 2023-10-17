using ClothingRentalManagement.Server.Interfaces;
using ClothingRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClothingRentalManagement.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WearingsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public WearingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Wearings
        [HttpGet]
        public async Task<IActionResult> GetWearings()
        {
            var Wearings = await _unitOfWork.Wearings.GetAll();
            return Ok(Wearings);
        }

        // GET: /Wearings/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWearing(int id)
        {
            var Wearing = await _unitOfWork.Wearings.Get(q => q.Id == id);

            if (Wearing == null)
            {
                return NotFound();
            }

            return Ok(Wearing);
        }

        // PUT: api/Wearings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWearing(int id, Wearing Wearing)
        {
            if (id != Wearing.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Wearings.Update(Wearing);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await WearingExists(id))
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

        // POST: api/Wearings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Wearing>> PostWearing(Wearing Wearing)
        {
            await _unitOfWork.Wearings.Insert(Wearing);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetWearing", new { id = Wearing.Id }, Wearing);
        }

        // DELETE: api/Wearings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWearing(int id)
        {
            var Wearing = await _unitOfWork.Wearings.Get(q => q.Id == id);
            if (Wearing == null)
            {
                return NotFound();
            }
            await _unitOfWork.Wearings.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> WearingExists(int id)
        {
            var Wearing = await _unitOfWork.Wearings.Get(q => q.Id == id);
            return Wearing == null;
        }
    }
}