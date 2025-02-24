namespace EF_Project
{
    partial class HomeUser
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUser));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btn_save = new Guna.UI2.WinForms.Guna2Button();
            txt_bud = new Guna.UI2.WinForms.Guna2TextBox();
            sideBar = new Guna.UI2.WinForms.Guna2Panel();
            btn_logout = new Guna.UI2.WinForms.Guna2Button();
            btn_stats1 = new Guna.UI2.WinForms.Guna2Button();
            dashlbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btn_exp1 = new Guna.UI2.WinForms.Guna2Button();
            sideBar.SuspendLayout();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.AutoRoundedCorners = true;
            btn_save.BackColor = Color.Transparent;
            btn_save.CustomizableEdges = customizableEdges1;
            btn_save.DisabledState.BorderColor = Color.DarkGray;
            btn_save.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_save.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_save.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_save.FillColor = Color.FromArgb(0, 192, 0);
            btn_save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(488, 36);
            btn_save.Name = "btn_save";
            btn_save.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_save.Size = new Size(154, 49);
            btn_save.TabIndex = 36;
            btn_save.Text = "Save";
            btn_save.Click += button1_Click_1;
            // 
            // txt_bud
            // 
            txt_bud.CustomizableEdges = customizableEdges3;
            txt_bud.DefaultText = "";
            txt_bud.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_bud.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_bud.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_bud.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_bud.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_bud.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_bud.ForeColor = Color.Black;
            txt_bud.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_bud.Location = new Point(250, 36);
            txt_bud.Margin = new Padding(4);
            txt_bud.Name = "txt_bud";
            txt_bud.PlaceholderForeColor = Color.DimGray;
            txt_bud.PlaceholderText = "Enter Your Budget";
            txt_bud.SelectedText = "";
            txt_bud.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txt_bud.Size = new Size(214, 49);
            txt_bud.TabIndex = 38;
            // 
            // sideBar
            // 
            sideBar.Controls.Add(btn_logout);
            sideBar.Controls.Add(btn_stats1);
            sideBar.Controls.Add(dashlbl);
            sideBar.Controls.Add(btn_exp1);
            sideBar.CustomizableEdges = customizableEdges11;
            sideBar.Dock = DockStyle.Left;
            sideBar.FillColor = Color.DodgerBlue;
            sideBar.ForeColor = Color.DodgerBlue;
            sideBar.Location = new Point(0, 0);
            sideBar.Name = "sideBar";
            sideBar.ShadowDecoration.CustomizableEdges = customizableEdges12;
            sideBar.Size = new Size(200, 561);
            sideBar.TabIndex = 40;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.Transparent;
            btn_logout.BackgroundImageLayout = ImageLayout.None;
            btn_logout.BorderRadius = 10;
            btn_logout.CustomizableEdges = customizableEdges5;
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
            btn_logout.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_logout.Size = new Size(180, 45);
            btn_logout.TabIndex = 11;
            btn_logout.Text = "Logout";
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_stats1
            // 
            btn_stats1.BackColor = Color.Transparent;
            btn_stats1.BorderRadius = 10;
            btn_stats1.CustomizableEdges = customizableEdges7;
            btn_stats1.DisabledState.BorderColor = Color.DarkGray;
            btn_stats1.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_stats1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_stats1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_stats1.FillColor = Color.White;
            btn_stats1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_stats1.ForeColor = Color.DodgerBlue;
            btn_stats1.Image = (Image)resources.GetObject("btn_stats1.Image");
            btn_stats1.ImageAlign = HorizontalAlignment.Left;
            btn_stats1.ImageSize = new Size(30, 30);
            btn_stats1.Location = new Point(10, 130);
            btn_stats1.Name = "btn_stats1";
            btn_stats1.ShadowDecoration.BorderRadius = 10;
            btn_stats1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btn_stats1.Size = new Size(180, 45);
            btn_stats1.TabIndex = 9;
            btn_stats1.Text = "Statistics";
            btn_stats1.Click += btn_stats1_Click;
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
            // btn_exp1
            // 
            btn_exp1.BackColor = Color.Transparent;
            btn_exp1.BorderRadius = 10;
            btn_exp1.CustomizableEdges = customizableEdges9;
            btn_exp1.DisabledState.BorderColor = Color.DarkGray;
            btn_exp1.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_exp1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_exp1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_exp1.FillColor = Color.White;
            btn_exp1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exp1.ForeColor = Color.DodgerBlue;
            btn_exp1.Image = (Image)resources.GetObject("btn_exp1.Image");
            btn_exp1.ImageAlign = HorizontalAlignment.Left;
            btn_exp1.ImageSize = new Size(35, 35);
            btn_exp1.Location = new Point(10, 70);
            btn_exp1.Name = "btn_exp1";
            btn_exp1.ShadowDecoration.BorderRadius = 10;
            btn_exp1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btn_exp1.Size = new Size(180, 45);
            btn_exp1.TabIndex = 6;
            btn_exp1.Text = "Expenses";
            btn_exp1.Click += btn_exp_Click;
            // 
            // HomeUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(834, 561);
            Controls.Add(sideBar);
            Controls.Add(txt_bud);
            Controls.Add(btn_save);
            Name = "HomeUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeUser";
            Load += HomeUser_Load;
            Click += HomeUser_Load;
            sideBar.ResumeLayout(false);
            sideBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2TextBox txt_bud;
        private Guna.UI2.WinForms.Guna2Panel sideBar;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
        private Guna.UI2.WinForms.Guna2Button btn_stats1;
        private Guna.UI2.WinForms.Guna2HtmlLabel dashlbl;
        private Guna.UI2.WinForms.Guna2Button btn_exp1;
    }
}