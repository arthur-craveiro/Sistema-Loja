using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class Compras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALCompras dalcompra = new DAL.DALCompras();
            List<Modelo.Compra> listCompra = new List<Modelo.Compra>();
            listCompra = dalcompra.SelectAll();
            TableRow tr1;
            TableCell tc0, tc1, tc2, tc3, tc4, tc5, tc6;
            for (int i = 0; i < listCompra.Count; i++)
            {
                Label l1 = new Label();
                l1.Text = listCompra[i].datas.ToString("dd/MM/yyyy");
                l1.Font.Name = "Segoe UI Light";
                l1.Font.Size = 16;
                l1.Font.Bold = true;
                tc0 = new TableCell();
                tc0.Controls.Add(l1);
                tc0.Width = 150;

                Label l2 = new Label();
                l2.Text = listCompra[i].Fornecedor.nome.ToString();
                l2.Font.Name = "Segoe UI Light";
                l2.Font.Size = 16;
                l2.Font.Bold = true;
                tc1 = new TableCell();
                tc1.Controls.Add(l2);
                tc1.Width = 150;

                Label l3 = new Label();
                l3.Text = listCompra[i].desconto.ToString();
                l3.Font.Name = "Segoe UI Light";
                l3.Font.Size = 16;
                l3.Font.Bold = true;
                tc2 = new TableCell();
                tc2.Controls.Add(l3);
                tc2.Width = 150;

                Label l4 = new Label();
                l4.Text = listCompra[i].valorTotal.ToString();
                l4.Font.Name = "Segoe UI Light";
                l4.Font.Size = 16;
                l4.Font.Bold = true;
                tc3 = new TableCell();
                tc3.Controls.Add(l4);
                tc3.Width = 170;

                HyperLink l5 = new HyperLink();
                l5.Text = "Visualizar";
                l5.NavigateUrl = "~/AlterarItensCompra.aspx?idCompra=" + listCompra[i].idCompra; 
                l5.Font.Name = "Segoe UI Light";
                l5.Font.Size = 16;
                l5.Font.Bold = true;
                tc4 = new TableCell();
                tc4.Controls.Add(l5);
                tc4.Width = 190;

                HyperLink l6 = new HyperLink();
                l6.Text = "Alterar";
                l6.NavigateUrl = "~/AlterarCompra.aspx?idCompra=" + listCompra[i].idCompra;
                l6.Font.Name = "Segoe UI Light";
                l6.Font.Size = 16;
                l6.Font.Bold = true;
                tc5 = new TableCell();
                tc5.Controls.Add(l6);
                tc5.Width = 150;

                HyperLink l7 = new HyperLink();
                l7.Text = "Excluir";
                l7.NavigateUrl = "~/ExcluirCompra.aspx?idCompra=" + listCompra[i].idCompra;
                l7.Font.Name = "Segoe UI Light";
                l7.Font.Size = 16;
                l7.Font.Bold = true;
                tc6 = new TableCell();
                tc6.Controls.Add(l7);
                tc6.Width = 100;

                tr1 = new TableRow();
                tr1.Cells.Add(tc0);
                tr1.Cells.Add(tc1);
                tr1.Cells.Add(tc2);
                tr1.Cells.Add(tc3);
                tr1.Cells.Add(tc4);
                tr1.Cells.Add(tc5);
                tr1.Cells.Add(tc6);
                Table3.Rows.Add(tr1);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("./InserirCompras.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./TelaInicial.aspx");
        }
    }
}