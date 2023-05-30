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
    public class BLLForma
    {
        Forma forma = new Forma();
        DAOFomadePagamentos daofp = new DAOFomadePagamentos();

        public void incluirforma (string nome)
         {
             forma = new Forma();
             forma.Nome = nome;

             daofp = new DAOFomadePagamentos();
             daofp.inserirforma(forma);
         }

        public void incluirpag(int idform, int idven, double valor)
        {
            forma = new Forma();
            forma.idform = idform;
            forma.idven = idven;
            forma.valor = valor;

            daofp.inserirpagamento(forma);
        }
    }
}
