using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class InserirItensCompras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALItemCompra dalitem = new DAL.DALItemCompra();
            double precoTotal = (int.Parse(TextBox2.Text) * double.Parse(TextBox3.Text));
            int idCompra = int.Parse(Request.QueryString["idCompra"].ToString());
            Modelo.ItensCompra itemCompra = new Modelo.ItensCompra(TextBox1.Text, int.Parse(TextBox2.Text), double.Parse(TextBox3.Text), precoTotal, idCompra,int.Parse(DropDownList1.SelectedValue));
            dalitem.InserirItensCompra(itemCompra);
            DAL.DALCompras dalcompra = new DAL.DALCompras();
            Modelo.Compra compra = dalcompra.SelectCompras(idCompra)[0];
            compra.valorTotal = compra.valorTotal + precoTotal;
            dalcompra.AtualizarCompras(compra);
            Response.Redirect("./InserirCompras.aspx?idCompra=" + idCompra);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int idCompra = int.Parse(Request.QueryString["idCompra"].ToString());
            Response.Redirect("./InserirCompras.aspx?idCompra=" + idCompra);
        }
    }
}