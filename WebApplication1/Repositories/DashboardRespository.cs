using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using WebApplication1.Utilities;
using WebApplication1.ViewModels;

namespace WebApplication1.Repositories
{
    public class DashboardRespository
    {
        private IConfiguration _configuration;
        public DashboardRespository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<DashboardViewModel> Obter()
        {
            var ret = new List<DashboardViewModel>();

            var date = Convert.ToDateTime("2021-04-12T00:00:00"); //DateTime.Today;
            var query = "SELECT C.Nome, C.Local, A.Horario, A.Status, S.Nome" +
                        " FROM Agenda AS A " +
                        " INNER JOIN Cliente AS C ON A.ClienteIdCliente = C.IdCliente" +
                        " INNER JOIN Suporte AS S ON A.SuporteIdCliente = S.IdSuporte" +
                        " WHERE A.Data >= '" + date.ToString("yyy-MM-dd") + "'" + 
                        " AND A.Data < '" + date.AddDays(1).ToString("yyy-MM-dd") + "'";

            var conexaoSql = new ConexaoSql(_configuration);
            var reader = conexaoSql.Consult(query);

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

            return ret;
        }
    }
}
