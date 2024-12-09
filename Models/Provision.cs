using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Provision
{
    public int Id { get; set; }

    public string? Designation { get; set; }

    public int? Quantite { get; set; }

    public string? Unite { get; set; }

    public string? Type { get; set; }

    public DateTime? CreateAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int CategorieId { get; set; }

    public virtual Categorie Categorie { get; set; } = null!;

    public virtual ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
}
