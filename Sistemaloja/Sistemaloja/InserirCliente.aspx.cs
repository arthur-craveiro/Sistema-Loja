﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALUF SelectUF = new DAL.DALUF();
            List<Modelo.UF> ufs = SelectUF.SelectAll();
            foreach (Modelo.UF uf in ufs) {
                DropDownList1.Items.Add(new ListItem(uf.sigla, uf.id.ToString()));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALCliente insertCliente = new DAL.DALCliente();
            Modelo.Cliente cliente = new Modelo.Cliente(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, int.Parse(DropDownList1.SelectedItem.Value),TextBox7.Text);
            insertCliente.InserirCliente(cliente);
            Response.Redirect("./cliente.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./cliente.aspx");
        }
    }
}