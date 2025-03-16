using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AspNetTraining2.Models;

public partial class Item
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal Price { get; set; }

    public int? SerialNumberId { get; set; }
    public SerialNumber? SerialNumber { get; set; }

    public int? CategoryId { get; set; }
    [ForeignKey("CategoryId")]
    public Category? Category { get; set; }

    public List<ItemClient>? ItemClients { get; set; }
}
