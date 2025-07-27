using System;
using System.Collections.Generic;

namespace EcomService.API.Models;

public partial class User
{
    public Guid ExternalId { get; set; }

    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Username { get; set; } = null!;

    public byte[] Password { get; set; } = null!;

    public byte[] PasswordSalt { get; set; } = null!;

    public string? Gender { get; set; }

    public DateOnly Birthdate { get; set; }

    public string Address { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public bool IsAccDeleted { get; set; }

    public DateTime CreatedAt { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
