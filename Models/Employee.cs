using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Task11_07_03_2026.Models;

[Table("Employee")]
public partial class Employee
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("salary", TypeName = "decimal(18, 0)")]
    public decimal? Salary { get; set; }
}
