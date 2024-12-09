using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Itemcommande
{
    public int Id { get; set; }

    public DateTime? CreateAt { get; set; }

    public DateTime? UpdateaAt { get; set; }

    public int CommandeId { get; set; }

    public int ProductId { get; set; }

    public virtual Commande Commande { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
