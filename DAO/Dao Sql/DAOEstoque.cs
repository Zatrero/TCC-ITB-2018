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
    public class DAOEstoque
    {
        private static ClasseConexaoSql cn;
        ClasseConexaoSql conexao = new ClasseConexaoSql();
        private SqlCommand statement;
        private DataSet rs;
        private static string SQL;

        public void InserirEstoque(Estoque est)
        {
            
            try
            {
                SQL = "INSERT INTO Estoquefunciona (Id_Pro, Quantidade, Minimo )" + 
                    "VALUES("+ est.idprod + "," + est.quantidade + "," + est.estoquemin+")";
                conexao.ExecutarComando(SQL);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataTable ConsultarEstoque()
        {
            try
            {
                DataTable dt = new DataTable();
                SQL = "SELECT * FROM  Estoquefunciona";
                conexao.ExecutarComando(SQL);
                dt = conexao.RetornarDataTable(SQL);
                return dt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataTable BuscarProduto(int idprod)
        {
            DataTable dt = new DataTable();
            string SQL = "SELECT * FROM TB_PRODUTO WHERE ID_PRODUTO ='" + idprod + "'";
            dt = conexao.RetornarDataTable(SQL);
            return dt;
        }

        
    }
}
