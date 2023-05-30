using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using System.Data.SqlClient;

namespace Casamento
{
    public partial class Pagar : Form
    {
        public Pagar()
        {
            InitializeComponent();

           }
        double valor1;
        double valor2;
        double res;
        string idvenda;
        double valor3;
        

        private void Pagar_Load(object sender, EventArgs e)
        {
            string Sql;
            ClasseConexaoSql cc = new ClasseConexaoSql();
            Sql = "SELECT * FROM FORMA";
            DataTable dt = cc.RetornarDataTable(Sql);
            //SqlDataReader dr = cc.RetornarDataReader(Sql);
            //dt.Load(dr);
            txtForma.DataSource = dt;
            txtForma.DisplayMember = "NOME_FORMA";
            txtForma.ValueMember = "ID_FORMA";
            txtForma.SelectedIndex = -1;

            ClasseConexaoSql conexao = new ClasseConexaoSql();
            string SQL = "select MAX(ID_VENDA) from TB_VENDA";
            SqlDataReader dl = conexao.RetornarDataReader(SQL);
            DataTable dx = new DataTable();
            dx.Load(dl);
            string Codeven = dx.Rows[0][0].ToString();
            txtCodPag.Text = Codeven;

            ClasseConexaoSql conect = new ClasseConexaoSql();
            string SDL = "SELECT TOTAL_VENDA from TB_VENDA where ID_VENDA= '"+txtCodPag.Text+"'";
            SqlDataReader dw = conect.RetornarDataReader(SDL);
            DataTable dq = new DataTable();
            dq.Load(dw);
            string TotalPag = dq.Rows[0][0].ToString();
            txtTotalPag.Text = TotalPag;

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(txtTotalPag.Text);
            valor2 = Convert.ToDouble(txtValPag.Text);
            res = valor1 - valor2;
            txtTotalPag.Text = res.ToString();

            if (txtForma.Text==""||txtValPag.Text=="")
            {
                MessageBox.Show("Preencha os campos", "Erro",MessageBoxButtons.OK , MessageBoxIcon.Error );
            }

            else if (Convert.ToDouble(txtValPag.Text) ==0)
            {
                MessageBox.Show("Compra Finalizada");
                btnPagar.Visible = false;
                btnLimparCli.Visible = false;

                

            }
            else if (Convert.ToDouble(txtTotalPag.Text) < 0)
            {
                if (txtForma.Text == "Dinheiro")
                {
                    valor3 = -1 * Convert.ToDouble(txtTotalPag.Text);
                    txtTroco.Text = valor3.ToString();
                    txtTroco.Visible = true;
                    label3.Visible = true;
                    btnPagar.Visible = false;
                    btnLimparCli.Visible = false;
                }

            }
            
        }

        private void txtTotalPag_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSairCli_Click(object sender, EventArgs e)
        {
            this.Close();

            ClasseConexaoSql conexao = new ClasseConexaoSql();
            string SQL = "EXEC ConferirEstoque";
            conexao.ExecutarComando(SQL);

            idvenda = txtCodPag.Text;
            string SDL ="EXEC Conferir Estoque @IDpro = "+( idvenda)+"";
            conexao.ExecutarComando(SDL);

            string SXL = "EXEC DiminuirEstoque @IDpro="+idvenda+"";
            conexao.ExecutarComando(SXL);
        }
    }
}
