/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistemaloja.DAL
{
    public class DALPagamento
    {
        private string connectionString;

        public DALPagamento()
        {
            connectionString = ConfigurationManager.ConnectionStrings
            ["aspnetdbConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Pagamento> SelectAll()
        {
            // Variavel para armazenar um livro
            Modelo.Pagamento aPagamento;
            // Cria Lista Vazia
            List<Modelo.Pagamento> aListPagamento = new List<Modelo.Pagamento>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Pagamento";
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    aPagamento = new Modelo.Pagamento(
                        (int)dr["idPagamento"],
                        (double)dr["valorPago"],
                        (DateTime)dr["dataDePagamento"],
                        (int)dr["mesReferencia"],
                        (int)dr["anoReferencia"],
                        (DALFuncionario) dr["Funcionario"],
                        (int)dr["idFuncionario"]
                        );
                    // Adiciona o livro lido à lista
                    aListPagamento.Add(aPagamento);
                }
                }
                // Fecha DataReader
                dr.Close();
                // Fecha Conexão
                conn.Close();

                return aListPagamento;
            }


        }
    }
}*/