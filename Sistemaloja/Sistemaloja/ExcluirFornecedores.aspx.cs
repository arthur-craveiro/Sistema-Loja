using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class ExcluirFornecedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALFornecedores SelectFornecedores = new DAL.DALFornecedores();
            List<Modelo.Fornecedores> Fornecedores = SelectFornecedores.SelectFornecedores(int.Parse(Request.QueryString["idFornecedores"]));
            Label8.Text = Fornecedores[0].nome;
            Label9.Text = Fornecedores[0].telefones;
            Label10.Text = Fornecedores[0].cidade;
            Label11.Text = Fornecedores[0].endereco;
            Label12.Text = Fornecedores[0].CPF;
            Label13.Text = Fornecedores[0].CNPJ;
            Label14.Text = Fornecedores[0].uf.sigla;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            DAL.DALFornecedores DelectFornecedores = new DAL.DALFornecedores();
            List<Modelo.Fornecedores> Fornecedores = DelectFornecedores.SelectFornecedores(int.Parse(Request.QueryString["idFornecedores"]));
            DelectFornecedores.Delete(Fornecedores[0].idFornecedores);
            Response.Redirect("./Fornecedores.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Fornecedores.aspx");
        }
    }
}