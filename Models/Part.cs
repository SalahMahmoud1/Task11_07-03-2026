using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Task11_07_03_2026.Models;

[Table("parts", Schema = "production")]
public partial class Part
{
    [Key]
    [Column("part_id")]
    public int PartId { get; set; }

    [Column("part_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PartName { get; set; }
}
