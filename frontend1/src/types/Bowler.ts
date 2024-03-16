import { BowlerScores } from './BowlerScore';
import { Team } from './Team';

export type Bowler = {
  bowlerId: number;

  bowlerLastName: string;

  bowlerFirstName: string;

  bowlerMiddleInit: string;

  bowlerAddress: string;

  bowlerCity: string;

  bowlerState: string;

  bowlerZip: string;

  bowlerPhoneNumber: string;
  teamId?: number;
  bowlerScores: BowlerScores[];
  team?: Team;
};

// interface BowlerScores {
//   matchId: number;
//   gameNumber: number;
//   bowlerId: number;
//   rawScore: number;
//   handiCapScore: number;
//   wonGame: boolean;
//   bowler: Bowler;
// }

// interface Team {
//   teanId: number;
//   teamName: string;
//   captainId: number;
//   bowlers: Bowler[];
//   tourneyMatchEvenLaneTeams: TourneyMatch[];
//   tourneyMatchOddLaneTeams: TourneyMatch[];
// }

// interface TourneyMatch {
//   matchId: number;
//   tourneyId: number;
//   lanes: string;
//   oddLaneTeamId: number;
//   evenLaneTeamId: number;
//   evenLaneTeam: Team;
//   matchGames: MatchGame[];
//   oddLaneTeam: Team;
//   tourney: Tournament;
// }

// interface MatchGame {
//   matchId: number;
//   gameNumber: number;
//   winningTeamId: number;
//   match: TourneyMatch;
// }

// interface Tournament {
//   tourneyId: number;
//   tourneyDate: Date;
//   tourneyLocation: string;
//   tourneyMatches: TourneyMatch;
// }
