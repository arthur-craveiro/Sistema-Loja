using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                for (int i = 1; i <= 12; i++)
                {
                    DropDownList1.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }

                for (int i = 2000; i <= 2018; i++)
                {
                    DropDownList2.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }
                DAL.DALFuncionario SelectFuncionario = new DAL.DALFuncionario();
                List<Modelo.Funcionario> funcionarios = SelectFuncionario.SelectAll();
                foreach (Modelo.Funcionario funcionario in funcionarios)
                {
                    DropDownList3.Items.Add(new ListItem(funcionario.nome, funcionario.idFuncionario.ToString()));
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Modelo.Pagamento pagamento = new Modelo.Pagamento(double.Parse(TextBox1.Text),Calendar1.SelectedDate,int.Parse(DropDownList1.SelectedValue),int.Parse(DropDownList2.SelectedValue),int.Parse(DropDownList3.SelectedValue));
            DAL.DALPagamento InsertPagamento = new DAL.DALPagamento();
            InsertPagamento.InserirPagamento( pagamento);
            Response.Redirect("Pagamento.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagamento.aspx");
        }
    }
}