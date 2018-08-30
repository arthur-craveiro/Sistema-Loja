using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class AlterarFornecedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DAL.DALUF SelectUF = new DAL.DALUF();
                List<Modelo.UF> ufs = SelectUF.SelectAll();
                foreach (Modelo.UF uf in ufs)
                {
                    DropDownList1.Items.Add(new ListItem(uf.sigla, uf.id.ToString()));
                }
                DAL.DALFornecedores SelectFornecedores = new DAL.DALFornecedores();
                List<Modelo.Fornecedores> Fornecedores = SelectFornecedores.SelectFornecedores(int.Parse(Request.QueryString["idFornecedores"]));
                TextBox1.Text = Fornecedores[0].nome;
                TextBox2.Text = Fornecedores[0].telefones;
                TextBox3.Text = Fornecedores[0].cidade;
                TextBox4.Text = Fornecedores[0].endereco;
                TextBox5.Text = Fornecedores[0].CPF;
                TextBox6.Text = Fornecedores[0].CNPJ;
                DropDownList1.SelectedValue = Fornecedores[0].uf.id.ToString();
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALFornecedores AtualizarFornecedores = new DAL.DALFornecedores();
            List<Modelo.Fornecedores> Fornecedores = AtualizarFornecedores.SelectFornecedores(int.Parse(Request.QueryString["idFornecedores"]));
            Fornecedores[0].nome = TextBox1.Text;
            Fornecedores[0].telefones = TextBox2.Text;
            Fornecedores[0].cidade = TextBox3.Text;
            Fornecedores[0].endereco = TextBox4.Text;
            Fornecedores[0].CPF = TextBox5.Text;
            Fornecedores[0].CNPJ = TextBox6.Text;
            Fornecedores[0].uf.id = int.Parse(DropDownList1.SelectedValue);
            AtualizarFornecedores.AtualizarFornecedores(Fornecedores[0]);
            Response.Redirect("./Fornecedores.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Fornecedores.aspx");
        }
    }
}