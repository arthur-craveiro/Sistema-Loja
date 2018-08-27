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
                        (double)dr["salario"],
                        (bool)dr["motorista"],
                        (bool)dr["tecnico"],
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
                        (double)dr["salario"],
                        (bool)dr["motorista"],
                        (bool)dr["tecnico"],
                        dr["observacao"].ToString());
                        listFun.Add(funcionario);
                }
            }
            dr.Close();
            conn.Close();
            return listFun; 
        }
    }
}