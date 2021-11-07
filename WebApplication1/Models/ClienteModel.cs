using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;


namespace WebApplication1.Models
{
    [Table("Cliente")]
    public class ClienteModel
    {

        // tabela cliente
        [Required]

        [Key]
        [Display(Name = "IdCliente")]
        [Column("IdCliente")]
        public int IdCliente { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "Endereco")]
        [Column("Endereco")]
        public string Endereco { get; set; }

        [Display(Name = "Local")]
        [Column("Local")]
        public string Local { get; set; }

    }
}