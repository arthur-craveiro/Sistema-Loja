using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALCliente SelectCliente = new DAL.DALCliente();
            List<Modelo.Cliente> clientes = SelectCliente.SelectCliente(int.Parse(Request.QueryString["idCliente"]));
            Label8.Text = clientes[0].nome;
            Label9.Text = clientes[0].telefones;
            Label10.Text = clientes[0].cidade;
            Label11.Text = clientes[0].endereco;
            Label12.Text = clientes[0].CPF;
            Label13.Text = clientes[0].CNPJ;
            Label14.Text = clientes[0].estado.ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALCliente DelectCliente = new DAL.DALCliente();
            List<Modelo.Cliente> clientes = DelectCliente.SelectCliente(int.Parse(Request.QueryString["idCliente"]));
            DelectCliente.Delete(clientes[0].idCliente);
            Response.Redirect("./Cliente.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Cliente.aspx");
        }
    }
}