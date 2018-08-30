using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistemaloja.DAL
{
    public class DALFornecedores
    {
         private string connectionString;

         public DALFornecedores()
        {
            connectionString = ConfigurationManager.ConnectionStrings
            ["aspnetdbConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<Modelo.Fornecedores> SelectAll()
        {
            // Variavel para armazenar um livro
            Modelo.Fornecedores aFornecedores;
            // Cria Lista Vazia
            List<Modelo.Fornecedores> aListFornecedores = new List<Modelo.Fornecedores>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Fornecedor";
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    aFornecedores = new Modelo.Fornecedores(
                        (int)dr["idFornecedores"],
                        dr["nome"].ToString(),
                        dr["telefones"].ToString(),
                        dr["cidade"].ToString(),
                        dr["endereco"].ToString(),
                        dr["CPF"].ToString(),
                        dr["CNPJ"].ToString(),
                        (int)dr["idestado"]
                        );
                    // Adiciona o livro lido à lista
                    aListFornecedores.Add(aFornecedores);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListFornecedores;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Fornecedores> SelectFornecedores(int id)
        {
            // Variavel para armazenar um livro
            Modelo.Fornecedores aFornecedores;
            // Cria Lista Vazia
            List<Modelo.Fornecedores> aListFornecedores = new List<Modelo.Fornecedores>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "select idFornecedores, nome, telefones, cidade, endereco, CPF, CNPJ, idestado from Fornecedor where idFornecedores = @id";
            cmd.Parameters.AddWithValue("@id", id);
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    aFornecedores = new Modelo.Fornecedores(
                        (int)dr["idFornecedores"],
                        dr["nome"].ToString(),
                        dr["telefones"].ToString(),
                        dr["cidade"].ToString(),
                        dr["endereco"].ToString(),
                        dr["CPF"].ToString(),
                        dr["CNPJ"].ToString(),
                        (int)dr["idestado"]
                        );
                    // Adiciona o livro lido à lista
                    aListFornecedores.Add(aFornecedores);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListFornecedores;
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
            SqlCommand cmd = new SqlCommand("DELETE FROM Fornecedor WHERE idFornecedores = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            // Executa Comando
            cmd.ExecuteNonQuery();
        }

        public void InserirFornecedores(Modelo.Fornecedores Fornecedores)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("insert into Fornecedor(nome,telefones,cidade,endereco,CPF,CNPJ,idestado) values (@nome, @telefones, @cidade, @endereco, @CPF, @CNPJ, @idestado)", conn);
            cmd.Parameters.AddWithValue("@nome", Fornecedores.nome);
            cmd.Parameters.AddWithValue("@telefones", Fornecedores.telefones);
            cmd.Parameters.AddWithValue("@cidade", Fornecedores.cidade);
            cmd.Parameters.AddWithValue("@endereco", Fornecedores.endereco);
            cmd.Parameters.AddWithValue("@CPF", Fornecedores.CPF);
            cmd.Parameters.AddWithValue("@CNPJ", Fornecedores.CNPJ);
            cmd.Parameters.AddWithValue("@idestado", Fornecedores.uf.id);
            // Executa Comando
            cmd.ExecuteNonQuery();
        }

        public void AtualizarFornecedores(Modelo.Fornecedores Fornecedores)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("update Fornecedor set nome = @nome, telefones = @telefones, cidade = @cidade, endereco = @endereco, CPF = @CPF, CNPJ = @CNPJ, idestado = @idestado where idFornecedores = @id", conn);
            cmd.Parameters.AddWithValue("@id", Fornecedores.idFornecedores);
            cmd.Parameters.AddWithValue("@nome", Fornecedores.nome);
            cmd.Parameters.AddWithValue("@telefones", Fornecedores.telefones);
            cmd.Parameters.AddWithValue("@cidade", Fornecedores.cidade);
            cmd.Parameters.AddWithValue("@endereco", Fornecedores.endereco);
            cmd.Parameters.AddWithValue("@CPF", Fornecedores.CPF);
            cmd.Parameters.AddWithValue("@CNPJ", Fornecedores.CNPJ);
            cmd.Parameters.AddWithValue("@idestado", Fornecedores.uf.id);
            // Executa Comando
            cmd.ExecuteNonQuery();
        }

    }
}