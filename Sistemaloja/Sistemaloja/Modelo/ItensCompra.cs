using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistemaloja.Modelo
{
    public class ItensCompra
    {
        public int idItem { get; set; }
        public string unidade { get; set; }
        public int quantidade { get; set; }
        public double precoUnitario { get; set; }
        public double precoTotal { get; set; }
        public Compra compra { get; set; }
        public int idCompra
        {
            get { return compra.idCompra; }
            set { compra.idCompra = value; }
        }
        public Produtos produto { get; set; }
        public int idProduto
        {
            get { return produto.idProduto; }
            set { produto.idProduto = value; }
        }

        public ItensCompra(int idItem, string unidade, int quantidade, double precoUnitario, double precoTotal, int idCompra, int idProduto)
        {
            this.idItem = idItem;
            this.unidade = unidade;
            this.quantidade = quantidade;
            this.precoUnitario = precoUnitario;
            this.precoTotal = precoTotal;
            DAL.DALCompras dalCompras = new DAL.DALCompras();
            compra = dalCompras.SelectCompras(idCompra)[0];
            DAL.DALProdutos dalProdutos = new DAL.DALProdutos();
            produto = dalProdutos.SelectProdutos(idProduto)[0];
        }

        public ItensCompra(string unidade, int quantidade, double precoUnitario, double precoTotal, int idCompra, int idProduto)
        {
            this.unidade = unidade;
            this.quantidade = quantidade;
            this.precoUnitario = precoUnitario;
            this.precoTotal = precoTotal;
            DAL.DALCompras dalCompras = new DAL.DALCompras();
            compra = dalCompras.SelectCompras(idCompra)[0];
            DAL.DALProdutos dalProdutos = new DAL.DALProdutos();
            produto = dalProdutos.SelectProdutos(idProduto)[0];
        }
    }
}