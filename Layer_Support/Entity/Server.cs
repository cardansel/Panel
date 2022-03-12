using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer_Support.Entity
{
    public class Server
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Url del Server")]
        public string Server_Name { get; set; }

        [Required]
        [Display(Name = "Url del Server")]
        [DataType(DataType.Url)]
        public string Server_Url { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        [DataType(DataType.MultilineText)]
        public string Server_Desc { get; set; }

        [Required]
        [Display(Name = "Categoria")]
        public Category Category { get; set; }

        [Required]
        [Display(Name = "Sistema Operativo")]
        public SO SO { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public bool Status { get; set; }

        [Required]
        [Display(Name = "Marca del Equipo")]
        public Brand Brand { get; set; }
        [Required]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }
        public Nullable<DateTime> CreateDate { get; set; }
        public Nullable<DateTime> UpdateDate { get; set; }
    }
}
