﻿namespace BowlerAPI.Data
{
    public interface IBowlingLeagueRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<BowlerScore> Bowler_Scores { get; }
        IEnumerable<MatchGame> Match_Games { get; }
        IEnumerable<Team> Teams { get; }
        IEnumerable<Tournament> Tournaments { get; }
        IEnumerable<TourneyMatch> Tourney_Matches { get; }
        IEnumerable<ZtblBowlerRating> ztblBowlerRatings { get; }
        IEnumerable<ZtblSkipLabel> ztblSkipLabels { get; }
        IEnumerable<ZtblWeek> ztblWeeks { get; }
        IEnumerable<Bowler> FilterByTeam(IEnumerable<Bowler> bowlers);
    }
}
