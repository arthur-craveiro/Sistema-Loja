using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistemaloja.Modelo
{
    public class Compras
    {
        public int idCompras { get; set; }
        public DateTime datas { get; set; }
        public double desconto { get; set; }
        public double valorTotal { get; set; }
        public Fornecedores fornecedores { get; set; }
        public int idFornecedores
        {
            get { return fornecedores.idFornecedores; }
            set { fornecedores.idFornecedores = value; }
        }

        public Compras(int aidCompras, DateTime adatas, double adesconto, double avalorTotal, int aidFornecedores)
        {
            this.idCompras = aidCompras;
            this.datas = adatas;
            this.desconto = adesconto;
            this.valorTotal = avalorTotal;
            DAL.DALFornecedores dalfornecedores = new DAL.DALFornecedores();
            this.idFornecedores = aidFornecedores;
        }

        public Compras(DateTime adatas, double adesconto, double avalorTotal, int aidFornecedores)
        {
            this.datas = adatas;
            this.desconto = adesconto;
            this.valorTotal = avalorTotal;
            DAL.DALFornecedores dalfornecedores = new DAL.DALFornecedores();
            this.idFornecedores = aidFornecedores;
        }
    }
}