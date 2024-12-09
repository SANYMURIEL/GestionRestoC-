using System;
using System.Collections.Generic;

namespace PROJET_C__GESTIONRESTO.Models;

public partial class Reservation
{
    public int Id { get; set; }

    public DateOnly? StartAt { get; set; }

    public DateOnly? FinishedAd { get; set; }

    public string? State { get; set; }

    public string? Detail { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int ClientId { get; set; }

    public int TableId { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual Table Table { get; set; } = null!;
}
