using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistemaloja.DAL
{
    public class DALItemVenda
    {
        private string connectionString;

        public DALItemVenda()
        {
            connectionString = ConfigurationManager.ConnectionStrings
            ["aspnetdbConnectionString"].ConnectionString;
        }

         [DataObjectMethod(DataObjectMethodType.Select)]
         public List<Modelo.ItensVenda> SelectAll()
         {
             Modelo.ItensVenda aItensVenda;
             List<Modelo.ItensVenda> aListItensVenda = new List<Modelo.ItensVenda>();
             SqlConnection conn = new SqlConnection(connectionString);
             conn.Open();
             SqlCommand cmd = conn.CreateCommand();
             cmd.CommandText = "Select * from itensVenda";
             SqlDataReader dr = cmd.ExecuteReader();
             if (dr.HasRows)
             {
                 while (dr.Read()) 
                 {
                     aItensVenda = new Modelo.ItensVenda(
                         (int)dr["idItem"],
                         (double)dr["peso"],
                         (double)dr["precokg"],
                         (double)dr["valorTotal"],
                         (int)dr["idVenda"],
                         (int)dr["idProduto"]
                         );
                     aListItensVenda.Add(aItensVenda);
                 }
             }
             dr.Close();
             conn.Close();
             return aListItensVenda;
         }

         [DataObjectMethod(DataObjectMethodType.Select)]
         public List<Modelo.ItensVenda> SelectItemCompra(int id)
         {
             Modelo.ItensVenda aItensVenda;
             List<Modelo.ItensVenda> aListItensVenda = new List<Modelo.ItensVenda>();
             SqlConnection conn = new SqlConnection(connectionString);
             conn.Open();
             SqlCommand cmd = conn.CreateCommand();
             cmd.CommandText = "select * from itensVenda where idItem = @id";
             cmd.Parameters.AddWithValue("@id", id);
             SqlDataReader dr = cmd.ExecuteReader();
             if (dr.HasRows)
             {
                 while (dr.Read())
                 {
                     aItensVenda = new Modelo.ItensVenda(
                         (int)dr["idItem"],
                         (double)dr["peso"],
                         (double)dr["precokg"],
                         (double)dr["valorTotal"],
                         (int)dr["idVenda"],
                         (int)dr["idProduto"]
                         );
                     aListItensVenda.Add(aItensVenda);
                 }
             }
             dr.Close();
             conn.Close();
             return aListItensVenda;
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
             SqlCommand cmd = new SqlCommand("DELETE FROM itensVenda WHERE idItem = @id", conn);
             cmd.Parameters.AddWithValue("@id", id);

             // Executa Comando
             cmd.ExecuteNonQuery();
         }

         public void InserirItensVenda(Modelo.ItensVenda itensVenda)
         {
             // Cria Conexão com banco de dados
             SqlConnection conn = new SqlConnection(connectionString);
             // Abre conexão com o banco de dados
             conn.Open();
             // Cria comando SQL
             SqlCommand com = conn.CreateCommand();
             // Define comando de exclusão
             SqlCommand cmd = new SqlCommand("insert into itensVenda(peso, precokg, valorTotal, idVenda, idProduto) values (@peso, @precokg, @valorTotal, @idVenda, @idProduto)", conn);
             cmd.Parameters.AddWithValue("@peso", itensVenda.peso);
             cmd.Parameters.AddWithValue("@precokg", itensVenda.precokg);
             cmd.Parameters.AddWithValue("@valorTotal", itensVenda.valorTotal);
             cmd.Parameters.AddWithValue("@idVenda", itensVenda.idVenda);
             cmd.Parameters.AddWithValue("@idProduto", itensVenda.idProduto);
             // Executa Comando
             cmd.ExecuteNonQuery();
         }

         public void AtualizarVenda(Modelo.ItensVenda itensVenda)
         {
             // Cria Conexão com banco de dados
             SqlConnection conn = new SqlConnection(connectionString);
             // Abre conexão com o banco de dados
             conn.Open();
             // Cria comando SQL
             SqlCommand com = conn.CreateCommand();
             // Define comando de exclusão
             SqlCommand cmd = new SqlCommand("update itensVenda set peso = @peso, precokg = @precokg, valorTotal = @valorTotal, idVenda = @idVenda, idCompra = @idCompra, idProduto = @idProduto where idItem = @id", conn);
             cmd.Parameters.AddWithValue("@peso", itensVenda.peso);
             cmd.Parameters.AddWithValue("@precokg", itensVenda.precokg);
             cmd.Parameters.AddWithValue("@valorTotal", itensVenda.valorTotal);
             cmd.Parameters.AddWithValue("@idVenda", itensVenda.idVenda);
             cmd.Parameters.AddWithValue("@idProduto", itensVenda.idProduto);
             cmd.Parameters.AddWithValue("@idItem", itensVenda.idItem);
             // Executa Comando
             cmd.ExecuteNonQuery();
         }
    }
}