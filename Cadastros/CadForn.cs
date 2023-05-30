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
    public partial class CadForn :Form
    {
        public CadForn()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscarCEP_Click(object sender, EventArgs e)
        {
            BLL.BLLForn bllfo = new BLL.BLLForn();

            DataTable dt = bllfo.SelecionarCEP(TextBoxCEP.Text);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("CEP Invalido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Logradouro = dt.Rows[0][2].ToString();
                textBoxLogradouro.Text = Logradouro;

                string Cidade = dt.Rows[0][3].ToString();
                textBoxCidade.Text = Cidade;

                string Bairro = dt.Rows[0][4].ToString();
                textBoxBairro.Text = Bairro;

                string UF = dt.Rows[0][1].ToString();
                textBoxUF.Text = UF;

            }

        }

        private void btnCadFor_Click(object sender, EventArgs e)
        {
            if (textBoxNomeSocial.Text == "" || txtEndereço.Text == "" || TextBoxCEP.Text == "" || textBoxCidade.Text == "" || textBoxBairro.Text == "" || textBoxLogradouro.Text == "" || textBoxNumero.Text == "" || textBoxComplemento.Text == "" || TextBoxCNPJ.Text == "" || textBoxUF.Text == "")
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                BLL.BLLForn bllfo = new BLL.BLLForn();
                bllfo.incluirforn(textBoxNomeSocial.Text, txtEndereço.Text, TextBoxCEP.Text, textBoxCidade.Text, textBoxBairro.Text, textBoxLogradouro.Text, Convert.ToInt16(textBoxNumero.Text), textBoxComplemento.Text, TextBoxCNPJ.Text, txtEmail.Text, textBoxUF.Text);

                //this.textBoxNomeSocial.Clear();
                //this.txtEndereço.Clear();
                //this.TextBoxCEP.Clear();
                //this.textBoxCidade.Clear();
                //this.textBoxBairro.Clear();
                //this.textBoxLogradouro.Clear();
                //this.textBoxNumero.Clear();
                //this.textBoxComplemento.Clear();
                //this.TextBoxCNPJ.Clear();
                //this.txtEmail.Clear();
                //this.textBoxUF.Clear();

            }
        }

        private void groupBoxForn_Enter(object sender, EventArgs e)
        {

        }

        private void btnSairForn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
