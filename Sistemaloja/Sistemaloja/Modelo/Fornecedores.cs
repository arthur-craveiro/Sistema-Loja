using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistemaloja.Modelo
{
    public class Fornecedores
    {
          public int idFornecedores { get; set; }
        public string nome { get; set; }
        public string telefones { get; set; }
        public string cidade { get; set; }
        public string endereco { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public UF uf { get; set; }
        public int estado
        {
            get { return uf.id; }
            set { uf.id = value; }
        }

        public Fornecedores(int aidFornecedores, string anome, string atelefones, string acidade, string aendereco, string aCPF, string aCNPJ, int aestado ) {
            this.idFornecedores = aidFornecedores;
            this.nome = anome;
            this.telefones = atelefones;
            this.cidade = acidade;
            this.endereco = aendereco;
            this.CPF = aCPF;
            this.CNPJ = aCNPJ;
            DAL.DALUF daluf = new DAL.DALUF();
            uf = daluf.Select(aestado)[0];
        }

        public Fornecedores(string anome, string atelefones, string acidade, string aendereco, string aCPF, string aCNPJ, int aestado)
        {
            this.nome = anome;
            this.telefones = atelefones;
            this.cidade = acidade;
            this.endereco = aendereco;
            this.CPF = aCPF;
            this.CNPJ = aCNPJ;
            DAL.DALUF daluf = new DAL.DALUF();
            uf = daluf.Select(aestado)[0];
        }
    }
}