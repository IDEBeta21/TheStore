using System;
using System.Collections.Generic;

namespace EcomService.API.Models;

public partial class Product
{
    public Guid ExternalId { get; set; }

    public long Id { get; set; }

    public string Image { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public DateTime CreatedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public long ProductTypeId { get; set; }

    public long StoreId { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ProductType ProductType { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;
}
