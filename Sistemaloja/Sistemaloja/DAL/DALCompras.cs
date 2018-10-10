﻿using System;
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
         public List<Modelo.Compra> SelectAll()
         {
             // Variavel para armazenar um livro
             Modelo.Compra aCompras;
             // Cria Lista Vazia
             List<Modelo.Compra> aListCompras = new List<Modelo.Compra>();
             // Cria Conexão com banco de dados
             SqlConnection conn = new SqlConnection(connectionString);
             // Abre conexão com o banco de dados
             conn.Open();
             // Cria comando SQL
             SqlCommand cmd = conn.CreateCommand();
             // define SQL do comando
             cmd.CommandText = "Select * from Compra";
             // Executa comando, gerando objeto DbDataReader
             SqlDataReader dr = cmd.ExecuteReader();
             // Le titulo do livro do resultado e apresenta no segundo rótulo
             if (dr.HasRows)
             {

                 while (dr.Read()) // Le o proximo registro
                 {
                     // Cria objeto com dados lidos do banco de dados
                     aCompras = new Modelo.Compra(
                         (int)dr["idCompra"],
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
         public List<Modelo.Compra> SelectCompras(int id)
         {
             // Variavel para armazenar um livro
             Modelo.Compra aCompras;
             // Cria Lista Vazia
             List<Modelo.Compra> aListCompras = new List<Modelo.Compra>();
             // Cria Conexão com banco de dados
             SqlConnection conn = new SqlConnection(connectionString);
             // Abre conexão com o banco de dados
             conn.Open();
             // Cria comando SQL
             SqlCommand cmd = conn.CreateCommand();
             // define SQL do comando
             cmd.CommandText = "select * from Compra where idCompra = @id";
             cmd.Parameters.AddWithValue("@id", id);
             // Executa comando, gerando objeto DbDataReader
             SqlDataReader dr = cmd.ExecuteReader();
             // Le titulo do livro do resultado e apresenta no segundo rótulo
             if (dr.HasRows)
             {

                 while (dr.Read()) // Le o proximo registro
                 {
                     // Cria objeto com dados lidos do banco de dados
                     aCompras = new Modelo.Compra(
                         (int)dr["idCompra"],
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
             SqlCommand cmd = new SqlCommand("DELETE FROM Compra WHERE idCompra = @id", conn);
             cmd.Parameters.AddWithValue("@id", id);

             // Executa Comando
             cmd.ExecuteNonQuery();
         }

         public void InserirCompras(Modelo.Compra Compra)
         {
             // Cria Conexão com banco de dados
             SqlConnection conn = new SqlConnection(connectionString);
             // Abre conexão com o banco de dados
             conn.Open();
             // Cria comando SQL
             SqlCommand com = conn.CreateCommand();
             // Define comando de exclusão
             SqlCommand cmd = new SqlCommand("insert into Compra(datas, desconto, valorTotal, idFornecedores) values (@datas, @desconto, @idFornecedores)", conn);
             cmd.Parameters.AddWithValue("@datas", Compra.datas);
             cmd.Parameters.AddWithValue("@desconto", Compra.desconto);
             cmd.Parameters.AddWithValue("@valorTotal", Compra.valorTotal);
             cmd.Parameters.AddWithValue("@idFornecedores", Compra.idFornecedores);
             // Executa Comando
             cmd.ExecuteNonQuery();
         }

         public void AtualizarCompras(Modelo.Compra Compra)
         {
             // Cria Conexão com banco de dados
             SqlConnection conn = new SqlConnection(connectionString);
             // Abre conexão com o banco de dados
             conn.Open();
             // Cria comando SQL
             SqlCommand com = conn.CreateCommand();
             // Define comando de exclusão
             SqlCommand cmd = new SqlCommand("update Compra set datas = @datas, desconto = @desconto, valorTotal = @valorTotal, idFornecedores = @idFornecedores where idCompra = @id", conn);
             cmd.Parameters.AddWithValue("@datas", Compra.datas);
             cmd.Parameters.AddWithValue("@desconto", Compra.desconto);
             cmd.Parameters.AddWithValue("@valorTotal", Compra.valorTotal);
             cmd.Parameters.AddWithValue("@idFornecedores", Compra.idFornecedores);
             // Executa Comando
             cmd.ExecuteNonQuery();
         }
    }
}