using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;


namespace WebApplication1.Models
{
    [Table("Suporte")]
    public class SuporteModel
    {

        // tabela SUporte
        [Required]

        [Key]
        [Display(Name = "IdSuporte")]
        [Column("IdSuporte")]
        public int IdSuporte { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

      
    }
}