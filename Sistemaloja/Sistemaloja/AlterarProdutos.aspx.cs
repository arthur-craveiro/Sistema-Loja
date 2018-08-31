using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class AlterarProdutos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DAL.DALProdutos SelectProdutos = new DAL.DALProdutos();
                List<Modelo.Produtos> Produtos = SelectProdutos.SelectProdutos(int.Parse(Request.QueryString["idProduto"]));
                TextBox1.Text = Produtos[0].codigo;
                TextBox2.Text = Produtos[0].descricao;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALProdutos AtualizarProdutos = new DAL.DALProdutos();
            List<Modelo.Produtos> Produtos = AtualizarProdutos.SelectProdutos(int.Parse(Request.QueryString["idProduto"]));

            Produtos[0].codigo = TextBox1.Text;
            Produtos[0].descricao = TextBox2.Text;
            AtualizarProdutos.AtualizarProdutos(Produtos[0]);
            Response.Redirect("./Produtos.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Produtos.aspx");
        }
    }
}