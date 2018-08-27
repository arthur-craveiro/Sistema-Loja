using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistemaloja.DAL
{
    public class DALCliente
    {
        private string connectionString;

        public DALCliente()
        {
            connectionString = ConfigurationManager.ConnectionStrings
            ["aspnetdbConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Cliente> SelectAll()
        {
            // Variavel para armazenar um livro
            Modelo.Cliente aCliente;
            // Cria Lista Vazia
            List<Modelo.Cliente> aListCliente = new List<Modelo.Cliente>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "select idCliente, nome, telefones, cidade, endereco, CPF, CNPJ, idestado from Cliente";
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    aCliente = new Modelo.Cliente(
                        (int)dr["idCliente"],
                        dr["nome"].ToString(),
                        dr["telefones"].ToString(),
                        dr["cidade"].ToString(),
                        dr["endereco"].ToString(),
                        dr["CPF"].ToString(),
                        dr["CNPJ"].ToString(),
                        (int)dr["idestado"]
                        );
                    // Adiciona o livro lido à lista
                    aListCliente.Add(aCliente);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListCliente;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Cliente> SelectCliente(int id)
        {
            // Variavel para armazenar um livro
            Modelo.Cliente aCliente;
            // Cria Lista Vazia
            List<Modelo.Cliente> aListCliente = new List<Modelo.Cliente>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "select idCliente, nome, telefones, cidade, endereco, CPF, CNPJ, idestado from Cliente where idCliente = @id";
            cmd.Parameters.AddWithValue("@id", id);
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {

                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    aCliente = new Modelo.Cliente(
                        (int)dr["idCliente"],
                        dr["nome"].ToString(),
                        dr["telefones"].ToString(),
                        dr["cidade"].ToString(),
                        dr["endereco"].ToString(),
                        dr["CPF"].ToString(),
                        dr["CNPJ"].ToString(),
                        (int)dr["idestado"]
                        );
                    // Adiciona o livro lido à lista
                    aListCliente.Add(aCliente);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListCliente;
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
            SqlCommand cmd = new SqlCommand("DELETE FROM Cliente WHERE idCliente = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            // Executa Comando
            cmd.ExecuteNonQuery();
        }

        public void InserirCliente(Modelo.Cliente cliente)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("insert into Cliente(nome,telefones,cidade,endereco,CPF,CNPJ,idestado) values (@nome, @telefones, @cidade, @endereco, @CPF, @CNPJ, @idestado)", conn);
            cmd.Parameters.AddWithValue("@nome",cliente.nome);
            cmd.Parameters.AddWithValue("@telefones", cliente.telefones);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
            cmd.Parameters.AddWithValue("@CNPJ", cliente.CNPJ);
            cmd.Parameters.AddWithValue("@idestado", cliente.uf.id);
            // Executa Comando
            cmd.ExecuteNonQuery();
        }

        public void AtualizarCliente(Modelo.Cliente cliente)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("update Cliente set nome = @nome, telefones = @telefones, cidade = @cidade, endereco = @endereco, CPF = @CPF, CNPJ = @CNPJ, idestado = @idestado where idCliente = @id", conn);
            cmd.Parameters.AddWithValue("@id", cliente.idCliente);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@telefones", cliente.telefones);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
            cmd.Parameters.AddWithValue("@CNPJ", cliente.CNPJ);
            cmd.Parameters.AddWithValue("@idestado", cliente.uf.id);
            // Executa Comando
            cmd.ExecuteNonQuery();
        }


    }
}