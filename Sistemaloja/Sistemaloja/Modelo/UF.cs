using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistemaloja.Modelo
{
    public class UF
    {
        public int id { get; set; }
        public string sigla { get; set; }
        public UF() {
            this.sigla = "";
        }
        public UF(int aId, string aSigla) {
            this.id = aId;
            this.sigla = aSigla;
        }
    }
}