using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PROJET_C__GESTIONRESTO.Views
{
    public partial class LoginForm : Form
    {

        public LoginViewModel viewModel;

        public LoginForm()
        {
            InitializeComponent();
            viewModel = new LoginViewModel(); // Initialisation ici
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                guna2TextBox2.PasswordChar = '\0'; // On efface le caractère de masquage
            }
            else
            {
                guna2TextBox2.PasswordChar = '*'; // On remet le caractère de masquage
            }
        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {

            var result = guna2MessageDialog1.Show();
            if (result == DialogResult.Yes)
            {

                Application.Exit(); // Utilisez Application.Exit() pour fermer complètement l'application
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            viewModel = new LoginViewModel();


            viewModel.Username = guna2TextBox1.Text;
            viewModel.Password = guna2TextBox2.Text;

            viewModel.Login(this);
            guna2TextBox1.Clear();
            guna2TextBox2.Clear();

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        

        }
    }
}
