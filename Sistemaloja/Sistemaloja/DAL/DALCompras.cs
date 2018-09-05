using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistemaloja.DAL
{
    public class DALCompras
    {
        private string connectionString;

         public DALCompras()
        {
            connectionString = ConfigurationManager.ConnectionStrings
            ["aspnetdbConnectionString"].ConnectionString;
        }

         [DataObjectMethod(DataObjectMethodType.Select)]
         public List<Modelo.Compras> SelectAll()
         {
             // Variavel para armazenar um livro
             Modelo.Compras aCompras;
             // Cria Lista Vazia
             List<Modelo.Compras> aListCompras = new List<Modelo.Compras>();
             // Cria Conexão com banco de dados
             SqlConnection conn = new SqlConnection(connectionString);
             // Abre conexão com o banco de dados
             conn.Open();
             // Cria comando SQL
             SqlCommand cmd = conn.CreateCommand();
             // define SQL do comando
             cmd.CommandText = "Select * from Compras";
             // Executa comando, gerando objeto DbDataReader
             SqlDataReader dr = cmd.ExecuteReader();
             // Le titulo do livro do resultado e apresenta no segundo rótulo
             if (dr.HasRows)
             {

                 while (dr.Read()) // Le o proximo registro
                 {
                     // Cria objeto com dados lidos do banco de dados
                     aCompras = new Modelo.Compras(
                         (int)dr["idCompras"],
                         (DateTime)dr["datas"],
                         (double)dr["desconto"],
                         (double)dr["valorTotal"],
                         (int)dr["idFornecedores"]
                         );
                     // Adiciona o livro lido à lista
                     aListCompras.Add(aCompras);
                 }
             }
             // Fecha DataReader
             dr.Close();
             // Fecha Conexão
             conn.Close();

             return aListCompras;
         }

         [DataObjectMethod(DataObjectMethodType.Select)]
         public List<Modelo.Compras> SelectCompras(int id)
         {
             // Variavel para armazenar um livro
             Modelo.Compras aCompras;
             // Cria Lista Vazia
             List<Modelo.Compras> aListCompras = new List<Modelo.Compras>();
             // Cria Conexão com banco de dados
             SqlConnection conn = new SqlConnection(connectionString);
             // Abre conexão com o banco de dados
             conn.Open();
             // Cria comando SQL
             SqlCommand cmd = conn.CreateCommand();
             // define SQL do comando
             cmd.CommandText = "select * from Compras where idCompras = @id";
             cmd.Parameters.AddWithValue("@id", id);
             // Executa comando, gerando objeto DbDataReader
             SqlDataReader dr = cmd.ExecuteReader();
             // Le titulo do livro do resultado e apresenta no segundo rótulo
             if (dr.HasRows)
             {

                 while (dr.Read()) // Le o proximo registro
                 {
                     // Cria objeto com dados lidos do banco de dados
                     aCompras = new Modelo.Compras(
                         (int)dr["idCompras"],
                         (DateTime)dr["datas"],
                         (double)dr["desconto"],
                         (double)dr["valorTotal"],
                         (int)dr["idFornecedores"]
                         );
                     // Adiciona o livro lido à lista
                     aListCompras.Add(aCompras);
                 }
             }
             // Fecha DataReader
             dr.Close();
             // Fecha Conexão
             conn.Close();

             return aListCompras;
         }
    }
}