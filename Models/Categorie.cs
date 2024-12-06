using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Categorie
{
    public int Id { get; set; }

    public string? Intitule { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<Provision> Provisions { get; set; } = new List<Provision>();
}
