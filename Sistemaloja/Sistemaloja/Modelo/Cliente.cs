using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistemaloja.Modelo
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string nome { get; set; }
        public string telefones { get; set; }
        public string cidade { get; set; }
        public string endereco { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string estado { get; set; }

        public Cliente(int aidCliente, string anome, string atelefones, string acidade, string aendereco, string aCPF, string aCNPJ, string aestado ) {
            this.idCliente = aidCliente;
            this.nome = anome;
            this.telefones = atelefones;
            this.cidade = acidade;
            this.endereco = aendereco;
            this.CPF = aCPF;
            this.CNPJ = aCNPJ;
            this.estado = aestado;
        }

        public Cliente(string anome, string atelefones, string acidade, string aendereco, string aCPF, string aCNPJ, string aestado)
        {
            this.nome = anome;
            this.telefones = atelefones;
            this.cidade = acidade;
            this.endereco = aendereco;
            this.CPF = aCPF;
            this.CNPJ = aCNPJ;
            this.estado = aestado;
        }
    }
}