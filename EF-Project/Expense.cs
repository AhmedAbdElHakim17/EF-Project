using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project
{
    public class Expense
    {
        [Required]
        public string ExpName { get; set; }
        [Required]
        public double ExpPrice { get; set; }
        [Required]
        public DateTime Expdate { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
