using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALCliente SelectCliente = new DAL.DALCliente();
            List<Modelo.Cliente> clientes = SelectCliente.SelectAll();
            foreach (Modelo.Cliente cliente in clientes) {
                TableRow row = new TableRow();
                TableCell cell2 = new TableCell();
                cell2.Text = cliente.idCliente.ToString();
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                cell2.Text = cliente.nome.ToString();
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                cell2.Text = cliente.telefones.ToString();
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                cell2.Text = cliente.cidade.ToString();
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                cell2.Text = cliente.endereco.ToString();
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                cell2.Text = cliente.CPF.ToString();
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                cell2.Text = cliente.CNPJ.ToString();
                row.Cells.Add(cell2);
                cell2 = new TableCell();
                cell2.Text = cliente.estado.ToString();
                row.Cells.Add(cell2);

                Table1.Rows.Add(row);
            }
        }
    }
}