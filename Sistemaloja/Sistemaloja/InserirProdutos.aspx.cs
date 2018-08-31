using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class InserirProdutos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALProdutos insertProdutos = new DAL.DALProdutos();
            Modelo.Produtos Produtos = new Modelo.Produtos(TextBox1.Text, TextBox2.Text);
            insertProdutos.InserirProdutos(Produtos);
            Response.Redirect("./Produtos.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Produtos.aspx");
        }
    }
}