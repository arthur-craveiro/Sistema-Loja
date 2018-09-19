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
            Modelo.Funcionario aFuncionario;
            List<Modelo.Funcionario> aListFuncionario = new List<Modelo.Funcionario>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Funcionario";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aFuncionario = new Modelo.Funcionario(
                        (int)dr["idFuncionario"],
                        dr["nome"].ToString(),
                        dr["telefones"].ToString(),
                        dr["identidade"].ToString(),
                        dr["carteiradetrabalho"].ToString(),
                        Convert.ToDouble(dr["salario"]),
                        Convert.ToBoolean(dr["motorista"]),
                        Convert.ToBoolean(dr["tecnico"]),
                        dr["observacao"].ToString()
                        );
                    aListFuncionario.Add(aFuncionario);
                }
            }
            dr.Close();
            conn.Close();
            return aListFuncionario;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Funcionario> Select(int aidFuncionario)
        {
            Modelo.Funcionario funcionario;
            List<Modelo.Funcionario> listFun = new List<Modelo.Funcionario>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Funcionario Where idFuncionario = @idFuncionario";
            cmd.Parameters.AddWithValue("@idFuncionario", aidFuncionario);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read()) 
                {
                    funcionario = new Modelo.Funcionario(
                        Convert.ToInt32(dr["idFuncionario"]),
                        dr["nome"].ToString(),
                        dr["telefones"].ToString(),
                        dr["identidade"].ToString(),
                        dr["carteiradetrabalho"].ToString(),
                         Convert.ToDouble(dr["salario"]),
                        Convert.ToBoolean(dr["motorista"]),
                        Convert.ToBoolean(dr["tecnico"]),
                        dr["observacao"].ToString());
                        listFun.Add(funcionario);
                }
            }
            dr.Close();
            conn.Close();
            return listFun; 
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Funcionario> SelectNome(string nome)
        {
            Modelo.Funcionario funcionario;
            List<Modelo.Funcionario> listFun = new List<Modelo.Funcionario>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Funcionario Where nome = @nome";
            cmd.Parameters.AddWithValue("@nome", nome);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    funcionario = new Modelo.Funcionario(
                        Convert.ToInt32(dr["idFuncionario"]),
                        dr["nome"].ToString(),
                        dr["telefones"].ToString(),
                        dr["identidade"].ToString(),
                        dr["carteiradetrabalho"].ToString(),
                         Convert.ToDouble(dr["salario"]),
                        Convert.ToBoolean(dr["motorista"]),
                        Convert.ToBoolean(dr["tecnico"]),
                        dr["observacao"].ToString());
                    listFun.Add(funcionario);
                }
            }
            dr.Close();
            conn.Close();
            return listFun;
        }
        public void AtualizarFuncionario(Modelo.Funcionario funcionario)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("update Funcionario set nome = @nome, telefones = @telefones, identidade = @identidade, carteiradetrabalho = @carteiradetrabalho, salario = @salario, motorista = @motorista, tecnico = @tecnico, observacao=@observacao where idFuncionario = @id", conn);
            cmd.Parameters.AddWithValue("@id", funcionario.idFuncionario);
            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@telefones", funcionario.telefones);
            cmd.Parameters.AddWithValue("@identidade", funcionario.identidade);
            cmd.Parameters.AddWithValue("@carteiradetrabalho", funcionario.carteiradetrabalho);
            cmd.Parameters.AddWithValue("@salario", funcionario.salario);
            cmd.Parameters.AddWithValue("@motorista", funcionario.motorista);
            cmd.Parameters.AddWithValue("@tecnico", funcionario.tecnico);
            cmd.Parameters.AddWithValue("@observacao", funcionario.observacao);
            // Executa Comando
            cmd.ExecuteNonQuery();
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
            SqlCommand cmd = new SqlCommand("DELETE FROM Funcionario WHERE idFuncionario = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            // Executa Comando
            cmd.ExecuteNonQuery();
        }
        public void InserirFuncionario(Modelo.Funcionario funcionario)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("insert into Funcionario(nome,telefones,identidade,carteiradetrabalho,salario,motorista,tecnico,observacao) values (@nome,@telefones,@identidade,@carteiradetrabalho,@salario,@motorista,@tecnico,@observacao)", conn);
            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@telefones", funcionario.telefones);
            cmd.Parameters.AddWithValue("@identidade", funcionario.identidade);
            cmd.Parameters.AddWithValue("@carteiradetrabalho", funcionario.carteiradetrabalho);
            cmd.Parameters.AddWithValue("@salario", funcionario.salario);
            cmd.Parameters.AddWithValue("@motorista", funcionario.motorista);
            cmd.Parameters.AddWithValue("@tecnico", funcionario.tecnico);
            cmd.Parameters.AddWithValue("@observacao", funcionario.observacao);
            // Executa Comando
            cmd.ExecuteNonQuery();
        }
    }
}