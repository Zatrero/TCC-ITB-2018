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
    public class BLLVenda
    {
        Venda venda = new Venda();
        DAOVen daoven = new DAOVen();

        //RETORNA O ID DA ULTIMA VENDA
        public DataTable SelecionarId(int Id)
        {
            DAOVen daoven = new DAOVen();
            return daoven.BuscarCodeven(Id);
        }
      
        //INICIAR VENDA
        public void incluirvenda(string CPFCli, double Total)
        {
            venda = new Venda();
            venda.CPF = CPFCli;
            venda.Total = Total;

            daoven.inserirven(venda);
        }
        

        //BUSCA CLIENTE
        public DataTable SelecionarClientev(string CPF)
        {
            DAOVen daoven = new DAOVen();
            return daoven.BuscarClientev(CPF);
        }
        
        //BUSCA PRODUTOS
        public DataTable SelecionarProdvenId(string Idprod) 
        {
            DAOVen daoven = new DAOVen();
            return daoven.buscarProdven(Idprod);
        }

        //CADASTRO DO ITENS PRO GRID
        public void incluiritens(int idprod, int idven, int Quantidade, double Valor)
        {
            venda = new Venda();
            venda.Idprod = idprod;
            venda.Idven = idven;
            venda.Quantidade = Quantidade;
            venda.Valor = Valor;

            daoven.inserirGrid(venda);
        }

        //CHAMAR OS ITENS PARA O GRID
        public DataTable Buscaritensgrid(int id)
        {
            return daoven.BuscarItens(id);
        }

        //MUDAR O TOTAL
        public DataTable MudarTotal(int id) 
        {
            return daoven.MudarTotal(id);
        }

        public void AtualizarTotalVazio (double Total)
        {
            venda.Total = Total;

            daoven = new DAOVen();
            daoven.FinalizarVenda(venda);
        }

        
        




    }
}
