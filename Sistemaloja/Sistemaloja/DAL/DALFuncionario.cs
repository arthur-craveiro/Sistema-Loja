using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistemaloja.DAL
{
    public class DALFuncionario
    {
        private string connectionString;

        public DALFuncionario()
        {
            connectionString = ConfigurationManager.ConnectionStrings
            ["aspnetdbConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Funcionario> SelectAll()
        {
            // Variavel para armazenar um livro
            Modelo.Funcionario aFuncionario;
            // Cria Lista Vazia
            List<Modelo.Funcionario> aListFuncionario = new List<Modelo.Funcionario>();
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
                    aFuncionario = new Modelo.Funcionario(
                        (int)dr["id"],
                        dr["nome"].ToString(),
                        dr["telefones"].ToString(),
                        dr["identidade"].ToString(),
                        dr["carteiradetrabalho"].ToString(),
                        (double)dr["salario"],
                        (bool)dr["motorista"],
                        (bool)dr["tecnico"],
                        dr["observacao"].ToString()
                        );
                    // Adiciona o livro lido à lista
                    aListFuncionario.Add(aFuncionario);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListFuncionario;
        }


        internal Modelo.Funcionario Select(int aidFuncionario)
        {
            throw new NotImplementedException();
        }
    }
}