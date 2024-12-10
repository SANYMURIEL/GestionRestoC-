using Guna.UI2.WinForms;
using PROJET_C__GESTIONRESTO.Views;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


public class LoginViewModel
{
    public string Username { get; set; }
    public string Password { get; set; }
    Guna2MessageDialog Dialog = new Guna2MessageDialog();
    public void Login(Form loginForm)
    {
        using (var context = new AppDbContext())
        {
           // var hashedPassword = PasswordHelper.HashPassword(Password);
            var user = context.Users.FirstOrDefault(u => u.Username == Username && u.PasswordHash == Password);
            if (user != null)
            {
                // MessageBox.Show("Connexion réussie !");
                var mainForm = new MainForm();
                mainForm.label2.Text = Username; // Update the label text
                mainForm.Show(); // Show the main form
                loginForm.Hide();

            }
            else
            {
                var parentForm = (Form)System.Windows.Forms.Form.ActiveForm;
                Dialog.Buttons = MessageDialogButtons.OK;
                Dialog.Caption = "Login";
                Dialog.Icon = MessageDialogIcon.Information;
                Dialog.Text = "Identifiants invalides.";
                Dialog.Parent = parentForm;
                Dialog.Style = MessageDialogStyle.Light;
                Dialog.Show();
              
            }
        }
    }
   
}