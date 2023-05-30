using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using System.Data.SqlClient;

namespace Casamento
{
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }

        int id;
        string produto;
        private void Compra_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = System.DateTime.Today.ToShortDateString();
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCad_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComsultaProdcom_Click(object sender, EventArgs e)
        {
            BLLCom bllco = new BLLCom();
            

            DataTable dt = bllco.SelecionarProdcomId(textBoxConsultaProdcom.Text);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Produto Invalido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string NomeProdcom = dt.Rows[0][2].ToString();
            textBoxNomeProdcom.Text = NomeProdcom;

            string ValorLoteProdcom = dt.Rows[0][3].ToString();
            textBoxValorLoteProdcom.Text = ValorLoteProdcom;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DAO.DAOCom itc = new DAO.DAOCom();

            if (textBoxValorLoteProdcom.Text == "")
            {
                MessageBox.Show("Pesquise algum item", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //itc.InserirGridCom(textBoxNomeProdcom.Text,);
            }

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomefcd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostarEstoque FRM = new MostarEstoque();
            FRM.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Mostrar_Catalogo m = new Mostrar_Catalogo();
            m.ShowDialog();
            textBoxConsultaProdcom.Focus();
            produto = m.prod.ToString();
            textBoxConsultaProdcom.Text = produto;
        }
    }
}
