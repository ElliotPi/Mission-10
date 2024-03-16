
using System.Linq;

namespace BowlerAPI.Data
{
    public class EFBowlingLeagueRepository : IBowlingLeagueRepository
    {
        private BowlingLeagueContext _bowlingleaguecontext;

        public EFBowlingLeagueRepository(BowlingLeagueContext temp) 
        { 
            _bowlingleaguecontext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _bowlingleaguecontext.Bowlers;

        public IEnumerable<BowlerScore> Bowler_Scores => _bowlingleaguecontext.BowlerScores;

        public IEnumerable<MatchGame> Match_Games => _bowlingleaguecontext.MatchGames;

        public IEnumerable<Team> Teams => _bowlingleaguecontext.Teams;

        public IEnumerable<Tournament> Tournaments => _bowlingleaguecontext.Tournaments;

        public IEnumerable<TourneyMatch> Tourney_Matches => _bowlingleaguecontext.TourneyMatches;

        public IEnumerable<ZtblBowlerRating> ztblBowlerRatings => _bowlingleaguecontext.ZtblBowlerRatings;

        public IEnumerable<ZtblSkipLabel> ztblSkipLabels => _bowlingleaguecontext.ZtblSkipLabels;

        public IEnumerable<ZtblWeek> ztblWeeks => _bowlingleaguecontext.ZtblWeeks;

        public IEnumerable<Bowler> FilterByTeam(IEnumerable<Bowler> bowlers)  // This helps to filter the bowlers based on their team
        {
            return bowlers.Where(x => x.Team.TeamName == "Marlins" || x.Team.TeamName == "Sharks").ToList();
        }


    }
}
