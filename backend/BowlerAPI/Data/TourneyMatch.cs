using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BowlerAPI.Data;

public partial class TourneyMatch
{
    [Key]
    [Required]
    public int MatchId { get; set; }
    [ForeignKey("Tournament")]
    public int? TourneyId { get; set; }

    public string? Lanes { get; set; }
    [ForeignKey("Team")]
    public int? OddLaneTeamId { get; set; }
    [ForeignKey("Team")]
    public int? EvenLaneTeamId { get; set; }

    public virtual Team? EvenLaneTeam { get; set; }

    public virtual ICollection<MatchGame> MatchGames { get; set; } = new List<MatchGame>();

    public virtual Team? OddLaneTeam { get; set; }

    public virtual Tournament? Tourney { get; set; }
}
