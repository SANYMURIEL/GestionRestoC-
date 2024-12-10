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
    public partial class NewIgdForm : SimpleView.Add
    {
        public IgdViewModel viewModel;
        private IgdForm igdform;
        public NewIgdForm(IgdForm igdform, int id)
        {
            InitializeComponent();
            this.igdform = igdform;
            viewModel = new IgdViewModel();
            viewModel.IdToEdit = id;

            guna2TextBox1.TextChanged += (s, e) => viewModel.nom = guna2TextBox1.Text;
            guna2TextBox2.TextChanged += (s, e) => viewModel.quantite = guna2TextBox2.Text;




            // Événement Click pour le bouton de connexion.
            btnSave.Click += (s, e) =>
            {
                if (id == 0)
                {
                    viewModel.Add();
                    igdform.RefreshData();
                    guna2TextBox1.Clear();
                    guna2TextBox2.Clear();
                }
                else
                {
                    viewModel.Update();
                    igdform.RefreshData();
                    guna2TextBox1.Clear();
                    guna2TextBox2.Clear();
                }




            };
        }

        private void NewIgdForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
