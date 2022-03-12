using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer_Support.Entity
{
    public class SO
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Sistema Operativo")]
        public string Server_So { get; set; }

        [Required]
        [Display(Name = "Fabricante")]
        public string Develop { get; set; }

        [Required]
        [Display(Name = "Url")]
        [DataType(DataType.Url)]
        public string SO_Url { get; set; }

        
        [Display(Name = "Fecha de publicacion")]
        [DataType(DataType.Date)]
        public Nullable<DateTime> SO_Date { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        [DataType(DataType.MultilineText)]
        public string SO_Desc { get; set; }


        public Nullable<DateTime> CreateDate { get; set; }
        public Nullable<DateTime> UpdateDate { get; set; }

        public ICollection<Server> Servers { get; set; }
    }
}
