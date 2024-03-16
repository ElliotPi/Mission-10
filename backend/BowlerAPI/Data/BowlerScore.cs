using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BowlerAPI.Data;

public partial class BowlerScore
{
    [Key]
    [Required]
    public int MatchId { get; set; }
    [Key]
    [Required]
    public short GameNumber { get; set; }
    [Key]
    [ForeignKey("Bowler")]
    [Required]
    public int BowlerId { get; set; }

    public short? RawScore { get; set; }

    public short? HandiCapScore { get; set; }

    public bool WonGame { get; set; }
    [Required]
    public virtual Bowler Bowler { get; set; } = null!;
}
