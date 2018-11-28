using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistemaloja.Modelo
{
    public class Produtos
    {
        public int idProduto { get; set; }
        public string descricao { get; set; }
        public string codigo {get;set;}

        public Produtos(int aidProduto, string acodigo, string adescricao)
        {
            this.idProduto = aidProduto;
            this.descricao = adescricao;
            this.codigo = acodigo;
        }
        public Produtos(string acodigo, string adescricao)
        { 
            this.codigo = acodigo;
            this.descricao = adescricao;
        }
    } 
}