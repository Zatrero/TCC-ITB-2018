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
    public class BLLProd
    {
        Produto produto = new Produto();
        DAOProduto daopro = new DAOProduto();

        public void incluirprod(int idforn, string Nome, double ValorLote , double ValorUnid, string Caracteristicas, string Imagem) 
        {
            produto = new DAO.Produto();
            produto.idforn = idforn;
            produto.Nome = Nome;
            produto.ValorLote = ValorLote;
            produto.ValorUnid = ValorUnid;
            produto.Caracteristicas = Caracteristicas;
            produto.Imagem = Imagem;

            daopro = new DAOProduto();
            daopro.inserirproduto(produto);
        }

        public DataTable SelecionarProdutoNome(int id)
        {
            DAOProduto daopro = new DAOProduto();
            return daopro.ConsultarProduto(id);

        }

        public void SelcionarTodosProdutos(DataGridView dgv)
        {
            DAOProduto daopro = new DAOProduto();
            dgv.DataSource = daopro.MostrarTodos();
        }

        public void atualizarprod(string Nome, double ValorLote, double ValorUnid, string Caracteristicas, string Imagem, int id)
        {
            produto = new DAO.Produto();
            produto.Nome = Nome;
            produto.ValorLote = ValorLote;
            produto.ValorUnid = ValorUnid;
            produto.Caracteristicas = Caracteristicas;
            produto.Imagem = Imagem;
            produto.ID = id;

            daopro = new DAOProduto();
            daopro.AtualizarProd(produto);
        }
    }
}
