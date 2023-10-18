using ClothingRentalManagement.Server.Interfaces;
using ClothingRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClothingRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeasonsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SeasonsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Seasons
        [HttpGet]
        public async Task<IActionResult> GetSeasons()
        {
            var Seasons = await _unitOfWork.Seasons.GetAll();
            return Ok(Seasons);
        }

        // GET: /Seasons/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSeason(int id)
        {
            var Season = await _unitOfWork.Seasons.Get(q => q.Id == id);

            if (Season == null)
            {
                return NotFound();
            }

            return Ok(Season);
        }

        // PUT: api/Seasons/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSeason(int id, Season Season)
        {
            if (id != Season.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Seasons.Update(Season);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await SeasonExists(id))
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

        // POST: api/Seasons
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Season>> PostSeason(Season Season)
        {
            await _unitOfWork.Seasons.Insert(Season);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetSeason", new { id = Season.Id }, Season);
        }

        // DELETE: api/Seasons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSeason(int id)
        {
            var Season = await _unitOfWork.Seasons.Get(q => q.Id == id);
            if (Season == null)
            {
                return NotFound();
            }
            await _unitOfWork.Seasons.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> SeasonExists(int id)
        {
            var Season = await _unitOfWork.Seasons.Get(q => q.Id == id);
            return Season == null;
        }
    }
}