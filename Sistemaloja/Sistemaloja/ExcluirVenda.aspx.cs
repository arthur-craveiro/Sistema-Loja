using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class ExcluirVenda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int idVenda = int.Parse(Request.QueryString["idVenda"].ToString());
            DAL.DALItemVenda dalitensvenda = new DAL.DALItemVenda();
            dalitensvenda.DeleteIdVenda(idVenda);
            DAL.DALVenda dalVenda = new DAL.DALVenda();
            Modelo.Venda venda = dalVenda.SelectVendas(idVenda)[0];
            venda.valorTotal = 0;
            dalVenda.Delete(venda.idVenda);
            Response.Redirect("./Vendas.aspx");
        }
    }
}