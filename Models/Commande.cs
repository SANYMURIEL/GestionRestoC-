using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Commande
{
    public int Id { get; set; }

    public string? NumCom { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int ClientId { get; set; }

    public int ZoneId { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual ICollection<Itemcommande> Itemcommandes { get; set; } = new List<Itemcommande>();

    public virtual Zone Zone { get; set; } = null!;
}
