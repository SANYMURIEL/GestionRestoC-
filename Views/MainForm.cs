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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void AddControls(Form f)
        {
            CenterPanel1.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel1.Controls.Add(f);
            f.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            AddControls(new HomeForm());
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CenterPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            AddControls(new TableForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var result = guna2MessageDialog1.Show();
            if (result == DialogResult.Yes)
            {

                Application.Exit(); // Utilisez Application.Exit() pour fermer complètement l'application
            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            AddControls(new IgdForm());
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
