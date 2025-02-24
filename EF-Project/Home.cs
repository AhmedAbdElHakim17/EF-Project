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
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace EF_Project
{
    public partial class Home : Form
    {

        ApplicationDBContext AppDBContext;
        int id;
        public Home(int id)
        {
            InitializeComponent();
            AppDBContext = new ApplicationDBContext();
            this.id = id;
        }

        private void btn_exp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Expenses expenses = new Expenses(id);
            expenses.ShowDialog();
        }

        private void btn_cat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Categories categories = new Categories(id);
            categories.ShowDialog();
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users users = new Users(id);
            users.ShowDialog();
        }

        private void btn_logout_Click(object? sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

    }
}
