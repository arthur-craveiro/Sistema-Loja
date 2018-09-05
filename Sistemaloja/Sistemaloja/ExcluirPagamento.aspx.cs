using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALPagamento SelectPagamento = new DAL.DALPagamento();
            List<Modelo.Pagamento> pagamentos = SelectPagamento.SelectPagamentoAll(int.Parse(Request.QueryString["idPagamento"]));
            Label2.Text = pagamentos[0].idPagamento.ToString();
            Label4.Text = pagamentos[0].funcionario.nome;
            Label6.Text = pagamentos[0].dataDePagamento.ToString();
            Label8.Text = pagamentos[0].mesReferencia + "/" + pagamentos[0].anoReferencia;
            Label10.Text = pagamentos[0].valorPago.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALPagamento Delete = new DAL.DALPagamento();
            List<Modelo.Pagamento> Pagamento = Delete.SelectPagamentoAll(int.Parse(Request.QueryString["idPagamento"]));
            Delete.Delete(Pagamento[0].idPagamento);
            Response.Redirect("./Pagamento.aspx");
        }

    }
}