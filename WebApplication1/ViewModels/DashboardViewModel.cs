using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{

    [Table("Agenda")]

    public class DashboardViewModel
    {

        [Required]

        [Display(Name = "Horario")]
        [Column("Horario")]
        public string Horario { get; set; }

        [ForeignKey("IdCliente")]
        [Display(Name = "Cliente")]
        [Column("IdCliente")]
        public virtual ClienteModel IdCliente { get; set; }

        [ForeignKey("IdSuporte")]
        [Display(Name = "IdSuporte")]
        [Column("IdSuporte")]


        public virtual ClienteModel IdSuporte { get; set; }

        [Display(Name = "Local")]
        [Column("Local")]
        public virtual ClienteModel Local { get; set; }

        [Display(Name = "Checkin")]
        [Column("Status")]
        public AgendaModel Status { get; set; }

     //   [Display(Name = "Checkout")]
    //    [Column("Status")]

       // public int StatusSaida

    }
}