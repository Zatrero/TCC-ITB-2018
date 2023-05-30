using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using BLL;
using DAO;
using System.Data.SqlClient;


namespace Casamento
{
    public partial class CadProd : Form
    {
        int a;
        
        public CadProd()
        {
            InitializeComponent();
        }
        public string prodd;
        public int idforn;
        BLLProd produto = new BLLProd();



        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (txtNomeProduto.Text == "" || txtCaracteristcaProduto.Text == "" || txtFornecedorProduto.Text == "" || txtValorLoteProduto.Text == "" || txtValorUnidProduto.Text == "" || pictureBox1.ImageLocation == "")
            {
                MessageBox.Show("Preencha o formulário corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                BLLProd bllprod = new BLLProd();
                bllprod.incluirprod(Convert.ToInt32(txtFornecedorProduto.SelectedValue), txtNomeProduto.Text, Convert.ToDouble(txtValorLoteProduto.Text), Convert.ToDouble(txtValorUnidProduto.Text), txtCaracteristcaProduto.Text, pictureBox1.ImageLocation);
                this.txtCaracteristcaProduto.Clear();
                this.txtCodid.Clear();
                this.txtFornecedorProduto.Text = "";
                this.txtNomeProduto.Clear();
                this.txtNomeProduto.Clear();
                this.txtValorLoteProduto.Clear();
                this.txtValorUnidProduto.Clear();
                this.pictureBox1.Image = null;
            }

            ////this.txtNomepcd.Clear();
            //this.txtCarac.Clear();
            //this.txtValor.Clear();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void selecionarFoto()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Imagem";
            ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(ofd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selecionarFoto();

            //Inserir diretório da imagem
            //string aaa = pictureBox1.ImageLocation;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxForn_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CadProd_Load(object sender, EventArgs e)
        {
            string Sql;
            ClasseConexaoSql cc = new ClasseConexaoSql();
            Sql = "SELECT * FROM TB_FORNECEDOR";
            DataTable dt = cc.RetornarDataTable(Sql);
            //SqlDataReader dr = cc.RetornarDataReader(Sql);
            //dt.Load(dr);
            txtFornecedorProduto.DataSource = dt;
            txtFornecedorProduto.DisplayMember = "NICKNAME_FORNECEDOR";
            txtFornecedorProduto.ValueMember = "ID_FORNECEDOR";
            txtFornecedorProduto.SelectedIndex = -1;
           
        }


        //PERGUNTA PRO RENATO COMO PUXAR O NOME DO FORNECEDOR 
        //NÃO ESQUECE!!!!!!!
        private void btnConsulta_Click(object sender, EventArgs e)
        {

           
            if (txtCodid.Text =="")
            {
                Mostrar_Catalogo m = new Mostrar_Catalogo();
                m.ShowDialog();
                txtCodid.Focus();
                prodd = m.prod.ToString();
                txtCodid.Text = prodd;

                

            }


            else
            if(txtCodid.Text!="")
            {
                 BLLProd bllpro = new BLLProd();
            DataTable dt = bllpro.SelecionarProdutoNome(int.Parse(txtCodid.Text));
                string idforn = dt.Rows[0][1].ToString();
                txtFornecedorProduto.Text = idforn;

                string Nome = dt.Rows[0][2].ToString();
                txtNomeProduto.Text = Nome;

                string ValorLote = dt.Rows[0][3].ToString();
                txtValorLoteProduto.Text = ValorLote;

                string ValorUnid = dt.Rows[0][4].ToString();
                txtValorUnidProduto.Text = ValorUnid;

                string Caracteristicas = dt.Rows[0][5].ToString();
                txtCaracteristcaProduto.Text = Caracteristicas;

                string Imagem = dt.Rows[0][6].ToString();
                pictureBox1.ImageLocation = Imagem;
            }
        }

            
        

        private void Atualizar()
        {
            produto = new BLLProd();
            produto.atualizarprod(txtNomeProduto.Text, Convert.ToDouble(txtValorLoteProduto.Text), Convert.ToDouble(txtValorUnidProduto.Text), txtCaracteristcaProduto.Text,pictureBox1.ImageLocation,int.Parse(txtCodid.Text));
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
            this.txtCaracteristcaProduto.Clear();
            this.txtCodid.Clear();
            this.txtFornecedorProduto.Text = "";
            this.txtNomeProduto.Clear();
            this.txtNomeProduto.Clear();
            this.txtValorLoteProduto.Clear();
            this.txtValorUnidProduto.Clear();
            this.pictureBox1.Image = null;
        }

        private void btnMostarProduto_Click(object sender, EventArgs e)
        {
            Mostrar_Catalogo FRM = new Mostrar_Catalogo();
            FRM.Show();
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtValorLoteProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorUnidProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtCaracteristcaProduto.Clear();
            this.txtCodid.Clear();
            this.txtFornecedorProduto.Text = "";
            this.txtNomeProduto.Clear();
            this.txtNomeProduto.Clear();
            this.txtValorLoteProduto.Clear();
            this.txtValorUnidProduto.Clear();
            this.pictureBox1.Image = null;

        }

        private void txtCodid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEst_Click(object sender, EventArgs e)
        {
            ControledeEstoque FRM = new ControledeEstoque();
            FRM.Show();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

       
    }
}
