using System.ComponentModel.DataAnnotations;

public class Table
{
    [Key]
    public int Id { get; set; }
    public int Numero { get; set; }
    public int Capacite { get; set; }
    public string Statut { get; set; }
   
}

