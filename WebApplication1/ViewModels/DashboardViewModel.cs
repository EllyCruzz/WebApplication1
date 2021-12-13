using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WebApplication1.Models;
using WebApplication1.ViewModels;

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
        //public AgendaModel Status { get; set; }

        //   [Display(Name = "Checkout")]
        //    [Column("Status")]

        // public int StatusSaida
        //public IConfiguration Configuration { get; }
        public List<DashboardViewModel> RecuperarLista()
        {

            var ret = new List<DashboardViewModel>();

            using (var conexao = new SqlConnection())
            {

                
                conexao.ConnectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    DateTime date = Convert.ToDateTime("2021-12-07"); //DateTime.Today;
                    comando.CommandText = "SELECT C.Nome, C.Local, A.Horario, A.Status, S.Nome" +
                " FROM Agenda AS A " +
                " INNER JOIN Cliente AS C ON A.ClienteIdCliente = C.IdCliente" +
                " INNER JOIN Suporte AS S ON A.SuporteIdCliente = S.IdSuporte" +
                " WHERE A.Data >=" + date + " AND A.Data < " + date.AddDays(1);
                    var reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        ret.Add(new DashboardViewModel
                        {
                            Horario = (string)reader["Horario"],
                            IdCliente = (int)reader["ClienteIdCliente"],
                            IdSuporte = (int)reader["SuporteIdCliente"],
                            Local = (string)reader["Local"],
                            Status = (int)reader["Status"]

                    });
                    }
                }
            }

            return ret;
        }

    }
}