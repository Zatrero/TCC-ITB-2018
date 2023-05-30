﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Nick { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string UF { get; set; }
    }
}
