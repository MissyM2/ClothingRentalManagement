using ClothingRentalManagement.Server.Interfaces;
using ClothingRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClothingRentalManagement.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SizesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SizesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Sizes
        [HttpGet]
        public async Task<IActionResult> GetSizes()
        {
            var Sizes = await _unitOfWork.Sizes.GetAll();
            return Ok(Sizes);
        }

        // GET: /Sizes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSize(int id)
        {
            var Size = await _unitOfWork.Sizes.Get(q => q.Id == id);

            if (Size == null)
            {
                return NotFound();
            }

            return Ok(Size);
        }

        // PUT: api/Sizes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSize(int id, Size Size)
        {
            if (id != Size.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Sizes.Update(Size);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await SizeExists(id))
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

        // POST: api/Sizes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Size>> PostSize(Size Size)
        {
            await _unitOfWork.Sizes.Insert(Size);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetSize", new { id = Size.Id }, Size);
        }

        // DELETE: api/Sizes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSize(int id)
        {
            var Size = await _unitOfWork.Sizes.Get(q => q.Id == id);
            if (Size == null)
            {
                return NotFound();
            }
            await _unitOfWork.Sizes.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> SizeExists(int id)
        {
            var Size = await _unitOfWork.Sizes.Get(q => q.Id == id);
            return Size == null;
        }
    }
}