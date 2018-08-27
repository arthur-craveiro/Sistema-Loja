using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistemaloja.Modelo
{
    public class Pagamento
    {
        public int idPagamento { get; set; }
        public double valorPago { get; set; }
        public DateTime dataDePagamento { get; set; }
        public int mesReferencia { get; set; }
        public int anoReferencia { get; set; }
        public Funcionario funcionario { get; set; }
        public int idFuncionario
        {
            get { return funcionario.idFuncionario; }
            set { funcionario.idFuncionario = value; }
        }

        public Pagamento(int aidPagamento, double avalorPago, DateTime adataDePagamento, int amesReferencia, int aanoReferencia, int aidFuncionario)
        {
            this.idPagamento = aidPagamento;
            this.valorPago = avalorPago;
            this.dataDePagamento = adataDePagamento;
            this.mesReferencia = amesReferencia;
            this.anoReferencia = aanoReferencia;
            DAL.DALFuncionario dalfuncionario = new DAL.DALFuncionario();
            funcionario = dalfuncionario.Select(aidFuncionario)[0];
        }

        public Pagamento(double avalorPago, DateTime adataDePagamento, int amesReferencia, int aanoReferencia, int aidFuncionario)
        {
            this.valorPago = avalorPago;
            this.dataDePagamento = adataDePagamento;
            this.mesReferencia = amesReferencia;
            this.anoReferencia = aanoReferencia;
            DAL.DALFuncionario dalfuncionario = new DAL.DALFuncionario();
            funcionario = dalfuncionario.Select(aidFuncionario)[0];
        }
    }
}