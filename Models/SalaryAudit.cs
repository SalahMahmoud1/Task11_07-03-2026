using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Task11_07_03_2026.Models;

[Table("salary_audit")]
public partial class SalaryAudit
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? EmployeeName { get; set; }

    [Column("salaryBefor", TypeName = "decimal(18, 0)")]
    public decimal? SalaryBefor { get; set; }

    [Column("salaryAfter", TypeName = "decimal(18, 0)")]
    public decimal? SalaryAfter { get; set; }

    [Column("createdAt", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }
}
