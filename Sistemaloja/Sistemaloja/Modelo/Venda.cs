using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistemaloja.Modelo
{
    public class Venda
    {
        public int idVenda { get; set; }
        public DateTime datas { get; set; }
        public double desconto { get; set; }
        public double valorTotal { get; set; }
        public Cliente Cliente { get; set; }
        public int idCliente
        {
            get { return Cliente.idCliente; }
            set { Cliente.idCliente = value; }
        }
        public Venda(int idVenda, DateTime datas, double desconto, double valorTotal, int idCliente)
        {
            this.idVenda = idVenda;
            this.datas = datas;
            this.desconto = desconto;
            this.valorTotal = valorTotal;
            DAL.DALCliente dalCliente = new DAL.DALCliente();
            Cliente = dalCliente.SelectCliente(idCliente)[0];
        }

        public Venda(DateTime datas, double desconto, double valorTotal, int idCliente)
        {
            this.datas = datas;
            this.desconto = desconto;
            this.valorTotal = valorTotal;
            DAL.DALCliente dalCliente = new DAL.DALCliente();
            Cliente = dalCliente.SelectCliente(idCliente)[0];
        }
    }
}