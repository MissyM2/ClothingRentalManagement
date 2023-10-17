using ClothingRentalManagement.Server.Interfaces;
using ClothingRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClothingRentalManagement.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WearersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public WearersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Wearers
        [HttpGet]
        public async Task<IActionResult> GetWearers()
        {
            var Wearers = await _unitOfWork.Wearers.GetAll();
            return Ok(Wearers);
        }

        // GET: /Wearers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWearer(int id)
        {
            var Wearer = await _unitOfWork.Wearers.Get(q => q.Id == id);

            if (Wearer == null)
            {
                return NotFound();
            }

            return Ok(Wearer);
        }

        // PUT: api/Wearers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWearer(int id, Wearer Wearer)
        {
            if (id != Wearer.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Wearers.Update(Wearer);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await WearerExists(id))
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

        // POST: api/Wearers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Wearer>> PostWearer(Wearer Wearer)
        {
            await _unitOfWork.Wearers.Insert(Wearer);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetWearer", new { id = Wearer.Id }, Wearer);
        }

        // DELETE: api/Wearers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWearer(int id)
        {
            var Wearer = await _unitOfWork.Wearers.Get(q => q.Id == id);
            if (Wearer == null)
            {
                return NotFound();
            }
            await _unitOfWork.Wearers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> WearerExists(int id)
        {
            var Wearer = await _unitOfWork.Wearers.Get(q => q.Id == id);
            return Wearer == null;
        }
    }
}