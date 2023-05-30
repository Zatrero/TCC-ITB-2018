using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using System.Windows.Forms;

namespace BLL
{
    public class BLLForn
    {
        Fornecedor fornecedor = new Fornecedor();
        DAOForn daofo = new DAOForn();

        public void incluirforn(string Nome, string Nick, string CEP, string Cidade, string Bairro, string Logradouro, int Numero, string Complemento, string CNPJ, string Email,string UF)
        {
            fornecedor = new Fornecedor();
            fornecedor.Nome = Nome;
            fornecedor.Nick = Nick;
            fornecedor.CEP = CEP;
            fornecedor.Cidade = Cidade;
            fornecedor.Bairro = Bairro;
            fornecedor.Logradouro = Logradouro;
            fornecedor.Numero = Numero;
            fornecedor.Complemento = Complemento;
            fornecedor.CNPJ = CNPJ;
            fornecedor.Email = Email;
            fornecedor.UF = UF;

            daofo = new DAOForn();
            daofo.inserirForn(fornecedor);
            
        }

        public DataTable SelecionarCEP(string CEP)
        {
            DAOForn daofo = new DAOForn();
            return daofo.BuscarCEP(CEP);
        }


    }
}
