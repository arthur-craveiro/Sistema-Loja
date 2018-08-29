using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistemaloja
{
    public partial class InserirFuncionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DAL.DALFuncionario insertFuncionario = new DAL.DALFuncionario();
           
            Modelo.Funcionario Funcionario = new Modelo.Funcionario(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, Convert.ToDouble(TextBox5.Text), Convert.ToBoolean(CheckBox1.Checked), Convert.ToBoolean(CheckBox2.Checked), TextBox6.Text);
            insertFuncionario.InserirFuncionario(Funcionario);
            Response.Redirect("./Funcionario.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Funcionario.aspx");
        }
        }
    }