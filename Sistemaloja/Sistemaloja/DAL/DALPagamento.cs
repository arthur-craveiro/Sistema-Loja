using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistemaloja.DAL
{
    public class DALPagamento
    {
        private string connectionString;

        public DALPagamento()
        {
            connectionString = ConfigurationManager.ConnectionStrings
            ["aspnetdbConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Pagamento> SelectAll()
        {
            Modelo.Pagamento aPagamento;
            List<Modelo.Pagamento> aListPagamento = new List<Modelo.Pagamento>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Pagamento";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read()) 
                {
                    aPagamento = new Modelo.Pagamento(
                        (int)dr["idPagamento"],
                        (double)dr["valorPago"],
                        (DateTime)dr["dataDePagamento"],
                        (int)dr["mesReferencia"],
                        (int)dr["anoReferencia"],
                        (int)dr["idFuncionario"]
                        );
                    aListPagamento.Add(aPagamento);
                }
            }
                dr.Close();
                conn.Close();
                return aListPagamento;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Pagamento> SelectPagamento(int idFuncionario)
        {
            Modelo.Pagamento aPagamento;
            List<Modelo.Pagamento> aListPagamento = new List<Modelo.Pagamento>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Pagamento where idFuncionario = @idFuncionario";
            cmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aPagamento = new Modelo.Pagamento(
                        (int)dr["idPagamento"],
                        Convert.ToDouble(dr["valorPago"]),
                        (DateTime)dr["dataDePagamento"],
                        (int)dr["mesReferencia"],
                        (int)dr["anoReferencia"],
                        (int)dr["idFuncionario"]
                        );
                    aListPagamento.Add(aPagamento);
                }
            }
            dr.Close();
            conn.Close();
            return aListPagamento;
        }

        public List<Modelo.Pagamento> SelectPagamentoMes(int MesReferencia, int AnoReferencia, int idFuncionario)
        {
            Modelo.Pagamento aPagamento;
            List<Modelo.Pagamento> aListPagamento = new List<Modelo.Pagamento>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Pagamento where mesReferencia = @mesReferencia and anoReferencia = @anoReferencia and idFuncionario = @idFuncionario";
            cmd.Parameters.AddWithValue("@mesReferencia", MesReferencia);
            cmd.Parameters.AddWithValue("@anoReferencia", AnoReferencia);
            cmd.Parameters.AddWithValue("@idFuncionario", idFuncionario);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aPagamento = new Modelo.Pagamento(
                        (int)dr["idPagamento"],
                        Convert.ToDouble(dr["valorPago"]),
                        (DateTime)dr["dataDePagamento"],
                        (int)dr["mesReferencia"],
                        (int)dr["anoReferencia"],
                        (int)dr["idFuncionario"]
                        );
                    aListPagamento.Add(aPagamento);
                }
            }
            dr.Close();
            conn.Close();
            return aListPagamento;
        }
    }
}