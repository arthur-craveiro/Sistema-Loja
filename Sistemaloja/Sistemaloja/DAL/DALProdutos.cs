using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistemaloja.DAL
{
    public class DALProdutos
    {
           private string connectionString;

           public DALProdutos()
        {
            connectionString = ConfigurationManager.ConnectionStrings
            ["aspnetdbConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Produtos> SelectAll()
        {
            // Variavel para armazenar um livro
            Modelo.Produtos aProdutos;
            // Cria Lista Vazia
            List<Modelo.Produtos> aListProdutos = new List<Modelo.Produtos>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "select * from Produtos";
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    aProdutos = new Modelo.Produtos(
                       (int)dr["idProduto"],
                        dr["codigo"].ToString(),
                        dr["descricao"].ToString()
                       );
                    // Adiciona o livro lido à lista
                    aListProdutos.Add(aProdutos);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListProdutos;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Produtos> SelectProdutos(int id)
        {
            // Variavel para armazenar um livro
            Modelo.Produtos aProdutos;
            // Cria Lista Vazia
            List<Modelo.Produtos> aListProdutos = new List<Modelo.Produtos>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "select idProduto, codigo,descricao from Produtos where idProduto = @id";
            cmd.Parameters.AddWithValue("@id", id);
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    aProdutos = new Modelo.Produtos(
                       (int)dr["idProduto"],
                        dr["codigo"].ToString(),
                        dr["descricao"].ToString()
                       );
                    // Adiciona o livro lido à lista
                    aListProdutos.Add(aProdutos);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListProdutos;
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
            SqlCommand cmd = new SqlCommand("DELETE FROM Produtos WHERE idProduto = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            // Executa Comando
            cmd.ExecuteNonQuery();
        }

        public void InserirProdutos(Modelo.Produtos Produtos)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("insert into Produtos(codigo,descricao) values (@codigo,@descricao)", conn);
            cmd.Parameters.AddWithValue("@codigo", Produtos.codigo);
            cmd.Parameters.AddWithValue("@descricao", Produtos.descricao);
            cmd.ExecuteNonQuery();
        }

        public void AtualizarProdutos(Modelo.Produtos Produtos)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("update Produtos set  codigo = @codigo, descricao = @descricao where idProduto = @id", conn);
            cmd.Parameters.AddWithValue("@id", Produtos.idProduto);
            cmd.Parameters.AddWithValue("@codigo", Produtos.codigo);
            cmd.Parameters.AddWithValue("@descricao", Produtos.descricao);
            // Executa Comando
            cmd.ExecuteNonQuery();
        }
    }
}