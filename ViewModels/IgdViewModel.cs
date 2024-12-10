using Guna.UI2.WinForms;
using PROJET_C__GESTIONRESTO.Views;
using System.Windows;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


public class IgdViewModel
{
    public string nom { get; set; }
    public string quantite { get; set; }
    public string searchTerm { get; set; }
    public int IdToEdit { get; set; }
    Guna2MessageDialog Dialog = new Guna2MessageDialog();
    public Guna2DataGridView dataGridView1 { get; set; }

    public void Add()
    {
        using (var context = new AppDbContext())
        {    
            var newIgd = new Ingredient
            {
                Nom = nom,
                Quantite= int.Parse(quantite),
                
            };
            context.Ingredients.Add(newIgd);
            context.SaveChanges();
            var parentForm = (Form)System.Windows.Forms.Form.ActiveForm;
            Dialog.Buttons = MessageDialogButtons.OK;
            Dialog.Caption = "Ajout de l'Ingredient";
            Dialog.Icon = MessageDialogIcon.Information;
            Dialog.Text = "Ingredient ajouté avec succès !";
            Dialog.Parent = parentForm;
            Dialog.Style = MessageDialogStyle.Light;
            Dialog.Show();
        }
    }
    public void LoadIgd()
    {
        using (var context = new AppDbContext())
        {
            var ingredients = context.Ingredients.ToList();

            // Lier la liste des tables au DataGridView
            dataGridView1.DataSource = null; // Réinitialiser la source pour éviter des problèmes de liaison
            dataGridView1.DataSource = ingredients;
        }
    }

    public void Delete(int id)
    {
        using (var context = new AppDbContext())
        {
            var IgdToDelete = context.Ingredients.Find(id);
            if (IgdToDelete != null)
            {
                context.Ingredients.Remove(IgdToDelete);
                context.SaveChanges();
                var parentForm = (Form)System.Windows.Forms.Form.ActiveForm;
                Dialog.Buttons = MessageDialogButtons.OK;
                Dialog.Caption = "Suppression d'Ingredient";
                Dialog.Icon = MessageDialogIcon.Information;
                Dialog.Text = "Ingredient supprimé avec succès !";
                Dialog.Parent = parentForm;
                Dialog.Style = MessageDialogStyle.Light;
                Dialog.Show();

                LoadIgd(); // Rechargez les tables après la suppression
            }
        }
    }

    public void Update()
    {
        using (var context = new AppDbContext())
        {
            var IgdToUpdate = context.Ingredients.Find(IdToEdit);

            if (IgdToUpdate != null)
            {
              
                    
                   
                if ( int.TryParse(quantite, out int quantiteInt))
                {
                    IgdToUpdate.Nom = nom;
                    IgdToUpdate.Quantite = quantiteInt;
                    context.SaveChanges();
                    var parentForm = (Form)System.Windows.Forms.Form.ActiveForm;
                    Dialog.Buttons = MessageDialogButtons.OK;
                    Dialog.Caption = "Modification d'Ingredient";
                    Dialog.Icon = MessageDialogIcon.Information;
                    Dialog.Text = "Ingredient modifiée avec succès !";
                    Dialog.Parent = parentForm;
                    Dialog.Style = MessageDialogStyle.Light;
                    Dialog.Show();
                }
                   
              

            }
        }
    }

    public void FilterData()
    {
        using (var context = new AppDbContext())
        {
            var ingredients = context.Ingredients.ToList(); // Récupérer toutes les tables
            var filteredTables = ingredients.Where(t =>
                t.Nom.Contains(searchTerm) ||
                t.Quantite.ToString().Contains(searchTerm)).ToList();
            dataGridView1.DataSource = null; // Réinitialiser la source pour éviter des problèmes de liaison
            dataGridView1.DataSource = filteredTables;


        }
    }

}