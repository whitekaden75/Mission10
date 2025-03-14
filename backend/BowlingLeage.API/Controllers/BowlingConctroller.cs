using BowlingLeage.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace BowlingLeage.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private BowlingDBcontext _bowlingContext;

        public BowlingController(BowlingDBcontext temp)
        {
            _bowlingContext = temp;
        }
        
        [HttpGet(Name = "GetBowling")]
        public IEnumerable<Bowlers> Get()
        {
            var bowlingList = _bowlingContext.Bowlers
                .Include(b => b.Team)  // Include the related Team data
                .Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks")  // Filter by TeamName from the Team table
                .ToList();  
            return bowlingList;
        }
    }
}