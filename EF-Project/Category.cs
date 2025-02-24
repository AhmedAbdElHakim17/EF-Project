using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project
{
    public class Category
    {
        public int CatId { get; set; }
        [Required]
        public string CatName { get; set; }

        public ICollection<Expense>  Expense { get; set; }
    }
}
