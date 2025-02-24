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
using Microsoft.Identity.Client;

namespace EF_Project
{
    public partial class HomeUser : Form
    {
        int Id;
        ApplicationDBContext ADBC;
        User User;
        public HomeUser(int id)
        {
            ADBC = new ApplicationDBContext();
            InitializeComponent();
            User = new User();
            this.Id = id;
        }

        private void btn_exp_Click(object sender, EventArgs e)
        {
            if (ADBC.Users.Find(Id).UBudget > 0)
            {
                this.Hide();
                Expenses expenses = new Expenses(Id);
                expenses.ShowDialog();
            }
            else
            {
                MessageBox.Show("You haven't Set your budget yet, Please Enter Your Budget");
            }
        }

        private void HomeUser_Load(object sender, EventArgs e)
        {
            if (ADBC.Users.Find(Id).UBudget == 0)
            {
                txt_bud.Visible = true;
                btn_save.Visible = true;
            }
            else
            {
                txt_bud.Visible = false;
                btn_save.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(txt_bud.Text, out double budget))
            {
                ADBC.Users.Find(Id).UBudget = budget;
                MessageBox.Show("Budget is Saved Successfully");
                ADBC.SaveChanges();
                HomeUser_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please enter a valid budget amount.");
            }
        }
        private void btn_stats1_Click(object sender, EventArgs e)
        {
            if (ADBC.Users.Find(Id).UBudget > 0)
            {
                this.Hide();
                Statistics statistics = new Statistics(Id);
                statistics.ShowDialog();
            }
            else
            {
                MessageBox.Show("You haven't Set your budget yet, Please Enter Your Budget");
            }
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
