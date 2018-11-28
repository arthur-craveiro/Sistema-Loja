using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class AlterarVenda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DAL.DALItemVenda dalitem = new DAL.DALItemVenda();
                List<Modelo.ItensVenda> listItens = new List<Modelo.ItensVenda>();
                if (Request.QueryString["idVenda"] != null)
                {
                    DAL.DALVenda dalvenda = new DAL.DALVenda();
                    Modelo.Venda venda = dalvenda.SelectVendas(int.Parse(Request.QueryString["idVenda"]))[0];
                    TextBox3.Text = venda.desconto.ToString();
                    Label6.Text = venda.valorTotal.ToString();
                    Calendar1.SelectedDate = venda.datas;
                    int idVenda = int.Parse(Request.QueryString["idVenda"].ToString());
                    listItens = dalitem.SelectIdVenda(idVenda);
                    TableRow tr1;
                    TableCell tc0, tc1, tc2, tc3;
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
                        l2.Text = listItens[i].peso.ToString();
                        l2.Font.Name = "Segoe UI Light";
                        l2.Font.Size = 16;
                        l2.Font.Bold = true;
                        tc1 = new TableCell();
                        tc1.Controls.Add(l2);
                        tc1.Width = 200;

                        Label l3 = new Label();
                        l3.Text = listItens[i].precokg.ToString();
                        l3.Font.Name = "Segoe UI Light";
                        l3.Font.Size = 16;
                        l3.Font.Bold = true;
                        tc2 = new TableCell();
                        tc2.Controls.Add(l3);
                        tc2.Width = 200;

                        Label l4 = new Label();
                        l4.Text = "&nbsp; &nbsp; &nbsp;&nbsp; &nbsp;" + listItens[i].valorTotal.ToString();
                        l4.Font.Name = "Segoe UI Light";
                        l4.Font.Size = 16;
                        l4.Font.Bold = true;
                        tc3 = new TableCell();
                        tc3.Controls.Add(l4);
                        tc3.Width = 220;

                        tr1 = new TableRow();
                        tr1.Cells.Add(tc0);
                        tr1.Cells.Add(tc1);
                        tr1.Cells.Add(tc2);
                        tr1.Cells.Add(tc3);
                        Table1.Rows.Add(tr1);
                    }
                }
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int idVenda = int.Parse(Request.QueryString["idVenda"].ToString());
            Response.Redirect("./InserirItensVenda.aspx?idVenda=" + idVenda);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int idVenda = int.Parse(Request.QueryString["idVenda"].ToString());
            DAL.DALItemVenda dalitensvenda = new DAL.DALItemVenda();
            dalitensvenda.DeleteIdVenda(idVenda);
            DAL.DALVenda dalVenda = new DAL.DALVenda();
            Modelo.Venda venda = dalVenda.SelectVendas(idVenda)[0];
            venda.valorTotal = 0;
            dalVenda.AtualizarVendas(venda);
            Response.Redirect("./InserirVendas.aspx?idVenda=" + idVenda);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALVenda dalVenda = new DAL.DALVenda();
            Modelo.Venda venda = new Modelo.Venda(int.Parse(Request.QueryString["idVenda"]), Convert.ToDateTime(Calendar1.SelectedDate), double.Parse(TextBox3.Text), double.Parse(Label6.Text), int.Parse(DropDownList1.SelectedValue));
            dalVenda.AtualizarVendas(venda);
            Response.Redirect("./Vendas.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Compras.aspx");
        }
    }
}