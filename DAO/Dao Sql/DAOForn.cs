using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DAO
{
    public class DAOForn
    {
        private static ClasseConexaoSql cn;
        ClasseConexaoSql conexao = new ClasseConexaoSql();
        private SqlCommand statement;
        private DataSet rs;
        private static string SQL;
       
             


        public void inserirForn(Fornecedor fornecedor)
        {
            try
            {
                ClasseConexaoSql conexao = new ClasseConexaoSql();

                SQL = "INSERT INTO TB_FORNECEDOR(NOME_FORNECEDOR,NICKNAME_FORNECEDOR,CEP_FORNECEDOR,CIDADE_FORNECEDOR,BAIRO_FORNECEDOR,LOGRADOURO_FORNECEDOR,NUMERO_FORNECEDOR,COMPLEMENTO_FORNECEDOR,CNPJ_FORNECEDOR,EMAIL_FORNECEDOR,UF)"
                    + "VALUES('" + fornecedor.Nome + "','" + fornecedor.Nick + "','" + fornecedor.CEP + "','" + fornecedor.Cidade + "','" + fornecedor.Bairro + "','" + fornecedor.Logradouro + "','" + fornecedor.Numero + "','" + fornecedor.Complemento + "','" + fornecedor.CNPJ + "','" + fornecedor.Email + "','" + fornecedor.UF + "')";

                conexao.ExecutarComando(SQL);
                MessageBox.Show("Inserido com sucesso");
            }
            catch (Exception)
            {
                
                //throw;
            }
        }
        
        public DataTable BuscarCEP(string CEP)
        {
            try
            {
                DataTable dt = new DataTable();

            string SQL = "SELECT * FROM TB_CEP WHERE CEP='" + CEP + "'";
            dt = conexao.RetornarDataTable(SQL);
            return dt;

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

    }
}
