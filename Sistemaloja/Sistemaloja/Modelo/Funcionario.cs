using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistemaloja.Modelo
{
    public class Funcionario
    {
        public int idFuncionario { get; set; }
        public string nome { get; set; }
        public string telefones { get; set; }
        public string identidade { get; set; }
        public string carteiradetrabalho { get; set; }
        public double salario { get; set; }
        public bool motorista { get; set; }
        public bool tecnico { get; set; }
        public string observacao { get; set; }

        public Funcionario(int aidFuncionario, string anome, string atelefones, string aidentidade, string acarteiradetrabalho, double asalario, bool amotorista, bool atecnico, string aobservacao)
        {
            this.idFuncionario = aidFuncionario;
            this.nome = anome;
            this.telefones = atelefones;
            this.identidade = aidentidade;
            this.carteiradetrabalho = acarteiradetrabalho;
            this.salario = salario;
            this.motorista = amotorista;
            this.tecnico = atecnico;
            this.observacao = aobservacao;
        }

        public Funcionario(string anome, string atelefones, string aidentidade, string acarteiradetrabalho, double asalario,bool amotorista, bool atecnico, string aobservacao)
        {
            this.nome = anome;
            this.telefones = atelefones;
            this.identidade = aidentidade;
            this.carteiradetrabalho = acarteiradetrabalho;
            this.salario = salario;
            this.motorista = amotorista;
            this.tecnico = atecnico;
            this.observacao = aobservacao;
        }
    }
}