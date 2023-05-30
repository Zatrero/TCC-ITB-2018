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
    public class BLLCom
    {
        Compra compra = new Compra();
        DAOCom daoco = new DAOCom();


        //RETORNA O ID DA ULTIMA COMPRA
        public DataTable Selecionarid(int id)
        {
            return daoco.BuscarCodecom(id);
        }

        //INICIA A COMPRA
        public void incluircompra(string id, double Total)
        {
            compra = new Compra();
            //compra.Produto = prod;
            compra.Total = Total;
            daoco.inserircompra(compra);
        }

        //BUSCA DOS PRODUTOS
        public DataTable SelecionarProdcomId(string Idprod)
        {
            DAOCom daoco = new DAOCom();
            return daoco.buscarProdcom(Idprod);

        }

        //CADASTRO ITENS PRO GRID
        public void incluiritem(int idprod, int idcomp, int Quanta, double Valor)
        {
            compra = new Compra();
            compra.Idprod = idprod;
            compra.Idcomp = idcomp;
            compra.Quanta = Quanta;
            compra.Valor = Valor;

            daoco.InserirGridCom(compra);
        }

        //CHAMAR OS ITENS PARA O GRID
        public DataTable Buscaritensgrid(int id)
        {
            return daoco.BuscarItens(id);
        }

        //MUDAR O TOTAL
        public DataTable MudaTotal(int id)
        {
            return daoco.MudarTotal(id);
        }

        

    }
}
