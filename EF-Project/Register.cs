using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;

namespace EF_Project
{
    public partial class Register : Form
    {
        ApplicationDBContext AppDbContext;
        User User;
        public Register()
        {
            InitializeComponent();
            AppDbContext = new ApplicationDBContext();
            User = new User();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void cb_check_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_check.Checked)
                txt_pass.PasswordChar = '\0';
            else
                txt_pass.PasswordChar = '*';
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            if (txt_fname.Text != string.Empty && txt_lname.Text != string.Empty && txt_pass.Text != string.Empty && txt_email.Text != string.Empty && txt_age.Text != string.Empty && txt_budget.Text != string.Empty)
            {
                if (Regex.IsMatch(txt_email.Text, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", RegexOptions.IgnoreCase))
                {
                    var users = AppDbContext.Users;
                    if (!users.Any(u => u.UEmail == txt_email.Text))
                    {
                        User = new User
                        {
                            UfName = txt_fname.Text,
                            UlName = txt_lname.Text,
                            UEmail = txt_email.Text,
                            UPassword = txt_pass.Text,
                            UAge = int.Parse(txt_age.Text),
                            UBudget = double.Parse(txt_budget.Text, NumberStyles.Currency),
                            role = "user"
                        };
                        users.Add(User);
                        MessageBox.Show("User is Registered Successfully","Success",MessageBoxButtons.OK);
                        AppDbContext.SaveChanges();
                        this.Hide();
                        Login login = new Login();
                        login.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("This User Already Exists.");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter A Correct Email ");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Value In All Fields.","Error",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
