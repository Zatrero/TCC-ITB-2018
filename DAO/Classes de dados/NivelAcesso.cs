using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class NivelAcesso
    {
        public string usuariologin { get; set; } 
        public string senhalogin { get; set; }
        public string nivelacesso { get; set; }
        public int fk_funcionario { get; set; }
        public string status { get; set; }
    }
}
