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
    public partial class NewTableForm : SimpleView.Add
    {
        public TableViewModel viewModel;
        private TableForm tableform;

        public NewTableForm(TableForm tableform, int id)
        {
            InitializeComponent();
            this.tableform = tableform;
            viewModel = new TableViewModel();
            viewModel.IdToEdit = id;
            // Liaison des TextBoxes aux propriétés du ViewModel.
            guna2TextBox1.TextChanged += (s, e) => viewModel.numero = guna2TextBox1.Text;
            guna2TextBox2.TextChanged += (s, e) => viewModel.capacite = guna2TextBox2.Text;


            // Événement Click pour le bouton de connexion.
            btnSave.Click += (s, e) =>
            {
                if (id == 0)
                {
                    viewModel.Add();

                    tableform.RefreshData();
                    guna2TextBox1.Clear();
                    guna2TextBox2.Clear();
                }
                else
                {
                    viewModel.Update();
                    tableform.RefreshData();
                    guna2TextBox1.Clear();
                    guna2TextBox2.Clear();
                }




            };


        }

        private void NewTableForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
