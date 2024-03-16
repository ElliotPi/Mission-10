import { TourneyMatch } from './TourneyMatch';

export type Tournament = {
  tourneyId: number;
  tourneyDate: Date;
  tourneyLocation: string;
  tourneyMatches: TourneyMatch;
};
