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
    public class BLLEstoque
    {
        Estoque est = new Estoque();
        DAOEstoque daoest = new DAOEstoque();

        public void incluirestoque(int idprod, int quantidade, int estoquemin)
        {
            est = new Estoque();
            est.idprod = idprod;
            est.quantidade = quantidade;
            est.estoquemin = estoquemin;

            daoest.InserirEstoque(est);
        }

        public void buscarEstoque(DataGridView dvg)
        {
            dvg.DataSource = daoest.ConsultarEstoque();
        }

        public DataTable SelecionarProd (int id)
        {
           return daoest.BuscarProduto(id);
        }

        
    }
}
