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
    public class DAOProduto
    {
        int id;
        private static ClasseConexaoSql cn;
        ClasseConexaoSql conexao = new ClasseConexaoSql();
        private SqlCommand statement;
        private DataSet rs;
        private static string SQL;

        public void inserirproduto(Produto produto)
        {

            try
            {
                ClasseConexaoSql conexao = new ClasseConexaoSql();

                SQL = "INSERT INTO TB_PRODUTO(ID_FORNCEDOR,NOME_PRODUTO,LOTE_PRODUTO,VALOR_PRODUTO,CARACTERISTICAS_PRODUTO,IMAGEM_PRODUTO)"
                    + "VALUES(" + produto.idforn + ",'" + produto.Nome + "'," + produto.ValorLote + "," + produto.ValorUnid + ",'" + produto.Caracteristicas + "','" + produto.Imagem + "')";

                conexao.ExecutarComando(SQL);
                MessageBox.Show("Inserido com sucesso");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable MostrarTodos()
        {
            try
            {
                DataTable dt = new DataTable();
                string SQL = "SELECT *FROM TB_PRODUTO";
                dt = conexao.RetornarDataTable(SQL);
                return dt;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataTable ConsultarProduto(int id)
        {
            try
            {
                DataTable dt = new DataTable();
                string SQL = "SELECT * FROM TB_PRODUTO WHERE ID_PRODUTO =" + id  ;
                dt = conexao.RetornarDataTable(SQL);
                return dt;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void AtualizarProd(Produto produto)
        {

            try
            {
                SQL = "UPDATE TB_PRODUTO SET NOME_PRODUTO='" + produto.Nome + "', LOTE_PRODUTO=" + produto.ValorLote + " , VALOR_PRODUTO=" + produto.ValorUnid + " , CARACTERISTICAS_PRODUTO='" + produto.Caracteristicas + "',IMAGEM_PRODUTO='"+produto.Imagem+"'WHERE ID_PRODUTO=" + produto.ID; 
                conexao.ExecutarComando(SQL);
                MessageBox.Show("Dados Mudaram");
            }
            catch (Exception)
            {
                
                throw;
            }
        }


    }
}
