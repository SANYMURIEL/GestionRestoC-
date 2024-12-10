using Guna.UI2.WinForms;
using PROJET_C__GESTIONRESTO.Views;
using System.Windows;
using System.Windows.Forms;


    public class TableViewModel
    {
    public string numero { get; set; }
    public string capacite { get; set; }
   public  string searchTerm { get; set; }
    public int IdToEdit { get; set; }
    Guna2MessageDialog Dialog = new Guna2MessageDialog();
    public Guna2DataGridView dataGridView1  { get; set; }

    
    public void Add()
    {
        using (var context = new AppDbContext())
        {
            // Créer un nouvel objet Table à partir des valeurs des champs de texte
            var newTable = new Table
            {
                Numero = int.Parse(numero),
                Capacite = int.Parse(capacite),
                Statut = "libre"// Récupère l'ID de la catégorie et le convertit en int
            };
            // Ajouter le nouvel objet Table au contexte
            context.Tables.Add(newTable);
            // Enregistrer les modifications dans la base de données
            context.SaveChanges();
            var parentForm = (Form)System.Windows.Forms.Form.ActiveForm;
            Dialog.Buttons = MessageDialogButtons.OK;
            Dialog.Caption = "Ajout de Table";
            Dialog.Icon =MessageDialogIcon.Information;
            Dialog.Text = "Table ajouté avec succès !";
            Dialog.Parent = parentForm;
            Dialog.Style =MessageDialogStyle.Light;
            Dialog.Show();
   

        }
    }
    public void LoadTables()
    {
        using (var context = new AppDbContext())
        {
            // Récupérer toutes les tables de la base de données
            var tables = context.Tables.ToList();

            // Lier la liste des tables au DataGridView
            dataGridView1.DataSource = null; // Réinitialiser la source pour éviter des problèmes de liaison
            dataGridView1.DataSource = tables;

            // Optionnel : Configurer les colonnes si nécessaire
            dataGridView1.Columns["Numero"].HeaderText = "Number";
            dataGridView1.Columns["Capacite"].HeaderText = "Capacity";
            dataGridView1.Columns["Statut"].HeaderText = "State";
        }
    }

    public void Delete(int id)
    {
        using (var context = new AppDbContext())
        {
            var tableToDelete = context.Tables.Find(id);
            if (tableToDelete != null)
            {
                context.Tables.Remove(tableToDelete);
                context.SaveChanges();
                var parentForm = (Form)System.Windows.Forms.Form.ActiveForm;
                Dialog.Buttons = MessageDialogButtons.OK;
                Dialog.Caption = "Suppression de Table";
                Dialog.Icon = MessageDialogIcon.Information;
                Dialog.Text = "Table supprimée avec succès !";
                Dialog.Parent = parentForm;
                Dialog.Style = MessageDialogStyle.Light;
                Dialog.Show();
                
               LoadTables(); // Rechargez les tables après la suppression
            }
        }
    }
    public void Update()
    {
        using (var context = new AppDbContext())
        {
            var tableToUpdate = context.Tables.Find(IdToEdit);

            if (tableToUpdate != null)
            {
                // Assurez-vous que Numero et Capacite sont des chaînes et convertissez-les en int
                if (int.TryParse(numero, out int numeroInt) && int.TryParse(capacite, out int capaciteInt))
                {
                    tableToUpdate.Numero = numeroInt;
                    tableToUpdate.Capacite = capaciteInt;
                    context.SaveChanges();
                    var parentForm = (Form)System.Windows.Forms.Form.ActiveForm;
                    Dialog.Buttons = MessageDialogButtons.OK;
                    Dialog.Caption = "Modification de Table";
                    Dialog.Icon = MessageDialogIcon.Information;
                    Dialog.Text = "Table modifiée avec succès !";
                    Dialog.Parent = parentForm;
                    Dialog.Style = MessageDialogStyle.Light;
                    Dialog.Show();
                    
                  //  LoadTables(); // Rechargez les tables après la mise à jour
                }
               
            }
        }
    }

    public void FilterData()
    {
        using (var context = new AppDbContext())
        {
            var tables = context.Tables.ToList(); // Récupérer toutes les tables

            // Filtrer les tables en fonction du numéro ou de la capacité
            var filteredTables = tables.Where(t =>
                t.Numero.ToString().Contains(searchTerm) ||
                t.Capacite.ToString().Contains(searchTerm)).ToList();

            // Lier les résultats filtrés au DataGridView
            dataGridView1.DataSource = null; // Réinitialiser la source pour éviter des problèmes de liaison
            dataGridView1.DataSource = filteredTables;

         
        }
    }

}

