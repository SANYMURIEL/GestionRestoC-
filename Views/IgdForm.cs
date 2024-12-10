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

namespace PROJET_C__GESTIONRESTO.Views
{
    public partial class IgdForm : SimpleView.ListForm
    {
        public Guna2MessageDialog Dialog = new Guna2MessageDialog();

        private IgdViewModel viewModel;
        public IgdForm()
        {
            InitializeComponent();
        }

        private void IgdForm_Load(object sender, EventArgs e)
        {
            viewModel = new IgdViewModel();
            viewModel.dataGridView1 = guna2DataGridView1;
            viewModel.LoadIgd();
        }
        public void RefreshData()
        {
            viewModel.LoadIgd(); // This will refresh the DataGridView with updated data
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            var newIgdForm = new NewIgdForm(this, 0);
            newIgdForm.ShowDialog();
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
                Dialog.Text = "Êtes-vous sûr de vouloir supprimer cet Ingredient ?";
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
                if (int.TryParse(guna2DataGridView1.Rows[e.RowIndex].Cells["Quantite"].Value.ToString(), out int currentQuantite))
                {
                    string currentNom = guna2DataGridView1.Rows[e.RowIndex].Cells["Nom"].Value.ToString();

                    // Ouvrir le formulaire de modification
                    NewIgdForm editForm = new NewIgdForm(this, idToEdit);
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
            viewModel.searchTerm = txtSearch.Text;
            viewModel.FilterData();
        }
    }
}
