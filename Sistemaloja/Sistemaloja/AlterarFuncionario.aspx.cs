using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class AlterarFuncionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DAL.DALFuncionario SelectCliente = new DAL.DALFuncionario ();
                List<Modelo.Funcionario> funcionarios = SelectCliente.Select(int.Parse(Request.QueryString["idFuncionario"]));
                TextBox1.Text = funcionarios[0].nome;
                TextBox2.Text = funcionarios[0].telefones;
                TextBox3.Text = funcionarios[0].identidade;
                TextBox4.Text = funcionarios[0].carteiradetrabalho;
                TextBox5.Text = funcionarios[0].salario.ToString();
                CheckBox1.Checked = true;
                CheckBox2.Checked = true;
                CheckBox1.Checked = funcionarios[0].motorista;
                CheckBox2.Checked = funcionarios[0].tecnico;
                TextBox8.Text = funcionarios[0].observacao;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALFuncionario AtualizarFuncionario = new DAL.DALFuncionario();
            List<Modelo.Funcionario> funcionarios = AtualizarFuncionario.Select(int.Parse(Request.QueryString["idFuncionario"]));
             funcionarios[0].nome = TextBox1.Text;
            funcionarios[0].telefones = TextBox2.Text;
            funcionarios[0].identidade = TextBox3.Text;
           funcionarios[0].carteiradetrabalho = TextBox4.Text;
           funcionarios[0].salario = Convert.ToDouble(TextBox5.Text);
           funcionarios[0].motorista = Convert.ToBoolean(CheckBox1.Checked);
           funcionarios[0].tecnico = Convert.ToBoolean(CheckBox2.Checked);
            funcionarios[0].observacao =TextBox8.Text;
            AtualizarFuncionario.AtualizarFuncionario(funcionarios[0]);
            Response.Redirect("./Funcionario.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Funcionario.aspx");
        }
    }
}