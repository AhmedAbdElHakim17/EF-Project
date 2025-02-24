namespace EF_Project
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btn_exp = new Guna.UI2.WinForms.Guna2Button();
            sideBar = new Guna.UI2.WinForms.Guna2Panel();
            btn_logout = new Guna.UI2.WinForms.Guna2Button();
            btn_users = new Guna.UI2.WinForms.Guna2Button();
            btn_cat = new Guna.UI2.WinForms.Guna2Button();
            dashlbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            sideBar.SuspendLayout();
            SuspendLayout();
            // 
            // btn_exp
            // 
            btn_exp.BackColor = Color.Transparent;
            btn_exp.BorderRadius = 10;
            btn_exp.CustomizableEdges = customizableEdges1;
            btn_exp.DisabledState.BorderColor = Color.DarkGray;
            btn_exp.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_exp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_exp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_exp.FillColor = Color.White;
            btn_exp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exp.ForeColor = Color.DodgerBlue;
            btn_exp.Image = (Image)resources.GetObject("btn_exp.Image");
            btn_exp.ImageAlign = HorizontalAlignment.Left;
            btn_exp.ImageSize = new Size(35, 35);
            btn_exp.Location = new Point(10, 70);
            btn_exp.Name = "btn_exp";
            btn_exp.ShadowDecoration.BorderRadius = 10;
            btn_exp.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_exp.Size = new Size(180, 45);
            btn_exp.TabIndex = 6;
            btn_exp.Text = "Expenses";
            btn_exp.Click += btn_exp_Click;
            // 
            // sideBar
            // 
            sideBar.Controls.Add(btn_logout);
            sideBar.Controls.Add(btn_users);
            sideBar.Controls.Add(btn_cat);
            sideBar.Controls.Add(dashlbl);
            sideBar.Controls.Add(btn_exp);
            sideBar.CustomizableEdges = customizableEdges9;
            sideBar.Dock = DockStyle.Left;
            sideBar.FillColor = Color.DodgerBlue;
            sideBar.ForeColor = Color.DodgerBlue;
            sideBar.Location = new Point(0, 0);
            sideBar.Name = "sideBar";
            sideBar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            sideBar.Size = new Size(200, 561);
            sideBar.TabIndex = 9;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.Transparent;
            btn_logout.BackgroundImageLayout = ImageLayout.None;
            btn_logout.BorderRadius = 10;
            btn_logout.CustomizableEdges = customizableEdges3;
            btn_logout.DisabledState.BorderColor = Color.DarkGray;
            btn_logout.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_logout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_logout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_logout.FillColor = Color.Red;
            btn_logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = Color.DodgerBlue;
            btn_logout.Image = (Image)resources.GetObject("btn_logout.Image");
            btn_logout.ImageAlign = HorizontalAlignment.Left;
            btn_logout.ImageSize = new Size(30, 30);
            btn_logout.Location = new Point(10, 500);
            btn_logout.Name = "btn_logout";
            btn_logout.ShadowDecoration.BorderRadius = 10;
            btn_logout.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_logout.Size = new Size(180, 45);
            btn_logout.TabIndex = 11;
            btn_logout.Text = "Logout";
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_users
            // 
            btn_users.BackColor = Color.Transparent;
            btn_users.BorderRadius = 10;
            btn_users.CustomizableEdges = customizableEdges5;
            btn_users.DisabledState.BorderColor = Color.DarkGray;
            btn_users.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_users.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_users.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_users.FillColor = Color.White;
            btn_users.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_users.ForeColor = Color.DodgerBlue;
            btn_users.Image = (Image)resources.GetObject("btn_users.Image");
            btn_users.ImageAlign = HorizontalAlignment.Left;
            btn_users.ImageSize = new Size(30, 30);
            btn_users.Location = new Point(10, 190);
            btn_users.Name = "btn_users";
            btn_users.ShadowDecoration.BorderRadius = 10;
            btn_users.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_users.Size = new Size(180, 45);
            btn_users.TabIndex = 10;
            btn_users.Text = "Users";
            btn_users.Click += btn_users_Click;
            // 
            // btn_cat
            // 
            btn_cat.BackColor = Color.Transparent;
            btn_cat.BorderRadius = 10;
            btn_cat.CustomizableEdges = customizableEdges7;
            btn_cat.DisabledState.BorderColor = Color.DarkGray;
            btn_cat.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_cat.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_cat.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_cat.FillColor = Color.White;
            btn_cat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cat.ForeColor = Color.DodgerBlue;
            btn_cat.Image = (Image)resources.GetObject("btn_cat.Image");
            btn_cat.ImageAlign = HorizontalAlignment.Left;
            btn_cat.ImageSize = new Size(30, 30);
            btn_cat.Location = new Point(10, 130);
            btn_cat.Name = "btn_cat";
            btn_cat.ShadowDecoration.BorderRadius = 10;
            btn_cat.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btn_cat.Size = new Size(180, 45);
            btn_cat.TabIndex = 9;
            btn_cat.Text = "Categories";
            btn_cat.Click += btn_cat_Click;
            // 
            // dashlbl
            // 
            dashlbl.BackColor = Color.Transparent;
            dashlbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashlbl.ForeColor = Color.Black;
            dashlbl.Location = new Point(34, 24);
            dashlbl.Name = "dashlbl";
            dashlbl.Size = new Size(127, 34);
            dashlbl.TabIndex = 0;
            dashlbl.Text = "Dashboard";
            // 
            // mainPanel
            // 
            mainPanel.BackgroundImage = (Image)resources.GetObject("mainPanel.BackgroundImage");
            mainPanel.BackgroundImageLayout = ImageLayout.Stretch;
            mainPanel.CustomizableEdges = customizableEdges11;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(200, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            mainPanel.Size = new Size(634, 561);
            mainPanel.TabIndex = 10;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(834, 561);
            Controls.Add(mainPanel);
            Controls.Add(sideBar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            sideBar.ResumeLayout(false);
            sideBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_exp;
        private Guna.UI2.WinForms.Guna2Panel sideBar;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel dashlbl;
        private Guna.UI2.WinForms.Guna2Button btn_cat;
        private Guna.UI2.WinForms.Guna2Button btn_users;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
    }
}