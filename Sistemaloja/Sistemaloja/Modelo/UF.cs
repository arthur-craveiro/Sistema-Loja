using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistemaloja.Modelo
{
    public class UF
    {
        public string sigla { get; set; }

        public UF() {
            this.sigla = "";
        }

        public UF(string aSigla) {
            this.sigla = aSigla;
        }
    }
}