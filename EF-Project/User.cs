using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_Project
{
    public class User
    {
        public int UId { get; set; }
        [Required]
        public string UfName { get; set; }
        [Required]
        public string UlName { get; set; }
        [Required]
        public string UPassword { get; set; }
        [Required]
        public string UEmail { get; set; }
        public int? UAge { get; set; }
        [Required]
        public double UBudget { get; set; }

        public string role { get; set; }

        public ICollection<Expense> Expenses { get; set; }
    }
}
