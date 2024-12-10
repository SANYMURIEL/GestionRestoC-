using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PROJET_C__GESTIONRESTO.Views
{
    public partial class TableForm : SimpleView.ListForm
    {
        public Guna2MessageDialog Dialog = new Guna2MessageDialog();

        private TableViewModel viewModel;
        public TableForm()
        {
            InitializeComponent();
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            viewModel = new TableViewModel();
            viewModel.dataGridView1 = guna2DataGridView1;
            viewModel.LoadTables();
        }
        public void RefreshData()
        {
            viewModel.LoadTables(); // This will refresh the DataGridView with updated data
        }
        

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            var newTableForm = new NewTableForm(this, 0);
            newTableForm.ShowDialog();
           
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == guna2DataGridView1.Columns["dgvdel"].Index && e.RowIndex >= 0)
            {
                int idToDelete = (int)guna2DataGridView1.Rows[e.RowIndex].Cells["Id"].Value; // Remplacez "Id" par le nom de votre colonne ID
                var parentForm = (Form)System.Windows.Forms.Form.ActiveForm;
                Dialog.Buttons = MessageDialogButtons.YesNo;
                Dialog.Caption = "Confirmation";
                Dialog.Icon = MessageDialogIcon.Information;
                Dialog.Text = "Êtes-vous sûr de vouloir supprimer cette table ?";
                Dialog.Parent = parentForm;
                Dialog.Style = MessageDialogStyle.Light;
               var confirmResult = Dialog.Show();
               
                if (confirmResult == DialogResult.Yes)
                {

                    viewModel.Delete(idToDelete); 
                }
               
                
            }
            if (e.ColumnIndex == guna2DataGridView1.Columns["dgvedit"].Index && e.RowIndex >= 0)
            {
                int idToEdit = (int)guna2DataGridView1.Rows[e.RowIndex].Cells["Id"].Value; // Remplacez "Id" par le nom de votre colonne ID

                if (int.TryParse(guna2DataGridView1.Rows[e.RowIndex].Cells["Numero"].Value.ToString(), out int currentNumero) &&
            int.TryParse(guna2DataGridView1.Rows[e.RowIndex].Cells["Capacite"].Value.ToString(), out int currentCapacite))
                {
                    // Ouvrir le formulaire de modification
                    NewTableForm editForm = new NewTableForm(this, idToEdit);
                    editForm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Erreur lors de la récupération des données.");
                }
            }
            
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            viewModel.searchTerm = txtSearch.Text.ToLower();
            viewModel.FilterData();

        }
    }

}
