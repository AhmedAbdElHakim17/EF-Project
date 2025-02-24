using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace EF_Project
{
    public partial class Login : Form
    {
        Roles Roles;
        ApplicationDBContext ApplicationDBContext;
        User User;
        Register Register;
        int id;
        public Login()
        {
            InitializeComponent();
            Register = new Register();
            User = new User();
            Roles = new Roles();
            ApplicationDBContext = new ApplicationDBContext();
        }
        private void btn_login1_Click(object sender, EventArgs e)
        {
            var user = ApplicationDBContext.Users;
            if (user.Any(u => u.UEmail == txt_email1.Text && u.UPassword == txt_pass1.Text))
            {
                id = ApplicationDBContext.Users.Where(u => u.UEmail == txt_email1.Text)
                                               .Select(u => u.UId)
                                               .FirstOrDefault();
                var role = ApplicationDBContext.Users.Where(u => u.UId == id)
                                                     .Select(u => u.role)
                                                     .FirstOrDefault();
                if (role == "admin")
                {
                    this.Hide();
                    Home home = new Home(id);
                    home.ShowDialog();
                }
                else
                {
                    this.Hide();
                    HomeUser home = new HomeUser(id);
                    home.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Wrong Email Or Password. Please Try Again","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_check_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_check.Checked)
                txt_pass1.PasswordChar = '\0';
            else
                txt_pass1.PasswordChar = '*';
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
        }
    }
}
