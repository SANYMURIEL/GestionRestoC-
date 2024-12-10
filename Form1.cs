namespace PROJET_C__GESTIONRESTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            (new Views.LoginForm()).Show();
           
        }
    }
}
