using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAO;
using BLL;

namespace Casamento
{
    public partial class Venda : Form
    {
        int a;

        public Venda()
        {
            InitializeComponent();
        }

        public string produto;
         int id;

        private void Venda_Load(object sender, EventArgs e)
        {
        }

       
        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cliente_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DAO.DAOVen itv = new DAO.DAOVen();           


            if (ValorUni.Text == "")
            {
                MessageBox.Show("Pesquise algum item", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BLLVenda bllven = new BLLVenda();

                bllven.incluiritens(Convert.ToInt16(textBox4.Text), Convert.ToInt16(txtCodven.Text), Convert.ToInt16(textBoxQuantiven.Text), Convert.ToDouble(ValorUni.Text));

                dataGridView1.DataSource = bllven.Buscaritensgrid(int.Parse(txtCodven.Text));

                DataTable rt = bllven.MudarTotal(int.Parse(txtCodven.Text));

                txtTotal.Text = rt.Rows[0][0].ToString();

                btnCad.Visible = true;

                // SELECT SUM(VALOR*QUTIDADE) FROM TB_ITENS WHERE IDVENDA = IDN
            }            


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            //Insere o total na venda e mostra uma mensagem de venda finalizada limpando os textbox

             BLLVenda bllven = new BLLVenda();
            bllven.AtualizarTotalVazio(Convert.ToDouble(txtTotal.Text));

           Pagar FRM = new Pagar();
            FRM.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BLLVenda bllven = new BLLVenda();


            DataTable dt = bllven.SelecionarProdvenId(textBox4.Text);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Produto invalido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else {
            string NomeProdven = dt.Rows[0][2].ToString();
            textBox2.Text = NomeProdven;

            string ValorLoteProdven = dt.Rows[0][4].ToString();
            ValorUni.Text = ValorLoteProdven;
            }
        }

        private void btnBuscarCEP_Click(object sender, EventArgs e)
        {
            BLL.BLLVenda bllven = new BLLVenda();

            DataTable dt = bllven.SelecionarClientev(txtCPFven.Text);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("CPF Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                id = Convert.ToInt32(dt.Rows[0][0]);
                string Nome = dt.Rows[0][1].ToString();
                textBoxCliven.Text = Nome;
            }
        }

        private void btnIniven_Click(object sender, EventArgs e)
        {
            BLL.BLLVenda bllven = new BLLVenda();
            ClasseConexaoSql conexao = new ClasseConexaoSql();

            bllven.incluirvenda(id.ToString(), Convert.ToDouble(txtTotal.Text));
            string SQL = "select MAX(ID_VENDA) from TB_VENDA";
            SqlDataReader dr = conexao.RetornarDataReader(SQL);
            DataTable dt = new DataTable();
            dt.Load(dr);
            string Codeven = dt.Rows[0][0].ToString();
            txtCodven.Text = Codeven;
           

            this.btnIniven.Hide();

        }

        private void textBoxQuantiven_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTotalven_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPFven_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.BLLVenda bllven = new BLLVenda();
            ClasseConexaoSql conexao = new ClasseConexaoSql();

            bllven.incluirvenda(id.ToString(), Convert.ToDouble(txtTotal.Text));
            string SQL = "select MAX(ID_VENDA) from TB_VENDA";
            SqlDataReader dr = conexao.RetornarDataReader(SQL);
            DataTable dt = new DataTable();
            dt.Load(dr);
            string Codeven = dt.Rows[0][0].ToString();
            txtCodven.Text = Codeven;
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = e.RowIndex;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Mostrar_Catalogo m = new Mostrar_Catalogo();
            m.ShowDialog();
            textBox4.Focus();
            produto = m.prod.ToString();
            textBox4.Text = produto;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
