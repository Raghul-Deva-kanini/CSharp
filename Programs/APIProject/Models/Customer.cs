using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIProject.Models;

public partial class Customer
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public long? Phone { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<CustomerProd> CustomerProds { get; set; } = new List<CustomerProd>();
}
