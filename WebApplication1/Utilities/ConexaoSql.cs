using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1.Utilities
{
    public class ConexaoSql
    {
        private IConfiguration _configuration;
        private readonly SqlConnection _connection;

        public ConexaoSql(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetConnectionString("default"));
        }

        public SqlDataReader Consult(string query)
        {
            try
            {
                _connection.Open();
                var command = new SqlCommand(query, _connection);
                var reader = command.ExecuteReader();

                return reader;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível realizar a consulta. \n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public int Execute(string query)
        {
            try
            {
                var command = new SqlCommand(query, _connection);
                var affecteds = command.ExecuteNonQuery();
                return affecteds;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível realizar a consulta. \n" + ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
