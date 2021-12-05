using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;



namespace WebApplication1.Models
{
    [Table("Agenda")]
    public class AgendaModel
    {
        // tabela agenda
        [Required]

        [Key]
        [Display(Name = "IdAgenda")]
        [Column("IdAgenda")]
        public int IdAgenda { get; set; }

        [ForeignKey("IdCliente")]
        [Display(Name = "Cliente")]
        [Column("IdCliente")]
        public int IdCliente { get; set; }

        public ClienteModel Cliente { get; set; }

        [ForeignKey("IdSuporte")]
        [Display(Name = "IdSuporte")]
        [Column("IdSuporte")]
        public int IdSuporte { get; set; }

        public ClienteModel Suporte { get; set; }

        [Display(Name = "Horario")]
        [Column("Horario")]
        public string Horario { get; set; }

        [Display(Name = "Status")]
        [Column("Status")]
        public int Status { get; set; }

    }
}