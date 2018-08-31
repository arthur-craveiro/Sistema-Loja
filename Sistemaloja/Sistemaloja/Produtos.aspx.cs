using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class Produtos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALProdutos SelectProdutos = new DAL.DALProdutos();
            List<Modelo.Produtos> Produto = SelectProdutos.SelectAll();
            foreach (Modelo.Produtos Produtos in Produto)
            {
                TableRow row = new TableRow();
                TableCell cell2 = new TableCell();
                cell2.Text = Produtos.idProduto.ToString();
                row.Cells.Add(cell2);
                cell2.Visible = false;
                cell2 = new TableCell();
                cell2.Text = Produtos.codigo.ToString();
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                cell2.Text = Produtos.descricao.ToString();
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                HyperLink hl = new HyperLink();
                hl.CssClass = "Botao3 botao3";
                hl.NavigateUrl = "./AlterarProdutos.aspx?idProduto=" + Produtos.idProduto.ToString();
                hl.Text = "Editar";
                cell2.Controls.Add(hl);
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                hl = new HyperLink();
                hl.CssClass = "Botao6 botao6";
                hl.NavigateUrl = "./ExcluirProdutos.aspx?idProduto=" + Produtos.idProduto.ToString();
                hl.Text = "Excluir";
                cell2.Controls.Add(hl);
                row.Cells.Add(cell2);
                Table1.Rows.Add(row);
            }
        }
    }
}