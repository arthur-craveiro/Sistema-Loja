using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistemaloja.DAL
{
    public class DALItemCompra
    {
        private string connectionString;

        public DALItemCompra()
        {
            connectionString = ConfigurationManager.ConnectionStrings
            ["aspnetdbConnectionString"].ConnectionString;
        }

         [DataObjectMethod(DataObjectMethodType.Select)]
         public List<Modelo.ItensCompra> SelectAll()
         {
             Modelo.ItensCompra aItensCompra;
             List<Modelo.ItensCompra> aListItensCompra = new List<Modelo.ItensCompra>();
             SqlConnection conn = new SqlConnection(connectionString);
             conn.Open();
             SqlCommand cmd = conn.CreateCommand();
             cmd.CommandText = "Select * from itensCompra";
             SqlDataReader dr = cmd.ExecuteReader();
             if (dr.HasRows)
             {
                 while (dr.Read()) 
                 {
                     aItensCompra = new Modelo.ItensCompra(
                         (int)dr["idItem"],
                         (string)dr["unidade"],
                         (int)dr["quantidade"],
                         (double)dr["precoUnitario"],
                         (double)dr["precoTotal"],
                         (int)dr["idCompra"],
                         (int)dr["idProduto"]
                         );
                     aListItensCompra.Add(aItensCompra);
                 }
             }
             dr.Close();
             conn.Close();
             return aListItensCompra;
         }

         [DataObjectMethod(DataObjectMethodType.Select)]
         public List<Modelo.ItensCompra> SelectItemCompra(int id)
         {
             Modelo.ItensCompra aItensCompra;
             List<Modelo.ItensCompra> aListItensCompra = new List<Modelo.ItensCompra>();
             SqlConnection conn = new SqlConnection(connectionString);
             conn.Open();
             SqlCommand cmd = conn.CreateCommand();
             cmd.CommandText = "select * from itensCompra where idItem = @id";
             cmd.Parameters.AddWithValue("@id", id);
             SqlDataReader dr = cmd.ExecuteReader();
             if (dr.HasRows)
             {
                 while (dr.Read())
                 {
                     aItensCompra = new Modelo.ItensCompra(
                         (int)dr["idItem"],
                         (string)dr["unidade"],
                         (int)dr["quantidade"],
                         (double)dr["precoUnitario"],
                         (double)dr["precoTotal"],
                         (int)dr["idCompra"],
                         (int)dr["idProduto"]
                         );
                     aListItensCompra.Add(aItensCompra);
                 }
             }
             dr.Close();
             conn.Close();
             return aListItensCompra;
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
             SqlCommand cmd = new SqlCommand("DELETE FROM itensCompra WHERE idItem = @id", conn);
             cmd.Parameters.AddWithValue("@id", id);

             // Executa Comando
             cmd.ExecuteNonQuery();
         }

         public void InserirItensCompra(Modelo.ItensCompra itensCompra)
         {
             // Cria Conexão com banco de dados
             SqlConnection conn = new SqlConnection(connectionString);
             // Abre conexão com o banco de dados
             conn.Open();
             // Cria comando SQL
             SqlCommand com = conn.CreateCommand();
             // Define comando de exclusão
             SqlCommand cmd = new SqlCommand("insert into itensCompra(unidade, quantidade, precoUnitario, precoTotal, idCompra, idProduto) values (@unidade, @quantidade, @precoUnitario, @precoTotal, @idCompra, @idProduto)", conn);
             cmd.Parameters.AddWithValue("@unidade", itensCompra.unidade);
             cmd.Parameters.AddWithValue("@quantidade", itensCompra.quantidade);
             cmd.Parameters.AddWithValue("@precoUnitario", itensCompra.precoUnitario);
             cmd.Parameters.AddWithValue("@precoTotal", itensCompra.precoTotal);
             cmd.Parameters.AddWithValue("@idCompra", itensCompra.idCompra);
             cmd.Parameters.AddWithValue("@idProduto", itensCompra.idProduto);
             // Executa Comando
             cmd.ExecuteNonQuery();
         }

         public void AtualizarCompras(Modelo.ItensCompra itensCompra)
         {
             // Cria Conexão com banco de dados
             SqlConnection conn = new SqlConnection(connectionString);
             // Abre conexão com o banco de dados
             conn.Open();
             // Cria comando SQL
             SqlCommand com = conn.CreateCommand();
             // Define comando de exclusão
             SqlCommand cmd = new SqlCommand("update itensCompra set unidade = @unidade, quantidade = @quantidade, precoUnitario = @precoUnitario, precoTotal = @precoTotal, idCompra = @idCompra, idProduto = @idProduto where idItem = @id", conn);
             cmd.Parameters.AddWithValue("@unidade", itensCompra.unidade);
             cmd.Parameters.AddWithValue("@quantidade", itensCompra.quantidade);
             cmd.Parameters.AddWithValue("@precoUnitario", itensCompra.precoUnitario);
             cmd.Parameters.AddWithValue("@precoTotal", itensCompra.precoTotal);
             cmd.Parameters.AddWithValue("@idCompra", itensCompra.idCompra);
             cmd.Parameters.AddWithValue("@idProduto", itensCompra.idProduto);
             cmd.Parameters.AddWithValue("@idItem", itensCompra.idItem);
             // Executa Comando
             cmd.ExecuteNonQuery();
         }
    }
}