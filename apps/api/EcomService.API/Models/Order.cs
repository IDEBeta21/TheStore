using System;
using System.Collections.Generic;

namespace EcomService.API.Models;

public partial class Order
{
    public Guid ExternalId { get; set; }

    public long Id { get; set; }

    public bool TransactionDone { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public long ProductId { get; set; }

    public long UserId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
