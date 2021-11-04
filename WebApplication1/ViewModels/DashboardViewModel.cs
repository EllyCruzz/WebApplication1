using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace WebApplication1.ViewModels
{

    [Table("Agenda")]
    public class DashboardViewModel
    {
        [Required]

        [Key]
        [Display(Name = "Id")]
        [Column("ID")]
        public int Id { get; set; }

        [Display(Name = "HORÁRIO")]
        [Column("HORARIO")]
        public string Horario { get; set; }

        [Display(Name = "CLIENTE")]
        [Column("CLIENTE")]
        public string Cliente { get; set; }

        [Display(Name = "SUPORTE")]
        [Column("SUPORTE")]
        public string Suporte { get; set; }

        [Display(Name = "LOCAL")]
        [Column("LOCAL")]
        public string Local { get; set; }

        [Display(Name = "CHECK-IN")]
        [Column("CHECKIN")]
        public string Checkin { get; set; }

        [Display(Name = "CHEK-OUT")]
        [Column("CHECKOUT")]
        public string Checkout { get; set; }

        [Display(Name = "DIST. KM")]
        [Column("DISTKM")]

        public string Distanciakm { get; set; }
    }
}