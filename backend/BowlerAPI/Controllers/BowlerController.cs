using BowlerAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace BowlerAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlingLeagueRepository _bowlingleagueRepository;  // Implement the Repository Pattern
        public BowlerController (IBowlingLeagueRepository temp) // The Constructor
        {
            _bowlingleagueRepository = temp;
        }

        [HttpGet]
        public IEnumerable<object> Get()
        {
            var joinedData = from bowler in _bowlingleagueRepository.Bowlers  // Using Linq to join tables
                             join team in _bowlingleagueRepository.Teams
                             on bowler.TeamId equals team.TeamId
                             select new Bowler
                             {
                                 BowlerId = bowler.BowlerId,
                                 BowlerLastName = bowler.BowlerLastName,
                                 BowlerFirstName = bowler.BowlerFirstName,
                                 BowlerMiddleInit = bowler.BowlerMiddleInit,
                                 BowlerAddress = bowler.BowlerAddress,
                                 BowlerCity = bowler.BowlerCity,
                                 BowlerState = bowler.BowlerState,
                                 BowlerZip = bowler.BowlerZip,
                                 BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                                 TeamId = bowler.TeamId,
                                 Team = team
                             };
            /*var filteredData = joinedData.Where(x => x.Team.TeamName == "Marlins" || x.Team.TeamName == "Sharks").ToList();*/

            var filteredData = _bowlingleagueRepository.FilterByTeam(joinedData);  // filter the joined table to only return 


            return filteredData;
        }
    }
}
