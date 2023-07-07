using System;
using System.Collections.Generic;

namespace APIProject.Models;

public partial class CustomerProd
{
    public int ItemNo { get; set; }

    public int? CustomerId { get; set; }

    public string? ProductId { get; set; }

    public int? ProductQuantity { get; set; }

    public decimal? TotalCost { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ProductDatum? Product { get; set; }
}
