using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Designation { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int CategorieId { get; set; }

    public virtual Categorie Categorie { get; set; } = null!;

    public virtual ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

    public virtual ICollection<Itemcommande> Itemcommandes { get; set; } = new List<Itemcommande>();

    public virtual ICollection<Menuitem> Menuitems { get; set; } = new List<Menuitem>();
}
