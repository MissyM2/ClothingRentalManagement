using ClothingRentalManagement.Server.Interfaces;
using ClothingRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClothingRentalManagement.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApparelTypesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApparelTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /ApparelTypes
        [HttpGet]
        public async Task<IActionResult> GetApparelTypes()
        {
            var ApparelTypes = await _unitOfWork.ApparelTypes.GetAll();
            return Ok(ApparelTypes);
        }

        // GET: /ApparelTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetApparelType(int id)
        {
            var ApparelType = await _unitOfWork.ApparelTypes.Get(q => q.Id == id);

            if (ApparelType == null)
            {
                return NotFound();
            }

            return Ok(ApparelType);
        }

        // PUT: api/ApparelTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApparelType(int id, ApparelType ApparelType)
        {
            if (id != ApparelType.Id)
            {
                return BadRequest();
            }

            _unitOfWork.ApparelTypes.Update(ApparelType);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ApparelTypeExists(id))
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

        // POST: api/ApparelTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ApparelType>> PostApparelType(ApparelType ApparelType)
        {
            await _unitOfWork.ApparelTypes.Insert(ApparelType);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetApparelType", new { id = ApparelType.Id }, ApparelType);
        }

        // DELETE: api/ApparelTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApparelType(int id)
        {
            var ApparelType = await _unitOfWork.ApparelTypes.Get(q => q.Id == id);
            if (ApparelType == null)
            {
                return NotFound();
            }
            await _unitOfWork.ApparelTypes.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ApparelTypeExists(int id)
        {
            var ApparelType = await _unitOfWork.ApparelTypes.Get(q => q.Id == id);
            return ApparelType == null;
        }
    }
}