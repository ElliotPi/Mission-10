using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BowlerAPI.Data;

public partial class Tournament
{
    [Key]
    [Required]
    public int TourneyId { get; set; }

    public DateOnly? TourneyDate { get; set; }

    public string? TourneyLocation { get; set; }

    public virtual ICollection<TourneyMatch> TourneyMatches { get; set; } = new List<TourneyMatch>();
}
