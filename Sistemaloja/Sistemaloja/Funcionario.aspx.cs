using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class Funcionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALFuncionario SelectFuncionario = new DAL.DALFuncionario();
            List<Modelo.Funcionario> funcionarios = SelectFuncionario.SelectAll();
            foreach (Modelo.Funcionario funcionario in funcionarios)
            {
                TableRow row = new TableRow();
                TableCell cell2 = new TableCell();
                cell2.Text = funcionario.idFuncionario.ToString();
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                cell2.Text = funcionario.nome.ToString();
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                cell2.Text = funcionario.telefones.ToString();
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                cell2.Text = funcionario.identidade.ToString();
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                cell2.Text = funcionario.carteiradetrabalho.ToString();
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                cell2.Text = funcionario.salario.ToString();
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                CheckBox cb = new CheckBox();
                if (funcionario.motorista)
                {
                    cb.Checked = true;
                }
                else
                {
                    cb.Checked = false;
                }
                cell2.Controls.Add(cb);
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                CheckBox cb1 = new CheckBox();
                if (funcionario.tecnico)
                {
                    cb1.Checked = true;
                }
                else
                {
                    cb1.Checked = false;
                }
                cell2.Controls.Add(cb1);
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                cell2.Text = funcionario.observacao.ToString();
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                HyperLink hl = new HyperLink();
                hl.NavigateUrl = "./AlterarFuncionario.aspx?idFuncionario=" + funcionario.idFuncionario.ToString();
                hl.Text = "Editar";
                cell2.Controls.Add(hl);
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                hl = new HyperLink();
                hl.NavigateUrl = "./ExcluirFuncionario.aspx?idFuncionario=" + funcionario.idFuncionario.ToString();
                hl.Text = "Excluir";
                cell2.Controls.Add(hl);
                row.Cells.Add(cell2);
                Table1.Rows.Add(row);
            }
        }
    }
}