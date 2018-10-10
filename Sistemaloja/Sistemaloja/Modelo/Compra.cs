using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistemaloja.Modelo
{
    public class Compra
    {
        public int idCompra { get; set; }
        public DateTime datas { get; set; }
        public double desconto { get; set; }
        public double valorTotal { get; set; }
        public Fornecedores Fornecedor { get; set; }
        public int idFornecedores
        {
            get { return Fornecedor.idFornecedores; }
            set { Fornecedor.idFornecedores = value; }
        }
        public Compra(int idCompra, DateTime datas, double desconto, double valorTotal, int aidFornecedores)
        {
            this.idCompra = idCompra;
            this.datas = datas;
            this.desconto = desconto;
            this.valorTotal = valorTotal;
            DAL.DALFornecedores dalFornecedor = new DAL.DALFornecedores();
            Fornecedor = dalFornecedor.SelectFornecedores(aidFornecedores)[0];
        }

        public Compra(DateTime datas, double desconto, double valorTotal, int aidFornecedores)
        {
            this.datas = datas;
            this.desconto = desconto;
            this.valorTotal = valorTotal;
            DAL.DALFornecedores dalFornecedor = new DAL.DALFornecedores();
            Fornecedor = dalFornecedor.SelectFornecedores(aidFornecedores)[0];
        }
    }
}