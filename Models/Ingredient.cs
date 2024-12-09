using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Ingredient
{
    public int Id { get; set; }

    public DateTime? CreateAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int ProductId { get; set; }

    public int ProvisionId { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual Provision Provision { get; set; } = null!;
}
