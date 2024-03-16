using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BowlerAPI.Data;

public partial class MatchGame
{
    [Key]
    [Required]
    [ForeignKey("Tourney_Match")]
    public int MatchId { get; set; }
    [Key]
    [Required]
    public short GameNumber { get; set; }

    public int? WinningTeamId { get; set; }

    public virtual TourneyMatch Match { get; set; } = null!;
}
