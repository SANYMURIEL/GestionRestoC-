using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using PROJET_C__GESTIONRESTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppContext = PROJET_C__GESTIONRESTO.Orm.AppContext;

namespace PROJET_C__GESTIONRESTO.Views
{
    public partial class LoginForm : Form
    {
        private string connectionString;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            var configuration = ConfigurationHelper.GetConfiguration();
            connectionString = configuration.GetConnectionString("MySqlConnection");
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                txtPwd.PasswordChar = '\0'; // On efface le caractère de masquage
            }
            else
            {
                txtPwd.PasswordChar = '*'; // On remet le caractère de masquage
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtPwd.Text;

            if (name.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("les deux champs sont obligatoire");
                return;
            }
            var contexte = new AppContext(connectionString);
            MessageBox.Show("retour: " + contexte.Operateurs.FirstOrDefault(o => o.Email == name && o.Password == password));
            return;
            using (var context = new AppContext(connectionString))
            {
                Operateur? operateur = context.Operateurs.FirstOrDefault(o => o.Email == name && o.Password == password);

                if (operateur == null)
                {
                    MessageBox.Show("Connexion reussie");
                    return;
                }

                MessageBox.Show("Connexion reussie");
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
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

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
