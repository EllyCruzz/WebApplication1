using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int IdCliente { get; set; }

        public ClienteModel Cliente { get; set; }

        [ForeignKey("IdSuporte")]
        [Display(Name = "IdSuporte")]
        [Column("IdSuporte")]
        public int IdSuporte { get; set; }

        public SuporteModel Nome { get; set; }

        [Display(Name = "Local")]
        [Column("Local")]
        public string Local { get; set; }

        [Display(Name = "Checkin")]
        [Column("Status")]
        public int Status { get; set; }

        // public AgendaModel Status { get; set; }

        // [Display(Name = "Checkout")]
        // [Column("Status")]
        // public int StatusSaida
    }
}