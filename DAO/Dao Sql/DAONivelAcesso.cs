using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DAO
{
    public class DAONivelAcesso
    {
        private static ClasseConexaoSql cn;
        ClasseConexaoSql conexao = new ClasseConexaoSql();
        private SqlCommand statement;
        private DataSet rs;
        private static string SQL;

        public void inserirnivelacesso(NivelAcesso nvl)
        {
            try
            {
                ClasseConexaoSql conexao = new ClasseConexaoSql();

                SQL = "INSERT INTO TB_USUARIO(USUARIO,SENHA,NIVELACESSO,FK_FUNCIONARIO,STATUS) "
                    + "VALUES('" + nvl.usuariologin + "','" + nvl.senhalogin + "','" + nvl.nivelacesso + "'," + nvl.fk_funcionario + ",'" + nvl.status + "')";

                conexao.ExecutarComando(SQL);
                MessageBox.Show("Inserido com sucesso");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable buscarLogin(string usu, string sen)
        {
            DataTable dt = new DataTable();
            string SQL = "Select * from TB_USUARIO where USUARIO = '" + usu + "' AND SENHA = '" + sen + "'";
            dt = conexao.RetornarDataTable(SQL);
            return dt;
        }
        public Funcionario pegardados(int idfunc)
        {
            Funcionario f = new Funcionario();
            ClasseConexaoSql conexao = new ClasseConexaoSql();
            SqlDataReader dr;

            string SQL = "SELECT NOME_FUNC,CPF_FUNC FROM TB_FUNCIONARIO WHERE ID_FUNC = '" + idfunc + "'";
            dr = conexao.RetornarDataReader(SQL);
            while (dr.Read())
            {
                f.Nome = Convert.ToString(dr["NOME_FUNC"]);
                f.CPF = Convert.ToString(dr["CPF_FUNC"]);
            }
            return f;
        }

        public void atualizarSenha(NivelAcesso c)
        {
            try
            {
                ClasseConexaoSql conexao = new ClasseConexaoSql();

                SQL = "update TB_USUARIO set senha='" + c.senhalogin + "',status='" + c.status + "' where usuario = '" + c.usuariologin + "'";


                conexao.ExecutarComando(SQL);
                MessageBox.Show("atualizado com sucesso!");
                
            }

            catch (SqlException ex)
            {

            }

        }

    }
}
