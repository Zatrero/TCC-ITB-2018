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
    public class DAOFu
    {
        private static ClasseConexaoSql cn;
        ClasseConexaoSql conexao = new ClasseConexaoSql();
        private SqlCommand statement;
        private DataSet rs;
        private static string SQL;

       
        //INSERIR FUNCIONARIO
        public void inserirfunc(Funcionario funcionario)
        {
            try
            {
               

                SQL = "INSERT INTO TB_FUNCIONARIO(NOME_FUNC,CPF_FUNC,RG_FUNC,CEP_FUNC ,CIDADE_FUNC ,BAIRO_FUNC,LOGRADOURO_FUNC ,NUMERO_FUNC ,COMPLEMENTO_FUNC ,UF_FUNC ,SEXO_FUNC,EMAIL_FUNC,SALARIO_FUNC,CARGO_FUNC) "
                    + "VALUES('" + funcionario.Nome + "','" + funcionario.CPF + "','" + funcionario.RG + "','" + funcionario.CEP + "','" + funcionario.Cidade + "','" + funcionario.Bairro + "','" + funcionario.Logradouro + "','" + funcionario.Numero + "','" + funcionario.Complemento + "','" + funcionario.UF + "','" + funcionario.Sexo + "','" + funcionario.Email + "','" + funcionario.Salario + "','" + funcionario.Cargo + "')";

                conexao.ExecutarComando(SQL);
                MessageBox.Show("Inserido com sucesso");
            }
            catch (Exception)
            {
                
                throw;
            }
        }


        //BUSCA O FUNCIONARIO
        public DataTable ConsultarFuncionario(string CPF)
        {
            try
            {
                DataTable dt = new DataTable();
                string SQL = "SELECT * FROM TB_FUNCIONARIO WHERE CPF_FUNC ='" + CPF + "'";
                dt = conexao.RetornarDataTable(SQL);
                return dt;

            }
            catch (Exception)
            {

                throw;
            }
        }

        //BUSCA TODOS OS FUNCIONARIOS
        public DataTable BuscarFuncionario()
        {
            try
            {
                ClasseConexaoSql conexao = new ClasseConexaoSql();

                DataTable dt = new DataTable();
                string SQL = "SELECT * FROM TB_FUNCIONARIO";
                dt = conexao.RetornarDataTable(SQL);
                return dt;


            }
            catch (Exception)
            {

                throw;
            }
        }
        
        //ATUALIZA OS DADOS DO FUNCIONARIO
        public void AtualizarFuncio(Funcionario func)
        {
            try
            {
                SQL = "UPDATE TB_FUNCIONARIO SET NOME_FUNC='" + func.Nome + "',CEP_FUNC='" + func.CEP + "',CIDADE_FUNC='" + func.Cidade + "',BAIRO_FUNC='" + func.Bairro + "',LOGRADOURO_FUNC='" + func.Logradouro + "',NUMERO_FUNC='" + func.Numero + "',COMPLEMENTO_FUNC='" + func.Complemento + "',UF_FUNC='" + func.UF + "',EMAIL_FUNC='" + func.Email + "',SALARIO_FUNC='" + func.Salario + "'CARGO_FUNC='" + func.Cargo + "'";
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
