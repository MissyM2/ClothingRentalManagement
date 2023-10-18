using ClothingRentalManagement.Server.Interfaces;
using ClothingRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClothingRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApparelItemsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApparelItemsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /ApparelItems
        [HttpGet]
        public async Task<IActionResult> GetApparelItems()
        {
            var includes = new List<string> { "Brand", "ApparelType", "Color", "Season", "Size" };
            var ApparelItems = await _unitOfWork.ApparelItems.GetAll();
            return Ok(ApparelItems);
        }

        // GET: /ApparelItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetApparelItem(int id)
        {
            var includes = new List<string> { "Brand", "ApparelType", "Color", "Season", "Size", "Wearings" };
            var ApparelItem = await _unitOfWork.ApparelItems.Get(q => q.Id == id);

            if (ApparelItem == null)
            {
                return NotFound();
            }

            return Ok(ApparelItem);
        }

        // PUT: api/ApparelItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApparelItem(int id, ApparelItem ApparelItem)
        {
            if (id != ApparelItem.Id)
            {
                return BadRequest();
            }

            _unitOfWork.ApparelItems.Update(ApparelItem);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ApparelItemExists(id))
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

        // POST: api/ApparelItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ApparelItem>> PostApparelItem(ApparelItem ApparelItem)
        {
            await _unitOfWork.ApparelItems.Insert(ApparelItem);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetApparelItem", new { id = ApparelItem.Id }, ApparelItem);
        }

        // DELETE: api/ApparelItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApparelItem(int id)
        {
            var ApparelItem = await _unitOfWork.ApparelItems.Get(q => q.Id == id);
            if (ApparelItem == null)
            {
                return NotFound();
            }
            await _unitOfWork.ApparelItems.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ApparelItemExists(int id)
        {
            var ApparelItem = await _unitOfWork.ApparelItems.Get(q => q.Id == id);
            return ApparelItem == null;
        }
    }
}
