﻿using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Cover
{
    public int Id { get; set; }

    public string Designation { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<Zone> Zones { get; set; } = new List<Zone>();
}
