using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAO
{
    public class DAOVen
    {
        private static ClasseConexaoSql cn;
        ClasseConexaoSql conexao = new ClasseConexaoSql();
        private SqlCommand statement;
        private DataSet rs;
        private static string SQL;

        //BUSCA ID DA ULTIMA VENDA
        public DataTable BuscarCodeven(int id)
        {

            DataTable dt = new DataTable();
            string SQL = "select MAX(ID_VENDA) from TB_VENDA"; 
            dt = conexao.RetornarDataTable(SQL);
            return dt;

        }
        
        //INICIAR VENDA
        public void inserirven(Venda venda)
        {
            try
            {
                ClasseConexaoSql conexao = new ClasseConexaoSql();

                SQL = "INSERT INTO TB_VENDA(ID_CLIENTE,TOTAL_VENDA)" +
                    "VALUES('" + venda.CPF + "','" + venda.Total + "')";
                conexao.ExecutarComando(SQL);
                MessageBox.Show("Insira os produtos");



            }
            catch (Exception)
            {

                throw;
            }
        }

        //BUSCA CLIENTE
        public DataTable BuscarClientev(string CPF)
        {
            try
            {
                DataTable dt = new DataTable();

                string SQL = "SELECT * FROM TB_CLI  WHERE CPF_Cliente = '" + CPF + "'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //BUSCA DOS PRODUTOS
        public DataTable buscarProdven(string Idprod)
        {
            try
            {
                //chama a Conexao
                DataTable dt = new DataTable();
                string SQL = "SELECT * FROM TB_PRODUTO WHERE ID_PRODUTO ='" + Idprod + "'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;

            }

            catch (Exception ex)
            {
                throw ex;

            }
        }

        //CADASTRA OS PRODUTOS PARA IREM AO GRID
        public void inserirGrid(Venda venda)
        {
            try
            {
                ClasseConexaoSql conexao = new ClasseConexaoSql();

                SQL = "INSERT INTO ITEM_VENDA (ID_VENDA,ID_PRODUTOVENDA,QUANTIDADE_ITENSVENDA,VALOR_UNID_VEN)"
                    + "VALUES('" + venda.Idven + "','" + venda.Idprod + "'," + venda.Quantidade + "," + venda.Valor + ")";


                conexao.ExecutarComando(SQL);

            }
            catch (Exception)
            {

                throw;
            }
        }

        //CHAMA OS ITENS PARA O GRID
        public DataTable RetornaItemVenda()
        {
            ClasseConexaoSql conexao = new ClasseConexaoSql();

            DataTable dt = new DataTable();
            string SQL = "SELECT MAX (ID_ITENS) FROM ITEM_VENDA ";
            dt = conexao.RetornarDataTable(SQL);
            return dt;
        }

        //BUSCAR ITENS PARA O GRID
        public DataTable BuscarItens(int id)
        {
            try
            {
                ClasseConexaoSql conexao = new ClasseConexaoSql();

                DataTable dt = new DataTable();
                string SQL = "SELECT * FROM ITEM_VENDA WHERE ID_VENDA="+id;
                dt = conexao.RetornarDataTable(SQL);
                return dt;
                
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }


        //AKI TU ALTERA O TOTAL
        public DataTable MudarTotal(int id)
        {

            try
            {
                ClasseConexaoSql conexao = new ClasseConexaoSql();

                DataTable dt = new DataTable();
                
                //string SQL = "SELECT SUM() FROM ITEM_VENDA WHERE ID_VENDA =" + id;
                string SQL = "SELECT SUM(VALOR_UNID_VEN * QUANTIDADE_ITENSVENDA) FROM ITEM_VENDA WHERE ID_VENDA =" + id;
                                 
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void FinalizarVenda (Venda ven)
        {
            try 
	        {	        
		        ClasseConexaoSql conexao = new ClasseConexaoSql();
                SQL = "UPDATE TB_VENDA SET TOTAL_VENDA='" + ven.Total + "'";
                conexao.ExecutarComando(SQL);
	        }
	        catch (Exception)
	        {
		
		        throw;
	        }
        }

        //public  List<string[]> carregaLista(int idProd, string nomeProd, int qtde) 
        //{
        //    List<string[]> listaProd = new List<string[]>();
        //    listaProd.Add(new String[] { Convert.ToString(idProd), nomeProd, Convert.ToString(qtde)});

        //    return listaProd;
        //}

             
    }
}
