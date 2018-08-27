using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistemaloja.DAL
{
    public class DALUF
    {
        private string connectionString;

        public DALUF()
        {
            connectionString = ConfigurationManager.ConnectionStrings
            ["aspnetdbConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.UF> SelectAll()
        {
            // Variavel para armazenar um livro
            Modelo.UF aUF;
            // Cria Lista Vazia
            List<Modelo.UF> aListUF = new List<Modelo.UF>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from UF";
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    aUF = new Modelo.UF(
                        dr["sigla"].ToString()
                        );
                    // Adiciona o livro lido à lista
                    aListUF.Add(aUF);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListUF;
        }


    }
}