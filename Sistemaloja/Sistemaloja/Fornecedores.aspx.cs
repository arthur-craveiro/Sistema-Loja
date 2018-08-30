using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class Fornecedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALFornecedores SelectFornecedores = new DAL.DALFornecedores();
            List<Modelo.Fornecedores> Fornecedor = SelectFornecedores.SelectAll();
            foreach (Modelo.Fornecedores Fornecedores in Fornecedor)
            {
                TableRow row = new TableRow();
                TableCell cell2 = new TableCell();
                cell2.Text = Fornecedores.idFornecedores.ToString();
                row.Cells.Add(cell2);
                cell2.Visible = false;
                cell2 = new TableCell();
                cell2.Text = Fornecedores.nome.ToString();
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                cell2.Text = Fornecedores.telefones.ToString();
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                HyperLink hl = new HyperLink();
                hl.CssClass = "Botao3 botao3";
                hl.NavigateUrl = "./AlterarFornecedores.aspx?idFornecedores=" + Fornecedores.idFornecedores.ToString();
                hl.Text = "Editar";
                cell2.Controls.Add(hl);
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                hl = new HyperLink();
                hl.CssClass = "Botao6 botao6";
                hl.NavigateUrl = "./ExcluirFornecedores.aspx?idFornecedores=" + Fornecedores.idFornecedores.ToString();
                hl.Text = "Excluir";
                cell2.Controls.Add(hl);
                row.Cells.Add(cell2);
                Table1.Rows.Add(row);
            }
        }
    }
}