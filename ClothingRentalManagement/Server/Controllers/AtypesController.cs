using ClothingRentalManagement.Server.Interfaces;
using ClothingRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClothingRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtypesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AtypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Atypes
        [HttpGet]
        public async Task<IActionResult> GetAtypes()
        {
            var Atypes = await _unitOfWork.Atypes.GetAll();
            return Ok(Atypes);
        }

        // GET: /Atypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAtype(int id)
        {
            var Atype = await _unitOfWork.Atypes.Get(q => q.Id == id);

            if (Atype == null)
            {
                return NotFound();
            }

            return Ok(Atype);
        }

        // PUT: api/Atypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAtype(int id, Atype Atype)
        {
            if (id != Atype.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Atypes.Update(Atype);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await AtypeExists(id))
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

        // POST: api/Atypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Atype>> PostAtype(Atype Atype)
        {
            await _unitOfWork.Atypes.Insert(Atype);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetAtype", new { id = Atype.Id }, Atype);
        }

        // DELETE: api/Atypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAtype(int id)
        {
            var Atype = await _unitOfWork.Atypes.Get(q => q.Id == id);
            if (Atype == null)
            {
                return NotFound();
            }
            await _unitOfWork.Atypes.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> AtypeExists(int id)
        {
            var Atype = await _unitOfWork.Atypes.Get(q => q.Id == id);
            return Atype == null;
        }
    }
}