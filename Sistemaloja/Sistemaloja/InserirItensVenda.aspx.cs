using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class InserirItensVenda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALItemVenda dalitem = new DAL.DALItemVenda();
            double valorTotal = (double.Parse(TextBox1.Text) * double.Parse(TextBox2.Text));
            int idVenda = int.Parse(Request.QueryString["idVenda"].ToString());
            Modelo.ItensVenda itemVenda = new Modelo.ItensVenda(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text), valorTotal, idVenda, int.Parse(DropDownList1.SelectedValue));
            dalitem.InserirItensVenda(itemVenda);
            DAL.DALVenda dalvenda = new DAL.DALVenda();
            Modelo.Venda venda = dalvenda.SelectVendas(idVenda)[0];
            venda.valorTotal = venda.valorTotal + valorTotal;
            dalvenda.AtualizarVendas(venda);
            Response.Redirect("./InserirVendas.aspx?idVenda=" + idVenda);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int idVenda = int.Parse(Request.QueryString["idVenda"].ToString());
            Response.Redirect("./InserirVendas.aspx?idVenda=" + idVenda);
        }
    }
}