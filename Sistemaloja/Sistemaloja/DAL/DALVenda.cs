using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistemaloja.DAL
{
    public class DALVenda
    {
        private string connectionString;

        public DALVenda()
        {
            connectionString = ConfigurationManager.ConnectionStrings
            ["aspnetdbConnectionString"].ConnectionString;
        }

         [DataObjectMethod(DataObjectMethodType.Select)]
         public List<Modelo.Venda> SelectAll()
         {
             // Variavel para armazenar um livro
             Modelo.Venda aVendas;
             // Cria Lista Vazia
             List<Modelo.Venda> aListVendas = new List<Modelo.Venda>();
             // Cria Conexão com banco de dados
             SqlConnection conn = new SqlConnection(connectionString);
             // Abre conexão com o banco de dados
             conn.Open();
             // Cria comando SQL
             SqlCommand cmd = conn.CreateCommand();
             // define SQL do comando
             cmd.CommandText = "Select * from Venda";
             // Executa comando, gerando objeto DbDataReader
             SqlDataReader dr = cmd.ExecuteReader();
             // Le titulo do livro do resultado e apresenta no segundo rótulo
             if (dr.HasRows)
             {

                 while (dr.Read()) // Le o proximo registro
                 {
                     // Cria objeto com dados lidos do banco de dados
                     aVendas = new Modelo.Venda(
                         (int)dr["idVenda"],
                         (DateTime)dr["datas"],
                         Convert.ToDouble(dr["desconto"]),
                         Convert.ToDouble(dr["valorTotal"]),
                         (int)dr["idCliente"]
                         );
                     // Adiciona o livro lido à lista
                     aListVendas.Add(aVendas);
                 }
             }
             // Fecha DataReader
             dr.Close();
             // Fecha Conexão
             conn.Close();

             return aListVendas;
         }

         [DataObjectMethod(DataObjectMethodType.Select)]
         public List<Modelo.Venda> SelectVendas(int id)
         {
             // Variavel para armazenar um livro
             Modelo.Venda aVendas;
             // Cria Lista Vazia
             List<Modelo.Venda> aListVendas = new List<Modelo.Venda>();
             // Cria Conexão com banco de dados
             SqlConnection conn = new SqlConnection(connectionString);
             // Abre conexão com o banco de dados
             conn.Open();
             // Cria comando SQL
             SqlCommand cmd = conn.CreateCommand();
             // define SQL do comando
             cmd.CommandText = "select * from Venda where idVenda = @id";
             cmd.Parameters.AddWithValue("@id", id);
             // Executa comando, gerando objeto DbDataReader
             SqlDataReader dr = cmd.ExecuteReader();
             // Le titulo do livro do resultado e apresenta no segundo rótulo
             if (dr.HasRows)
             {

                 while (dr.Read()) // Le o proximo registro
                 {
                     // Cria objeto com dados lidos do banco de dados
                     aVendas = new Modelo.Venda(
                         (int)dr["idVenda"],
                         (DateTime)dr["datas"],
                         Convert.ToDouble(dr["desconto"]),
                         Convert.ToDouble(dr["valorTotal"]),
                         (int)dr["idCliente"]
                         );
                     // Adiciona o livro lido à lista
                     aListVendas.Add(aVendas);
                 }
             }
             // Fecha DataReader
             dr.Close();
             // Fecha Conexão
             conn.Close();

             return aListVendas;
         }

         [DataObjectMethod(DataObjectMethodType.Select)]
         public int ultId()
         {
             Modelo.Venda aVendas;
             List<Modelo.Venda> aListVendas = new List<Modelo.Venda>();
             SqlConnection conn = new SqlConnection(connectionString);
             conn.Open();
             SqlCommand cmd = conn.CreateCommand();
             cmd.CommandText = "select * from Venda";
             SqlDataReader dr = cmd.ExecuteReader();
             int j = 0;
             if (dr.HasRows)
             {

                 while (dr.Read())
                 {
                     aVendas = new Modelo.Venda(
                         (int)dr["idVenda"],
                         (DateTime)dr["datas"],
                         Convert.ToDouble(dr["desconto"]),
                         Convert.ToDouble(dr["valorTotal"]),
                         (int)dr["idCliente"]
                         );
                     aListVendas.Add(aVendas);
                     j++;
                 }
             }
             dr.Close();
             conn.Close();

             return aListVendas[j - 1].idVenda;
         }
         
        [DataObjectMethod(DataObjectMethodType.Delete)]
         public void Delete(int id)
         {
             // Cria Conexão com banco de dados
             SqlConnection conn = new SqlConnection(connectionString);
             // Abre conexão com o banco de dados
             conn.Open();
             // Cria comando SQL
             SqlCommand com = conn.CreateCommand();
             // Define comando de exclusão
             SqlCommand cmd = new SqlCommand("DELETE FROM Venda WHERE idVenda = @id", conn);
             cmd.Parameters.AddWithValue("@id", id);

             // Executa Comando
             cmd.ExecuteNonQuery();
         }

         public void InserirVendas(Modelo.Venda Venda)
         {
             // Cria Conexão com banco de dados
             SqlConnection conn = new SqlConnection(connectionString);
             // Abre conexão com o banco de dados
             conn.Open();
             // Cria comando SQL
             SqlCommand com = conn.CreateCommand();
             // Define comando de exclusão
             SqlCommand cmd = new SqlCommand("insert into Venda(datas, desconto, valorTotal, idCliente) values (@datas, @desconto, @valorTotal, @idCliente)", conn);
             cmd.Parameters.AddWithValue("@datas", Venda.datas);
             cmd.Parameters.AddWithValue("@desconto", Venda.desconto);
             cmd.Parameters.AddWithValue("@valorTotal", Venda.valorTotal);
             cmd.Parameters.AddWithValue("@idCliente", Venda.idCliente);
             // Executa Comando
             cmd.ExecuteNonQuery();
         }

         public void AtualizarVendas(Modelo.Venda Venda)
         {
             // Cria Conexão com banco de dados
             SqlConnection conn = new SqlConnection(connectionString);
             // Abre conexão com o banco de dados
             conn.Open();
             // Cria comando SQL
             SqlCommand com = conn.CreateCommand();
             // Define comando de exclusão
             SqlCommand cmd = new SqlCommand("update Venda set datas = @datas, desconto = @desconto, valorTotal = @valorTotal, idCliente = @idCliente where idVenda = @id", conn);
             cmd.Parameters.AddWithValue("@datas", Venda.datas);
             cmd.Parameters.AddWithValue("@desconto", Venda.desconto);
             cmd.Parameters.AddWithValue("@valorTotal", Venda.valorTotal);
             cmd.Parameters.AddWithValue("@idCliente", Venda.idCliente);
             cmd.Parameters.AddWithValue("@id", Venda.idVenda);
             // Executa Comando
             cmd.ExecuteNonQuery();
         }
    }
}