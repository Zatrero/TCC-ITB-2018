using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class Estoque
    {
       public int id { get; set; }
       public int idprod { get; set; }
       public int quantidade { get; set; }
       public int estoquemin { get; set; }
       public string nome { get; set; }
    }
}
