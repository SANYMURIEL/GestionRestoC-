using System.ComponentModel.DataAnnotations;

public class Ingredient
{
    [Key]
    public int Id { get; set; }
    public string Nom { get; set; }
    public int Quantite { get; set; }
   

}

