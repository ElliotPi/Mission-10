import { Bowler } from './Bowler';

export type BowlerScores = {
  MatchId: number;
  GameNumber: number;
  BowlerId: number;
  RawScore: number;
  HandiCapScore: number;
  WonGame: boolean;
  Bowler: Bowler;
};
