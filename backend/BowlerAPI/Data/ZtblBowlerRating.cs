using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BowlerAPI.Data;

public partial class ZtblBowlerRating
{
    [Key]
    [Required]
    public string BowlerRating { get; set; } = null!;

    public short? BowlerLowAvg { get; set; }

    public short? BowlerHighAvg { get; set; }
}
