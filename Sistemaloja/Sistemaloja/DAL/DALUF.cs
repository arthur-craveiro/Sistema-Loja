using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sistemaloja.DAL
{
    public class DALUF
    {
        private string connectionString;

        public DALUF()
        {
            connectionString = ConfigurationManager.ConnectionStrings
            ["aspnetdbConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.UF> SelectAll()
        {
            Modelo.UF aUF;
            List<Modelo.UF> aListUF = new List<Modelo.UF>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from UF";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read()) 
                {
                    aUF = new Modelo.UF(
                        (int)dr["id"],
                        dr["sigla"].ToString()
                        );
                    aListUF.Add(aUF);
                }
            }
            dr.Close();
            conn.Close();
            return aListUF;
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.UF> Select(int aidEstado)
        {
            Modelo.UF uf;
            List<Modelo.UF> listUF = new List<Modelo.UF>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from UF Where id = @id";
            cmd.Parameters.AddWithValue("@id", aidEstado);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    uf = new Modelo.UF(
                        (int)dr["id"],
                        dr["sigla"].ToString()
                        );
                    listUF.Add(uf);
                }
            }
            dr.Close();
            conn.Close();
            return listUF;
        }

    }
}