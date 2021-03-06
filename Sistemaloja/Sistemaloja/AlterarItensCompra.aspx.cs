﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class AlterarItensCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALItemCompra dalitem = new DAL.DALItemCompra();
            List<Modelo.ItensCompra> listItens = new List<Modelo.ItensCompra>();
            if (Request.QueryString["idCompra"] != null)
            {
                int idCompra = int.Parse(Request.QueryString["idCompra"].ToString());
                listItens = dalitem.SelectIdCompra(idCompra);
                TableRow tr1;
                TableCell tc0, tc1, tc2, tc3, tc4;
                for (int i = 0; i < listItens.Count; i++)
                {
                    Label l1 = new Label();
                    DAL.DALProdutos dalprod = new DAL.DALProdutos();
                    Modelo.Produtos produto = dalprod.SelectProdutos(listItens[i].idProduto)[0];
                    l1.Text = produto.descricao;
                    l1.Font.Name = "Segoe UI Light";
                    l1.Font.Size = 16;
                    l1.Font.Bold = true;
                    tc0 = new TableCell();
                    tc0.Controls.Add(l1);
                    tc0.Width = 230;

                    Label l2 = new Label();
                    l2.Text = listItens[i].unidade;
                    l2.Font.Name = "Segoe UI Light";
                    l2.Font.Size = 16;
                    l2.Font.Bold = true;
                    tc1 = new TableCell();
                    tc1.Controls.Add(l2);
                    tc1.Width = 200;

                    Label l3 = new Label();
                    l3.Text = listItens[i].quantidade.ToString();
                    l3.Font.Name = "Segoe UI Light";
                    l3.Font.Size = 16;
                    l3.Font.Bold = true;
                    tc2 = new TableCell();
                    tc2.Controls.Add(l3);
                    tc2.Width = 200;

                    Label l4 = new Label();
                    l4.Text = "&nbsp; &nbsp; &nbsp;&nbsp; &nbsp;" + listItens[i].precoUnitario.ToString();
                    l4.Font.Name = "Segoe UI Light";
                    l4.Font.Size = 16;
                    l4.Font.Bold = true;
                    tc3 = new TableCell();
                    tc3.Controls.Add(l4);
                    tc3.Width = 220;

                    Label l5 = new Label();
                    l5.Text = "&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;" + listItens[i].precoTotal.ToString();
                    l5.Font.Name = "Segoe UI Light";
                    l5.Font.Size = 16;
                    l5.Font.Bold = true;
                    tc4 = new TableCell();
                    tc4.Controls.Add(l5);
                    tc4.Width = 400;

                    tr1 = new TableRow();
                    tr1.Cells.Add(tc0);
                    tr1.Cells.Add(tc1);
                    tr1.Cells.Add(tc2);
                    tr1.Cells.Add(tc3);
                    tr1.Cells.Add(tc4);
                    Table3.Rows.Add(tr1);
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int idCompra = int.Parse(Request.QueryString["idCompra"].ToString());
            Response.Redirect("./InserirItensCompras.aspx?idCompra=" + idCompra);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int idCompra = int.Parse(Request.QueryString["idCompra"].ToString());
            DAL.DALItemCompra dalitenscompra = new DAL.DALItemCompra();
            dalitenscompra.DeleteIdCompra(idCompra);
            DAL.DALCompras dalCompra = new DAL.DALCompras();
            Modelo.Compra compra = dalCompra.SelectCompras(idCompra)[0];
            compra.valorTotal = 0;
            dalCompra.AtualizarCompras(compra);
            Response.Redirect("./Compras.aspx");
        }
    }
}