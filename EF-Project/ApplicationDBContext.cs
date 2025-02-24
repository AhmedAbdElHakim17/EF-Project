using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_Project
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-V83I3DU;Initial Catalog=Expense_Tracking;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expense>().HasKey(k => new { k.ExpName, k.Expdate });
            modelBuilder.Entity<Category>().HasKey(k => k.CatId);
            modelBuilder.Entity<User>().HasKey(k => k.UId);
            modelBuilder.Entity<User>().HasIndex(i => i.UEmail).IsUnique();
            modelBuilder.Entity<Roles>().HasNoKey();
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Expense> Expenses { get; set; }

        public DbSet<Roles> Roles { get; set; }
    }
}
