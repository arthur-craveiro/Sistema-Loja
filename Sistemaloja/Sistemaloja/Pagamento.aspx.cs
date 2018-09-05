using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DAL.DALFuncionario SelectFuncionario = new DAL.DALFuncionario();
                List<Modelo.Funcionario> funcionarios = SelectFuncionario.SelectAll();
                foreach (Modelo.Funcionario funcionario in funcionarios)
                {
                    DropDownList1.Items.Add(new ListItem(funcionario.nome, funcionario.idFuncionario.ToString()));
                }
                DAL.DALPagamento SelectPagamento = new DAL.DALPagamento();
                List<Modelo.Pagamento> pagamentos = SelectPagamento.SelectPagamento(int.Parse(DropDownList1.SelectedValue));
                int contador = 0;
                foreach (Modelo.Pagamento pagamento in pagamentos)
                {
                    if (contador == 0)
                    {
                        DropDownList2.Items.Add(new ListItem(pagamento.mesReferencia.ToString() + "/" + pagamento.anoReferencia.ToString(), pagamento.mesReferencia.ToString() + "/" + pagamento.anoReferencia.ToString()));
                    }
                    else {
                        if (DropDownList2.Items.Contains(DropDownList2.Items.FindByText(pagamento.mesReferencia.ToString() + "/" + pagamento.anoReferencia.ToString())))
                        {
                            DropDownList2.Items.Add(new ListItem(pagamento.mesReferencia.ToString() + "/" + pagamento.anoReferencia.ToString(), pagamento.mesReferencia.ToString() + "/" + pagamento.anoReferencia.ToString()));
                            DropDownList2.Items.RemoveAt(DropDownList2.Items.Count - 1);
                        }
                        else {
                            DropDownList2.Items.Add(new ListItem(pagamento.mesReferencia.ToString() + "/" + pagamento.anoReferencia.ToString(), pagamento.mesReferencia.ToString() + "/" + pagamento.anoReferencia.ToString()));
                        }
                    }
                    contador = contador + 1;
                }
                List<Modelo.Funcionario> funcionarios1 = SelectFuncionario.Select(int.Parse(DropDownList1.SelectedValue));
                Label4.Text = funcionarios1[0].salario.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double valorpago = 0;
            int mes = Convert.ToInt32(Convert.ToString((DropDownList2.SelectedValue[0])));
            int ano = Convert.ToInt32(Convert.ToString((DropDownList2.SelectedValue[2])) + Convert.ToString((DropDownList2.SelectedValue[3])) + Convert.ToString((DropDownList2.SelectedValue[4])) + Convert.ToString((DropDownList2.SelectedValue[5]))); 
            DAL.DALPagamento SelectPagamento = new DAL.DALPagamento();
            List<Modelo.Pagamento> pagamentos = SelectPagamento.SelectPagamentoMes(mes, ano, int.Parse(DropDownList1.SelectedValue));
            foreach (Modelo.Pagamento pagamento in pagamentos) {
                TableRow row = new TableRow();
                TableCell cell2 = new TableCell();
                cell2.Text = pagamento.dataDePagamento.ToString();
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                cell2.Text = pagamento.mesReferencia + "/" + pagamento.anoReferencia;
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                cell2.Text = pagamento.valorPago.ToString();
                row.Cells.Add(cell2);  
                HyperLink hl = new HyperLink();
                hl.CssClass = "Botao3 botao3";
                hl.NavigateUrl = "./AlterarPagamento.aspx?idPagamento=" + pagamento.idPagamento.ToString();
                hl.Text = "Editar";
                cell2.Controls.Add(hl);
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                hl = new HyperLink();
                hl.CssClass = "Botao6 botao6";
                hl.NavigateUrl = "./ExcluirPagamento.aspx?idPagamento=" + pagamento.idPagamento.ToString();
                hl.Text = "Excluir";
                cell2.Controls.Add(hl);
                row.Cells.Add(cell2);
                Table1.Rows.Add(row);
                valorpago = valorpago + pagamento.valorPago;
            }
            Label6.Text = valorpago.ToString();
            Label8.Text = (double.Parse(Label4.Text) - valorpago).ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label6.Text = "";
            Label8.Text = "";
            DropDownList2.Items.Clear();
            DAL.DALPagamento SelectPagamento = new DAL.DALPagamento();
            List<Modelo.Pagamento> pagamentos = SelectPagamento.SelectPagamento(int.Parse(DropDownList1.SelectedValue));
            int contador = 0;
            foreach (Modelo.Pagamento pagamento in pagamentos)
            {
                if (contador == 0)
                {
                    DropDownList2.Items.Add(new ListItem(pagamento.mesReferencia.ToString() + "/" + pagamento.anoReferencia.ToString(), pagamento.mesReferencia.ToString() + "/" + pagamento.anoReferencia.ToString()));
                }
                else
                {
                    if (DropDownList2.Items.Contains(DropDownList2.Items.FindByText(pagamento.mesReferencia.ToString() + "/" + pagamento.anoReferencia.ToString())))
                    {
                        DropDownList2.Items.Add(new ListItem(pagamento.mesReferencia.ToString() + "/" + pagamento.anoReferencia.ToString(), pagamento.mesReferencia.ToString() + "/" + pagamento.anoReferencia.ToString()));
                        DropDownList2.Items.RemoveAt(DropDownList2.Items.Count - 1);
                    }
                    else
                    {
                        DropDownList2.Items.Add(new ListItem(pagamento.mesReferencia.ToString() + "/" + pagamento.anoReferencia.ToString(), pagamento.mesReferencia.ToString() + "/" + pagamento.anoReferencia.ToString()));
                    }
                }
                contador = contador + 1;
            }
            DAL.DALFuncionario SelectFuncionario = new DAL.DALFuncionario();
            List<Modelo.Funcionario> funcionarios1 = SelectFuncionario.Select(int.Parse(DropDownList1.SelectedValue));
            Label4.Text = funcionarios1[0].salario.ToString();
        }
    }
}