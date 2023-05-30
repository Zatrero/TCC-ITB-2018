using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAO
{
    public class DAOCom
    {
        private static ClasseConexaoSql cn;
        ClasseConexaoSql conexao = new ClasseConexaoSql();
        private SqlCommand statement;
        private DataSet rs;
        private static string SQL;

        //ID DA ULTIMA compra
        public DataTable BuscarCodecom(int id) 
        {
            DataTable dt = new DataTable();
            string SQL = "SELECT MAX(ID_COMPRA) FROM TB_COMPRA";
            dt = conexao.RetornarDataTable(SQL);
            return dt;
        }

        //INICIAR COMPRA
        public void inserircompra(Compra compra)
        {
            try
            {
               ClasseConexaoSql conexao = new ClasseConexaoSql();

               SQL = "INSERT INTO TB_COMPRA(TOTAL)" +
                   "VALUES('" + compra.Total + "')";
               conexao.ExecutarComando(SQL);
               MessageBox.Show("Insira os produtos");


            }
            catch (Exception)
            {
                
                throw;
            }
        }
        
       //BUSCA OS PRODUTOS       
        
        public DataTable buscarProdcom(string Idprod)
        {
            try
            {
                //chama a Conexao
                DataTable dt = new DataTable();
                string SQL = "SELECT * FROM TB_PRODUTO WHERE ID_PRODUTO ='"+ Idprod + "'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;

            }

            catch (Exception ex)
            {
                throw ex;

            }
        }

        //CADASTRA OS PRODUTOS PARA IREM AO GRID
        public void InserirGridCom(Compra compra)
        {
            try
            {
                ClasseConexaoSql conexao = new ClasseConexaoSql();

                SQL="INSERT INTO ITEM_COMPRA(ID_COMPRA,ID_PRODUTO,QUANTIDADE_ITENS,VALOR_UNID_COM)"+
                    "VALUES('" + compra.Idcomp + "','" + compra.Idprod + "','" + compra.Quanta + "','" + compra.Valor + "')";
                conexao.ExecutarComando(SQL);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        //CHAMA OS ITENS PARA O GRID
        public DataTable RetornaItemCompra()
        {
            ClasseConexaoSql conexao = new ClasseConexaoSql();

            DataTable dt = new DataTable();
            string SQL = "SELECT MAX (ID_ITENS) FROM ITEM_COMPRA";
            dt = conexao.RetornarDataTable(SQL);
            return dt;
        }

        //BUSCA OS ITENS PARA O GRID
        public DataTable BuscarItens(int id)
        {
            try
            {
                ClasseConexaoSql conexao = new ClasseConexaoSql();

                DataTable dt = new DataTable();
                string SQL = "SELECT FROM * ITEM_COMPRA WHERE ID_COMPRA ="+id;
                dt = conexao.RetornarDataTable(SQL);
                return dt;

            }
            catch (Exception)
            {
                
                throw;
            }


        }

        //ALTERAR TOTAL
        public DataTable MudarTotal(int id)
        {
            ClasseConexaoSql conexao = new ClasseConexaoSql();

            DataTable dt = new DataTable();
            string SQL = "SELECT SUM (VALOR_UNID_COM * QUANTIDADE_ITENS) FROM ITEM_COMPRA WHERE ID_COMPRA= " + id;
            dt = conexao.RetornarDataTable(SQL);
            return dt;
        }

    }
}
