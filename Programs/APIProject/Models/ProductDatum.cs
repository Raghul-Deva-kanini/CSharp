using System;
using System.Collections.Generic;

namespace APIProject.Models;

public partial class ProductDatum
{
    public string ProductId { get; set; } = null!;

    public string? ProductName { get; set; }

    public int? QuantityAvailable { get; set; }

    public decimal? Cost { get; set; }

    public virtual ICollection<CustomerProd> CustomerProds { get; set; } = new List<CustomerProd>();
}
