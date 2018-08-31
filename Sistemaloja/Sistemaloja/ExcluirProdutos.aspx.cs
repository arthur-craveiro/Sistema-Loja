using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class ExcluirProdutos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALProdutos SelectProdutos = new DAL.DALProdutos();
            List<Modelo.Produtos> Produtos = SelectProdutos.SelectProdutos(int.Parse(Request.QueryString["idProduto"]));
            Label3.Text = Produtos[0].codigo ;
            Label4.Text = Produtos[0].descricao ;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALProdutos DelectProdutos = new DAL.DALProdutos();
            List<Modelo.Produtos> Produtos = DelectProdutos.SelectProdutos(int.Parse(Request.QueryString["idProduto"]));
            DelectProdutos.Delete(Produtos[0].idProduto);
            Response.Redirect("./Produtos.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Produtos.aspx");
        }
    }
}