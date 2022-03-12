using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer_Support.Entity
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Marca")]
        public string Brand_Name { get; set; }
        public Nullable<DateTime> CreateDate { get; set; }
        public Nullable<DateTime> UpdateDate { get; set; }

        public ICollection<Server> Servers { get; set; }
    }
}
