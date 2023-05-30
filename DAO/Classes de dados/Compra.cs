using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class Compra
    {
        public int Idcomp { get; set; }
        public int Idprod { get; set; }
        public int Iditens { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public int Quanta { get; set; }
        public string Produto { get; set; }
        public double Total { get; set; }

    }
}
