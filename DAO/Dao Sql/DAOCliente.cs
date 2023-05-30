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
    public class DAOCliente
    {
        private static ClasseConexaoSql cn;
        ClasseConexaoSql conexao = new ClasseConexaoSql();
        private SqlCommand statement;
        private DataSet rs;
        private static string SQL;

        //CADASTRA O CLIENTE
        public void inserircli(Cliente cliente)
        {

            try
            {
                ClasseConexaoSql conexao = new ClasseConexaoSql();

                //string info = "";
                SQL = "INSERT INTO TB_CLI(Nome_Cliente,Nasc_Cliente,Casamento_Cliente,Telefone_Cliente,CPF_Cliente,Sexo_Cliente,Email_Cliente,Senha_Cliente)"
                    + "VALUES('" + cliente.Nome + "','" + cliente.DateCli + "','" + cliente.DateCasa + "','" + cliente.Telefone + "','" + cliente.CPF + "','" + cliente.Sexo + "','" + cliente.Email + "','" + cliente.Senha + "')";
                //info = "TRocado com sucesso";
                conexao.ExecutarComando(SQL);
                MessageBox.Show("Inserido com sucesso");
                //return info;
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        
        //BUSCA O CLIENTE
        public DataTable buscarClienteId(string CPF)
        {
            //chama a Conexao
            DataTable dt = new DataTable();
            string SQL = "SELECT * FROM TB_CLI WHERE CPF_Cliente='" + CPF + "'";
            dt = conexao.RetornarDataTable(SQL);
            return dt;

        }

        //BUSCA TODOS OS CLIENTES
        public DataTable BuscarClientesDao()
        {
            try
            {
                ClasseConexaoSql conexao = new ClasseConexaoSql();

                DataTable dt = new DataTable();
                string SQL = "SELECT * FROM TB_CLI";
                dt = conexao.RetornarDataTable(SQL);
                return dt; 


            }
            catch (Exception)
            {

                throw;
            }
        }

        //ATUALIZAR CLIENTE
        public void AtualizarCli(Cliente cliente)
        {
            try
            {
                ClasseConexaoSql conexao = new ClasseConexaoSql();

                SQL = "UPDATE TB_CLI SET Casamento_Cliente ='" + cliente.DateCasa + "',Telefone_Cliente ='" + cliente.Telefone + "',Email_Cliente= '" + cliente.Email + "'WHERE CPF_Cliente ='" + cliente.CPF + "'";
                conexao.ExecutarComando(SQL);
                MessageBox.Show("Atualizado com sucesso");
            }
            catch (Exception)
            {
                
                throw;
            }
        }

       


    }
}