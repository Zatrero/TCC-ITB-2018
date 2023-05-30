using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;



public class ClasseConexaoSql
{
    public static SqlConnection connection;
    private static SqlCommand cmd;
    private static SqlDataAdapter da;
    private static SqlDataReader dr;
    private static SqlParameter p;
    private static SqlParameter q;
    private static DataSet ds;
    private static string SQL;
    private static string dado;
    private static DataTable dt;

    private static string connectionCOM = "Data Source=DESKTOP-M0OFUE5;Initial Catalog=TCCasamento;User ID=sa; password=123456; Trusted_Connection=False";

    public string Conexao()
    {
        connection = new SqlConnection(connectionCOM);
        string info = "";
        try
        {
            if (connection.State == ConnectionState.Closed)
            {

                connection.Open();
                info = "Conectado com a versão Sql" + connection.ServerVersion + "Utilizando a fonte " + connection.DataSource;
            }

        }
        catch (SqlException ex)
        {

            return ex.Message;
        }
        return info + " Estado conexão " + connection.State.ToString() + "Ok";
    }


    public DataTable RetornarDataTable(string sqlComando)
    {
        try
        {
            Conexao();
            DataTable dt = new DataTable();
            cmd = new SqlCommand(sqlComando, connection);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FinalizarConexao();
            return dt;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }


    public void FinalizarConexao()
    {
        connection.Close();
        connection.Dispose();
    }

    public SqlDataReader RetornarDataReader(string sqlComando)
    {

        Conexao();

        cmd = new SqlCommand(sqlComando, connection);
        dr = cmd.ExecuteReader();

        return dr;


    }



    public DataSet RetornarDataSet(string sqlComando)
    {
        try
        {
            Conexao();
            ds = new DataSet();
            cmd = new SqlCommand(sqlComando, connection);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public void ExecutarComando(string sqlComando)
    {
        try
        {
            Conexao();
            SqlCommand cmd = new SqlCommand(sqlComando, connection);
            cmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {

            //throw ex;
        }
        finally
        {
            FinalizarConexao();
        }
    }
}

