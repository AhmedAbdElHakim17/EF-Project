using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Suite;

namespace EF_Project
{
    public partial class Users : Form
    {
        int id;
        User User;
        ApplicationDBContext AppDbContext;
        public Users(int id)
        {
            InitializeComponent();
            AppDbContext = new ApplicationDBContext();
            User = new User();
            this.id = id;
        }

        private void btn_add_Click(object sender, EventArgs e)
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
                    role = "user"
                };
                users.Add(User);
                MessageBox.Show("User is added Successfully");
                AppDbContext.SaveChanges();
                Users_Load(sender, e);
            }
            else
            {
                MessageBox.Show("This User Already Exists.");
            }
        }

        private void btn_upd_Click(object sender, EventArgs e)
        {
            User = AppDbContext.Users.Find(selectedId);
            User.UfName = txt_fname.Text;
            User.UlName = txt_lname.Text;
            User.UPassword = txt_pass.Text;
            AppDbContext.SaveChanges();
            Users_Load(sender, e);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            User = AppDbContext.Users.Find(selectedId);
            AppDbContext.Remove(User);
            AppDbContext.SaveChanges();
            Users_Load(sender, e);
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home(id);
            home.ShowDialog();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            txt_email.Enabled = true;
            dgv.DataSource = AppDbContext.Users.Where(u => u.role == "user")
                                               .Select(u => new
                                               {
                                                   ID = u.UId,
                                                   FullName = u.UfName + " " + u.UlName,
                                                   Password = u.UPassword,
                                                   Email = u.UEmail,
                                                   Age = u.UAge,
                                               }).ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var user = AppDbContext.Users.Find(id);
            user.role = "admin";
            MessageBox.Show($"{User.UfName + " " + User.UlName} Is Now Admin");
            Users_Load(sender, e);
        }
        int selectedId = 0;
        DataGridViewRow row = new DataGridViewRow();
        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }
            row = dgv.SelectedRows[0];
            selectedId = (int)row.Cells[0].Value;
            txt_fname.Text = row.Cells[1].Value?.ToString().Split(" ")[0];
            txt_lname.Text = row.Cells[1].Value?.ToString().Split(" ")[1];
            txt_pass.Text = row.Cells[2].Value?.ToString();
            txt_age.Text = row.Cells[4].Value.ToString();
            txt_email.Enabled = false;
        }
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            row.Selected = false;
            txt_email.Enabled = true;
        }

        private void btn_cat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Categories categories = new Categories(id);
            categories.ShowDialog();
        }

        private void btn_exp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Expenses expenses = new Expenses(id);
            expenses.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
