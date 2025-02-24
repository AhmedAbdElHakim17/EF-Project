using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Timer = System.Windows.Forms.Timer;

namespace EF_Project
{
    public partial class Expenses : Form
    {
        int id;
        double bud = 0;
        double budget = 0;
        int selectedId = 0;
        Expense expense;
        Category Category;
        DataGridViewRow row;
        ApplicationDBContext AppDBContext;
        Timer timer = new System.Windows.Forms.Timer();
        public Expenses(int id)
        {
            InitializeComponent();
            AppDBContext = new ApplicationDBContext();
            expense = new Expense();
            Category = new Category();
            row = new DataGridViewRow();
            this.id = id;
            budget = AppDBContext.Users.Where(e => e.UId == id).Select(e => e.UBudget).FirstOrDefault();
            bud = budget - AppDBContext.Expenses.Where(e => e.UserId == id).Sum(e => e.ExpPrice);
            budRem.Text = bud.ToString();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            dgv1.RowHeadersVisible = true;
        }
        private void Expenses_Load(object sender, EventArgs e)
        {
            timer.Start();
            if (AppDBContext.Users.Where(u => u.UId == id).Select(u => u.role).FirstOrDefault() == "admin")
            {
                txt_name1.Visible = false;
                txt_price1.Visible = false;
                cb_cat.Visible = false;
                btn_add.Visible = false;
                btn_del.Visible = false;
                btn_upd.Visible = false;
                dateTimePicker1.Visible = false;
                lab_rem.Visible = false;
                budRem.Visible = false;
                btn_stats1.Visible = false;

                var cats = AppDBContext.Categories.Select(c => c.CatName).Distinct().ToList();
                cats.Insert(0, "Select Category...");
                cb_cats.DataSource = cats;

                var expenses = AppDBContext.Expenses.Select(c => c.ExpName).Distinct().ToList();
                expenses.Insert(0, "Select Expense...");
                cb_ename.DataSource = expenses;
                cb_ename.SelectedIndex = 0;

                var users = AppDBContext.Users.Where(c => c.role == "user")
                                              .Select(c => new { FullName = c.UfName + " " + c.UlName }).Distinct().ToList();
                users.Insert(0, new { FullName = "Select User..." });
                cb_Uname.DataSource = users;
                cb_Uname.SelectedIndex = 0;
                cb_Uname.DataSource = users;
                cb_Uname.DisplayMember = "FullName";
                cb_cats.SelectedIndex = 0;

                RefreshData();

            }
            else
            {

                budRem.Text = bud.ToString();
                var Expenses = AppDBContext.Expenses.Where(u => u.UserId == id)
                                                .Select(e => new
                                                {
                                                    ExpenseName = e.ExpName,
                                                    ExpensePrice = e.ExpPrice,
                                                    ExpenseDate = e.Expdate,
                                                    CategoryName = e.Category.CatName,
                                                })
                                                .OrderBy(e => e.ExpenseDate)
                                                .ThenBy(e => e.CategoryName)
                                                .ToList();
                dgv1.DataSource = Expenses;
                var cats = AppDBContext.Categories.Select(c => c.CatName).ToList();
                cats.Insert(0, "Select Category...");
                cb_cat.DataSource = cats;
                cb_cat.SelectedIndex = 0;
                cb_cats.Visible = false;
                cb_ename.Visible = false;
                cb_Uname.Visible = false;
                dtpfrom.Visible = false;
                dtpto.Visible = false;
                labFrom.Visible = false;
                labTo.Visible = false;
                btn_cat.Visible = false;
                btn_users.Visible = false;
            }

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            if (AppDBContext.Users.Where(u => u.UId == id).Select(u => u.role).FirstOrDefault() == "admin")
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
        private void btn_add_Click(object sender, EventArgs e)
        {
            var exp = AppDBContext.Expenses;
            if (!exp.Any(e => e.ExpName == txt_name1.Text && e.Expdate == dateTimePicker1.Value))
            {
                var expense1 = new Expense
                {
                    ExpName = txt_name1.Text,
                    ExpPrice = double.Parse(txt_price1.Text),
                    Expdate = dateTimePicker1.Value,
                    CategoryId = AppDBContext.Categories.Where(c => c.CatName == cb_cat.Text).Select(c => c.CatId).FirstOrDefault(),
                    UserId = AppDBContext.Users.Where(u => u.UId == id).Select(u => u.UId).FirstOrDefault()
                };
                exp.Add(expense1);
                MessageBox.Show("Expense is added Successfully");
                bud -= double.Parse(txt_price1.Text);
                budRem.Text = bud.ToString();
                AppDBContext.SaveChanges();
                Expenses_Load(sender, e);
            }
            else
                MessageBox.Show("This Expense already Exists in this date");
        }

        private void btn_upd_Click(object sender, EventArgs e)
        {
            expense = AppDBContext.Expenses.Include(e => e.Category).FirstOrDefault(e => e.ExpName == txt_name1.Text && e.Expdate == dateTimePicker1.Value);
            if (expense == null)
            {
                MessageBox.Show("Please select an expense first.");
                return;
            }
            expense.ExpName = txt_name1.Text;
            bud -= (double.Parse(txt_price1.Text) - expense.ExpPrice);
            expense.ExpPrice = double.Parse(txt_price1.Text);
            expense.Expdate = dateTimePicker1.Value;
            expense.Category.CatName = cb_cat.Text;
            AppDBContext.SaveChanges();
            Expenses_Load(sender, e);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            expense = AppDBContext.Expenses.FirstOrDefault(e => e.ExpName == txt_name1.Text && e.Expdate == dateTimePicker1.Value);
            if (expense == null)
            {
                MessageBox.Show("Please select an expense first.");
                return;
            }
            AppDBContext.Expenses.Remove(expense);
            bud -= -expense.ExpPrice;
            AppDBContext.SaveChanges();
            Expenses_Load(sender, e);
        }
        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }
            row = dgv1.SelectedRows[0];
            txt_name1.Text = row.Cells["ExpenseName"].Value.ToString();
            txt_price1.Text = row.Cells["ExpensePrice"].Value.ToString();
            dateTimePicker1.Value = (DateTime)row.Cells["ExpenseDate"].Value;
            cb_cat.Text = row.Cells["CategoryName"].Value.ToString();
        }
        private void cb_Uname_SelectedIndexChanged(object sender, EventArgs e)
            {
            var count = AppDBContext.Expenses.Where(e => e.User.UfName + " " + e.User.UlName == cb_Uname.Text).ToList().Count();
            if (cb_Uname.SelectedIndex > 0 && count > 0)
            {
                var exp = AppDBContext.Expenses.Where(c => c.User.UfName + " " + c.User.UlName == cb_Uname.Text)
                                                           .Select(e => e.ExpName)
                                                           .Distinct()
                                                           .ToList();
                exp.Insert(0, "Select Expense...");
                cb_ename.DataSource = exp;
                cb_ename.SelectedIndex = 0;

                var cat = AppDBContext.Expenses.Where(e => e.User.UfName + " " + e.User.UlName == cb_Uname.Text)
                                                          .Select(e => e.Category.CatName)
                                                          .ToList();
                cat.Insert(0, "Select Category...");
                cb_cats.DataSource = cat;
                cb_cats.SelectedIndex = 0;
            }
            else
            {
                var exp = AppDBContext.Expenses.Select(e => e.ExpName)
                                                .Distinct()
                                                .ToList();
                exp.Insert(0, "Select Expense...");
                cb_ename.DataSource = exp;
                cb_ename.SelectedIndex = 0;

                var cat = AppDBContext.Expenses.Select(e => e.Category.CatName)
                                               .Distinct()
                                               .ToList();
                cat.Insert(0, "Select Category...");
                cb_cats.DataSource = cat;
                cb_cats.SelectedIndex = 0;
            }
                RefreshData();
        }

        private void cb_ename_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void cb_cats_SelectedIndexChanged(object sender, EventArgs e)
        {
            var count = AppDBContext.Expenses.Where(e => e.Category.CatName == cb_cats.Text).ToList().Count();
            if (cb_cats.SelectedIndex > 0 && count > 0)
            {
                var exp = AppDBContext.Expenses.Where(c => c.Category.CatName == cb_cats.Text)
                                                           .Select(e => e.ExpName)
                                                           .ToList();
                exp.Insert(0, "Select Expense...");
                cb_ename.DataSource = exp;
                cb_ename.SelectedIndex = 0;
            }
            else if (cb_cats.SelectedIndex == 0 && cb_Uname.SelectedIndex == 0)
            {
                var exp = AppDBContext.Expenses.Select(e => e.ExpName)
                                               .ToList();
                exp.Insert(0, "Select Expense...");
                cb_ename.DataSource = exp;
                cb_ename.SelectedIndex = 0;
                cb_cats.SelectedIndex = 0;
            }

            RefreshData();

        }

        private void dtpfrom_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dtpto_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();

        }

        private void CheckRemaining()
        {
            if (bud >= budget * 0.75)
                budRem.BackColor = Color.Green;
            else if (bud >= budget * 0.5)
                budRem.BackColor = Color.Yellow;
            else if (bud >= budget * 0.25)
            {
                budRem.BackColor = Color.Brown;
                MessageBox.Show("Be Careful With your Remaining");
            }
            else if (bud > 0)
            {
                budRem.BackColor = Color.Red;
                MessageBox.Show("Your Budget is about to End");
            }
            else if (bud == 0)
            {
                budRem.BackColor = Color.Red;
                MessageBox.Show("Your Budget Ended and you are about to exceed it!!");
            }
            else if (bud < 0)
            {
                budRem.BackColor = Color.Red;
                MessageBox.Show("You have exceeded your Budget, you aren't responsible!!");
            }



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

        private void btn_stats1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics statistics = new Statistics(id);
            statistics.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            timer.Stop();
            CheckRemaining();
        }

        private void RefreshData()
        {

            var query = AppDBContext.Expenses.AsQueryable();
            if (cb_Uname.SelectedIndex > 0)
            {
                string selectedUser = cb_Uname.Text;
                query = query.Where(u => u.User.UfName + " " + u.User.UlName == selectedUser);
            }

            if (cb_cats.SelectedIndex > 0)
            {
                string selectedExpense = cb_cats.Text;
                query = query.Where(u => u.Category.CatName == selectedExpense);
            }

            if (cb_ename.SelectedIndex > 0)
            {
                string selectedExpense = cb_ename.Text;
                query = query.Where(u => u.ExpName == selectedExpense);
            }
            if (dtpfrom.Value <= dtpto.Value)
            {
                query = query.Where(u => u.Expdate >= dtpfrom.Value && u.Expdate <= dtpto.Value);
            }
            else
            {
                MessageBox.Show("Invalid date range. 'From' date must be less than or equal to 'To' date.");
                return;
            }
            var Expenses = query.Select(e => new
            {
                UserName = e.User.UfName + " " + e.User.UlName,
                ExpenseName = e.ExpName,
                ExpensePrice = e.ExpPrice,
                ExpenseDate = e.Expdate,
                CategoryName = e.Category.CatName
            })
            .OrderBy(e => e.ExpenseDate)
            .ThenBy(e => e.CategoryName)
            .ThenBy(e => e.UserName)
            .ToList();
            dgv1.DataSource = Expenses;
        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            row.Selected = false;
        }
    }
}
