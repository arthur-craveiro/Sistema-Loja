using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class AlterarPagamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i = 1; i <= 12; i++)
                {
                    DropDownList1.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }

                for (int i = 2000; i <= 2018; i++)
                {
                    DropDownList2.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }
                DAL.DALFuncionario dalfuncionario = new DAL.DALFuncionario();
                List<Modelo.Funcionario> funcionarios = dalfuncionario.SelectAll();
                foreach (Modelo.Funcionario func in funcionarios)
                {
                    DropDownList3.Items.Add(new ListItem(func.nome, func.idFuncionario.ToString()));
                }
                DAL.DALPagamento dalpagamento = new DAL.DALPagamento();
                Modelo.Pagamento pagamento = dalpagamento.SelectPagamentoAll(int.Parse(Request.QueryString["idPagamento"]))[0];
                TextBox1.Text = Convert.ToString(pagamento.valorPago);
                Calendar1.SelectedDate = pagamento.dataDePagamento;
                DropDownList1.SelectedValue = Convert.ToString(pagamento.mesReferencia);
                DropDownList2.SelectedValue = Convert.ToString(pagamento.anoReferencia);
                DropDownList3.SelectedValue = pagamento.funcionario.nome;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALPagamento dalpagamento = new DAL.DALPagamento();
            Modelo.Pagamento pagamento = dalpagamento.SelectPagamentoAll(int.Parse(Request.QueryString["idPagamento"]))[0];
            pagamento.valorPago = double.Parse(TextBox1.Text);
            pagamento.dataDePagamento = Calendar1.SelectedDate;
            pagamento.mesReferencia = int.Parse(DropDownList1.SelectedValue);
            pagamento.anoReferencia = int.Parse(DropDownList2.SelectedValue);
            DAL.DALFuncionario dalfunc = new DAL.DALFuncionario();
            Modelo.Funcionario func = dalfunc.SelectNome(Convert.ToString(DropDownList3.SelectedItem))[0];
            pagamento.funcionario = func;
            dalpagamento.AtualizarPagamento(pagamento);
            Response.Redirect("./Pagamento.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Pagamento.aspx");
        }
    }
}