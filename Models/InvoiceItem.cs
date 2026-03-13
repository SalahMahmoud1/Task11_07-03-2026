using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Task11_07_03_2026.Models;

[PrimaryKey("Id", "InvoiceId")]
[Table("invoice_items")]
public partial class InvoiceItem
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Key]
    [Column("invoice_id")]
    public int InvoiceId { get; set; }

    [Column("item_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string ItemName { get; set; } = null!;

    [Column("amount", TypeName = "decimal(10, 2)")]
    public decimal Amount { get; set; }

    [Column("tax", TypeName = "decimal(4, 2)")]
    public decimal Tax { get; set; }

    [ForeignKey("InvoiceId")]
    [InverseProperty("InvoiceItems")]
    public virtual Invoice Invoice { get; set; } = null!;
}
