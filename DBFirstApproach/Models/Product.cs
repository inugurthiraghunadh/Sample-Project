using System;
using System.Collections.Generic;

namespace DBFirstApproach.Models;

public partial class Product
{
    public Guid ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal Price { get; set; }
}
