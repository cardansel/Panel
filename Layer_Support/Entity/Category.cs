using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer_Support.Entity
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Categoria")]
        public string Category_Name { get; set; }
        [Required]
        [Display(Name = "Descripcion")]
        [DataType(DataType.MultilineText)]
        public string Category_Desc { get; set; }
        public Nullable<DateTime> CreateDate { get; set; }
        public Nullable<DateTime> UpdateDate { get; set; }

        public ICollection<Server> Servers { get; set; }
    }
}
