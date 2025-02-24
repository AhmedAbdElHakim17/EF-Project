using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project
{
    public partial class Statistics : Form
    {
        int id;
        ApplicationDBContext ApplicationDBContext;
        public Statistics(int id)
        {
            InitializeComponent();
            ApplicationDBContext = new ApplicationDBContext();
            this.id = id;
            dgv.RowHeadersVisible = true;

        }

        private void btn_exp1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Expenses expenses = new Expenses(id);
            expenses.ShowDialog();
        }

        private void btn_Exp_Click(object sender, EventArgs e)
        {
            var expenses = ApplicationDBContext.Expenses.Where(u => u.UserId == id)
                                                        .GroupBy(e => e.ExpName)
                                                        .Select(e => new
                                                        {
                                                            ExpenseName = e.Key,
                                                            ExpenseTotalPrice = e.Sum(e => e.ExpPrice),
                                                            CategoryName = e.FirstOrDefault().Category.CatName,
                                                        })
                                                        .OrderByDescending(e => e.ExpenseTotalPrice)
                                                        .ToList();
            dgv.DataSource = expenses;
        }

        private void btn_Cat_Click(object sender, EventArgs e)
        {
            var expenses = ApplicationDBContext.Expenses.Where(u => u.UserId == id)
                                                        .GroupBy(e => e.Category.CatName)
                                                        .Select(e => new
                                                        {
                                                            CategoryName = e.Key,
                                                            CategoryTotalSpending = e.Sum(e => e.ExpPrice),
                                                        })
                                                        .OrderByDescending(e => e.CategoryTotalSpending)
                                                        .ToList();
            dgv.DataSource = expenses;
        }

        private void btn_return1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeUser homeUser = new HomeUser(id);
            homeUser.ShowDialog();

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void btn_stats1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }

    }
}
