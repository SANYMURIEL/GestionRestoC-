namespace PROJET_C__GESTIONRESTO.Views.SimpleView
{
    partial class ListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            label2 = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.AutoRoundedCorners = true;
            txtSearch.BorderRadius = 22;
            txtSearch.CustomizableEdges = customizableEdges1;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = Properties.Resources.chercher;
            txtSearch.IconLeftSize = new Size(30, 30);
            txtSearch.Location = new Point(524, 118);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Search Here";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(405, 46);
            txtSearch.TabIndex = 0;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(546, 90);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 1;
            label1.Text = "Search";
            // 
            // btnAdd
            // 
            btnAdd.CheckedState.ImageSize = new Size(64, 64);
            btnAdd.HoverState.ImageSize = new Size(58, 58);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageOffset = new Point(0, 0);
            btnAdd.ImageRotate = 0F;
            btnAdd.ImageSize = new Size(55, 55);
            btnAdd.IndicateFocus = true;
            btnAdd.Location = new Point(23, 90);
            btnAdd.Name = "btnAdd";
            btnAdd.PressedState.ImageSize = new Size(55, 55);
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnAdd.Size = new Size(96, 81);
            btnAdd.TabIndex = 2;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(38, 40);
            label2.Name = "label2";
            label2.Size = new Size(177, 34);
            label2.TabIndex = 3;
            label2.Text = "Header Text";
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillColor = Color.FromArgb(41, 39, 40);
            guna2Separator1.Location = new Point(38, 172);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(891, 15);
            guna2Separator1.TabIndex = 4;
            // 
            // ListForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(983, 791);
            Controls.Add(guna2Separator1);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ListForm";
            Text = "ListForm";
            Load += ListForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Guna.UI2.WinForms.Guna2TextBox txtSearch;
        public Guna.UI2.WinForms.Guna2ImageButton btnAdd;
        public Label label2;
    }
}