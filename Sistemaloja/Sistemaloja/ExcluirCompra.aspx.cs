using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class ExcluirCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int idCompra = int.Parse(Request.QueryString["idCompra"].ToString());
            DAL.DALItemCompra dalitenscompra = new DAL.DALItemCompra();
            dalitenscompra.DeleteIdCompra(idCompra);
            DAL.DALCompras dalCompra = new DAL.DALCompras();
            Modelo.Compra compra = dalCompra.SelectCompras(idCompra)[0];
            compra.valorTotal = 0;
            dalCompra.Delete(compra.idCompra);
            Response.Redirect("./Compras.aspx");
        }
    }
}