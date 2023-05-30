using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace Casamento
{
    public partial class CadFuncio : Form
    {
        public CadFuncio()
        {
            InitializeComponent();
        }

        string sexo;
        

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (txtCEPFuncio.Text == "" || textBoxNomefcd.Text == "" || TextBoxCPFfcd.Text == "" || txtNumeroFun.Text == "" || txtSalario.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                    BLLFunci bllfu = new BLLFunci();
                    bllfu.incluirfu(textBoxNomefcd.Text, TextBoxCPFfcd.Text,TextBoxRGfcd.Text, txtCEPFuncio.Text, txtCidadeFun.Text, txtBairroFun.Text,txtLogradouroFun.Text, Convert.ToInt16(txtNumeroFun.Text), txtComplementoFun.Text, txtUFFun.Text, sexo, txtEmail.Text, Convert.ToDouble(txtSalario.Text), comboBox1.Text);
                    this.textBoxNomefcd.Clear();
                    this.TextBoxRGfcd.Clear();
                    this.TextBoxCPFfcd.Clear();
                    this.txtEmail.Clear();
                    this.txtCEPFuncio.Clear();
                    this.txtBairroFun.Clear();
                    this.txtCidadeFun.Clear();
                    this.txtComplementoFun.Clear();
                    this.txtLogradouroFun.Clear();
                    this.txtNumeroFun.Clear();
                    this.txtUFFun.Clear();
                    this.txtSalario.Clear();
                    this.textBoxNomefcd.Focus();                
            }
        }

        private void CadFuncio_Load(object sender, EventArgs e)
        {

        }

        private void radioBtnM_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnM.Checked)
            {
                sexo = "M";
            }
        }

        private void radioBtnF_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnF.Checked)
            {
                sexo = "F";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizarFuncio_Click(object sender, EventArgs e)
        {

            if (textBoxNomefcd.Text == "" || TextBoxCPFfcd.Text == "" || txtEmail.Text == "" || txtCEPFuncio.Text == "" || txtBairroFun.Text == "" || txtCidadeFun.Text == "" || txtComplementoFun.Text == "" || txtLogradouroFun.Text == "" || txtNumeroFun.Text == "" || txtUFFun.Text == "" || txtSalario.Text == "")
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                BLLFunci bllfu = new BLLFunci();
                bllfu.atualizafuncio(textBoxNomefcd.Text, txtCEPFuncio.Text, txtCidadeFun.Text, txtBairroFun.Text, txtLogradouroFun.Text, Convert.ToInt16(txtNumeroFun.Text), txtComplementoFun.Text, txtUFFun.Text, txtEmail.Text, Convert.ToDouble(txtSalario.Text), comboBox1.Text);

                this.textBoxNomefcd.Clear();
                this.TextBoxCPFfcd.Clear();
                this.txtEmail.Clear();
                this.txtCEPFuncio.Clear();
                this.txtBairroFun.Clear();
                this.txtCidadeFun.Clear();
                this.txtComplementoFun.Clear();
                this.txtLogradouroFun.Clear();
                this.txtNumeroFun.Clear();
                this.txtUFFun.Clear();
                this.txtSalario.Clear();
                this.textBoxNomefcd.Focus();
                this.textBoxNomefcd.ReadOnly = false;
                this.TextBoxCPFfcd.ReadOnly = false;
                this.TextBoxRGfcd.ReadOnly = false;
                this.label6.Show();
                this.radioBtnF.Show();
                this.radioBtnM.Show();
            }
           
        }

        private void btnConsultarFunc_Click(object sender, EventArgs e)
        {
            BLLFunci bllfu = new BLLFunci();
            DataTable dt = bllfu.SelecionarFun(TextBoxCPFfcd.Text);


            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Funcionário não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Nome = dt.Rows[0][1].ToString();
                textBoxNomefcd.Text = Nome;

                string CPF = dt.Rows[0][2].ToString();
                TextBoxCPFfcd.Text = CPF;

                string RG = dt.Rows[0][3].ToString();
                TextBoxRGfcd.Text = RG;

                string CEP = dt.Rows[0][4].ToString();
                txtCEPFuncio.Text = CEP;

                string Cidade = dt.Rows[0][5].ToString();
                txtCidadeFun.Text = Cidade;

                string Bairro = dt.Rows[0][6].ToString();
                txtBairroFun.Text = Bairro;

                string Logradouro = dt.Rows[0][7].ToString();
                txtLogradouroFun.Text = Logradouro;

                string Numero = dt.Rows[0][8].ToString();
                txtNumeroFun.Text = Numero;

                string Complemento = dt.Rows[0][9].ToString();
                txtComplementoFun.Text = Complemento;

                string UF = dt.Rows[0][10].ToString();
                txtUFFun.Text = UF;

                string Email = dt.Rows[0][12].ToString();
                txtEmail.Text = Email;

                string Salario = dt.Rows[0][13].ToString();
                txtSalario.Text = Salario;

                string Cargo = dt.Rows[0][14].ToString();
                comboBox1.Text = Cargo;

                this.textBoxNomefcd.ReadOnly = true;
                this.TextBoxCPFfcd.ReadOnly = true;
                this.TextBoxRGfcd.ReadOnly = true;
                this.label6.Hide();
                this.radioBtnF.Hide();
                this.radioBtnM.Hide();
                


            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarFuncionarios_Click(object sender, EventArgs e)
        {
            MostrarFuncionario FRM = new MostrarFuncionario();
            FRM.Show();
        }

        private void btnLimpaf_Click(object sender, EventArgs e)
        {
            this.textBoxNomefcd.Clear();
            this.TextBoxCPFfcd.Clear();
            this.txtEmail.Clear();
            this.txtCEPFuncio.Clear();
            this.txtBairroFun.Clear();
            this.txtCidadeFun.Clear();
            this.txtComplementoFun.Clear();
            this.txtLogradouroFun.Clear();
            this.txtNumeroFun.Clear();
            this.txtUFFun.Clear();
            this.txtSalario.Clear();
            this.textBoxNomefcd.Focus();
            this.textBoxNomefcd.ReadOnly = false;
            this.TextBoxCPFfcd.ReadOnly = false;
            this.TextBoxRGfcd.ReadOnly = false;
            this.label6.Show();
            this.radioBtnF.Show();
        }

        private void TextBoxCPFfcd_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnBuscarCEP_Click(object sender, EventArgs e)
        {
            BLL.BLLForn bllfo = new BLL.BLLForn();

            DataTable dt = bllfo.SelecionarCEP(txtCEPFuncio.Text);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("CEP Invalido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Logradouro = dt.Rows[0][2].ToString();
                txtLogradouroFun.Text = Logradouro;

                string Cidade = dt.Rows[0][3].ToString();
                txtCidadeFun.Text = Cidade;

                string Bairro = dt.Rows[0][4].ToString();
                txtBairroFun.Text = Bairro;

                string UF = dt.Rows[0][1].ToString();
                txtUFFun.Text = UF;

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
