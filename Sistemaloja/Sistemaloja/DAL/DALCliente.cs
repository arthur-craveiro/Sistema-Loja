using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistemaloja.DAL
{
    public class DALCliente
    {
        private string connectionString;

        public DALCliente()
        {
            connectionString = ConfigurationManager.ConnectionStrings
            ["aspnetdbConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Cliente> SelectAll()
        {
            // Variavel para armazenar um livro
            Modelo.Cliente aCliente;
            // Cria Lista Vazia
            List<Modelo.Cliente> aListCliente = new List<Modelo.Cliente>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Cliente";
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    aCliente = new Modelo.Cliente(
                        (int)dr["id"],
                        dr["nome"].ToString(),
                        dr["telefones"].ToString(),
                        dr["cidade"].ToString(),
                        dr["endereco"].ToString(),
                        dr["CPF"].ToString(),
                        dr["CNPJ"].ToString(),
                        (int)dr["idUF"]
                        );
                    // Adiciona o livro lido à lista
                    aListCliente.Add(aCliente);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListCliente;
        }


    }
}