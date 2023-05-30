using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class Venda
    {
        public int Idven { get; set; }                            
        public int Idprod { get; set; }
        public int Idcli { get; set; }
        public int Iditens { get; set; }
        public DateTime Data { get; set; }
        public string Cliente { get; set; }
        public string CPF { get; set; }
        public double Valor { get; set; }
        public double Quantidade { get; set; }
        public string Produto { get; set; }
        public double Total { get; set; }
    }
}
