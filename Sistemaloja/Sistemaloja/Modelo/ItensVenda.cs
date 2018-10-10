using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistemaloja.Modelo
{
    public class ItensVenda
    {
        public int idItem { get; set; }
        public double peso { get; set; }
        public double precokg { get; set; }
        public double valorTotal { get; set; }
        public Venda venda { get; set; }
        public int idVenda
        {
            get { return venda.idVenda; }
            set { venda.idVenda = value; }
        }
        public Produtos produto { get; set; }
        public int idProduto
        {
            get { return produto.idProduto; }
            set { produto.idProduto = value; }
        }

        public ItensVenda(int idItem, double peso, double precokg, double valorTotal, int idVenda, int idProduto)
        {
            this.idItem = idItem;
            this.peso = peso;
            this.precokg = precokg;
            this.valorTotal = valorTotal;
            DAL.DALVenda dalVenda = new DAL.DALVenda();
            venda = dalVenda.SelectVendas(idVenda)[0];
            DAL.DALProdutos dalProduto = new DAL.DALProdutos();
            produto = dalProduto.SelectProdutos(idProduto)[0];
        }

        public ItensVenda(double peso, double precokg, double valorTotal, int idVenda, int idProduto)
        {
            this.peso = peso;
            this.precokg = precokg;
            this.valorTotal = valorTotal;
            DAL.DALVenda dalVenda = new DAL.DALVenda();
            venda = dalVenda.SelectVendas(idVenda)[0];
            DAL.DALProdutos dalProduto = new DAL.DALProdutos();
            produto = dalProduto.SelectProdutos(idProduto)[0];
        }
    }
}