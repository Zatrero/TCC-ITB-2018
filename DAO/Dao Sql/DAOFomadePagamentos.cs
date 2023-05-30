using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAO;

namespace DAO
{
    public class DAOFomadePagamentos
    {
        private static ClasseConexaoSql cn;
        ClasseConexaoSql conexao = new ClasseConexaoSql();
        private SqlCommand statement;
        private DataSet rs;
        private DataTable dt;
        private static string SQL;

        public void inserirforma(Forma forma) {
            try
            {
               ClasseConexaoSql conexao = new ClasseConexaoSql();
                SQL="INSERT INTO FORMA (NOME_FORMA)"+ "VALUES('"+forma.Nome+ "')";
                conexao.ExecutarComando(SQL);
                MessageBox.Show("Forma de Pagamento Cadastrada");


            }
            catch (Exception)
            {
                
                throw;
            }
        
        }

        public void inserirpagamento(Forma forma)
        {
            try
            {
                ClasseConexaoSql conexao = new ClasseConexaoSql();
                SQL = "INSERT INTO FORMA_VENDA(ID_FORMA,ID_VENDA,VALOR_FORMA)" + "VALUES=("+forma.idform+","+forma.idven+","+forma.valor+")";
                conexao.ExecutarComando(SQL);
                MessageBox.Show("Pago");
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        
        }
    }


