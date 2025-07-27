using System;
using System.Collections.Generic;

namespace EcomService.API.Models;

public partial class Store
{
    public Guid ExternalId { get; set; }

    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public long StoreTypeId { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual StoreType StoreType { get; set; } = null!;
}
