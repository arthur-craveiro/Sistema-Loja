using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class WebForm3 : System.Web.UI.Page
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
                DAL.DALCliente SelectCliente = new DAL.DALCliente();
                List<Modelo.Cliente> clientes = SelectCliente.SelectCliente(int.Parse(Request.QueryString["idCliente"]));
                TextBox1.Text = clientes[0].nome;
                TextBox2.Text = clientes[0].telefones;
                TextBox3.Text = clientes[0].cidade;
                TextBox4.Text = clientes[0].endereco;
                TextBox5.Text = clientes[0].CPF;
                TextBox7.Text = clientes[0].Email;
                TextBox6.Text = clientes[0].CNPJ;
                DropDownList1.SelectedValue = clientes[0].uf.id.ToString();
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALCliente AtualizarCliente = new DAL.DALCliente();
            List<Modelo.Cliente> clientes = AtualizarCliente.SelectCliente(int.Parse(Request.QueryString["idCliente"]));
            clientes[0].nome = TextBox1.Text;
            clientes[0].telefones = TextBox2.Text;
            clientes[0].cidade = TextBox3.Text;
            clientes[0].endereco = TextBox4.Text;
            clientes[0].CPF = TextBox5.Text;
            clientes[0].CNPJ = TextBox6.Text;
            clientes[0].Email = TextBox7.Text;
            clientes[0].uf.id = int.Parse(DropDownList1.SelectedValue);
            AtualizarCliente.AtualizarCliente(clientes[0]);
            Response.Redirect("./Cliente.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Cliente.aspx");
        }
    }
}