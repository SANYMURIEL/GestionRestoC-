using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Client
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Prenom { get; set; }

    public DateTime? DateNaiss { get; set; }

    public string? Tel { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int OperateurId { get; set; }

    public virtual ICollection<Commande> Commandes { get; set; } = new List<Commande>();

    public virtual Operateur Operateur { get; set; } = null!;

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
