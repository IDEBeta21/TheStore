using System;
using System.Collections.Generic;

namespace EcomService.API.Models;

public partial class StoreType
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Store> Stores { get; set; } = new List<Store>();
}
