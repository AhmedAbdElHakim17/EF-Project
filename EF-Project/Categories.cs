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
    public partial class Categories : Form
    {
        int id;
        Category Category;
        DataGridViewRow row;
        ApplicationDBContext ApplicationDBContext;
        public Categories(int id)
        {
            InitializeComponent();
            ApplicationDBContext = new ApplicationDBContext();
            Category = new Category();
            row = new DataGridViewRow();
            dgv.RowHeadersVisible = true;
            this.id = id;
            dgv.RowHeadersVisible = true;
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            var Categories = ApplicationDBContext.Categories.Select(c => new
            {
                CategoryId = c.CatId,
                CategoryName = c.CatName
            }).ToList();
            dgv.DataSource = Categories;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home(id);
            home.ShowDialog();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var cat = ApplicationDBContext.Categories;
            if (!cat.Any(c => c.CatName == txt_catName1.Text))
            {
                var category = new Category
                {
                    CatName = txt_catName1.Text
                };
                cat.Add(category);
                ApplicationDBContext.SaveChanges();
                MessageBox.Show("Category added Successfully");
                Categories_Load(sender, e);
            }
            else
            {
                MessageBox.Show("This Category already Exists. Add another one");
            }

        }

        private void btn_upd_Click(object sender, EventArgs e)
        {
            Category = ApplicationDBContext.Categories.Find(Selectedid);
            Category.CatName = txt_catName1.Text;
            ApplicationDBContext.SaveChanges();
            Categories_Load(sender, e);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            var cat = ApplicationDBContext.Categories;
            Category = ApplicationDBContext.Categories.Find(Selectedid);
            ApplicationDBContext.Remove(Category);
            ApplicationDBContext.SaveChanges();
            Categories_Load(sender, e);
        }
        int Selectedid = 0;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = dgv.SelectedRows[0];
            Selectedid = (int)row.Cells[0].Value;
            txt_catName1.Text = row.Cells[1].Value.ToString();
        }

        private void btn_exp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Expenses expenses = new Expenses(id);
            expenses.ShowDialog();
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users users = new Users(id);
            users.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            row.Selected = false;
        }
    }
}
