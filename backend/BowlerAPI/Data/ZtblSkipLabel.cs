using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BowlerAPI.Data;

public partial class ZtblSkipLabel
{
    [Key]
    [Required]
    public int LabelCount { get; set; }
}
