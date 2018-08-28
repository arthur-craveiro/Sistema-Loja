using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class ExcluirFuncionario : System.Web.UI.Page
    {
      protected void Page_Load(object sender, EventArgs e)
        {
            DAL.DALFuncionario SelectFuncionarios= new DAL.DALFuncionario();
            List<Modelo.Funcionario> funcionarios = SelectFuncionarios.Select(int.Parse(Request.QueryString["idFuncionario"]));
                Label8.Text = funcionarios[0].nome;
                Label9.Text = funcionarios[0].telefones;
                 Label10.Text = funcionarios[0].identidade;
                 Label11.Text = funcionarios[0].carteiradetrabalho;
                 Label12.Text = funcionarios[0].salario.ToString();
                CheckBox1.Checked = true;
                CheckBox2.Checked = true;
                CheckBox1.Checked = funcionarios[0].motorista;
                CheckBox2.Checked = funcionarios[0].tecnico;
                 Label13.Text = funcionarios[0].observacao;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALFuncionario DelectFuncionario = new DAL.DALFuncionario();
            List<Modelo.Funcionario> Funcionario = DelectFuncionario.Select(int.Parse(Request.QueryString["idFuncionario"]));
            DelectFuncionario.Delete(Funcionario[0].idFuncionario);
            Response.Redirect("./Funcionario.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Funcionario.aspx");
        }
        }
    }
