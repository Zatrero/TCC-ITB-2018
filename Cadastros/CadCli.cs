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
    public partial class CadCli : Form
    {
        public CadCli()
        {
            InitializeComponent();
        }

        string sexo;

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CadCli_Load(object sender, EventArgs e)
        {

        }

           

        private void radioBtnM_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnM.Checked)
            {
                sexo = "M" ;
            }
        }

        private void radioBtnF_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnF.Checked)
            {
                sexo = "F" ;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnConsultCli_Click(object sender, EventArgs e)
        {
            BLLCli bllcli = new BLLCli();
            DataTable dt = bllcli.SelecionarClienteCPF(txtCPFCli.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Cliente não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Nome = dt.Rows[0][1].ToString();
                txtNomeCli.Text = Nome;

                string Nasc = dt.Rows[0][2].ToString();
                txtDataCli.Text = Nasc;

                string DateCasa = dt.Rows[0][3].ToString();
                txtCasacli.Text = DateCasa;

                string Telefone = dt.Rows[0][4].ToString();
                txtTelCli.Text = Telefone;

                string CPF = dt.Rows[0][5].ToString();
                txtCPFCli.Text = CPF;

                string Sexo = dt.Rows[0][6].ToString();
                sexo = Sexo;

                string Email = dt.Rows[0][7].ToString();
                txtEmail.Text = Email;


                this.txtSenhaCli.Hide();
                this.label7.Hide();
                this.txtCPFCli.ReadOnly = true;
                this.txtDataCli.ReadOnly = true;
                this.txtNomeCli.ReadOnly = true;
            }
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            if (txtNomeCli.Text == "" || txtSenhaCli.Text == "" || txtCPFCli.Text == "" || txtCasacli.Text == "" || txtTelCli.Text == "" || txtDataCli.Text == "")
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                BLLCli bllcli = new BLLCli();
                bllcli.incluircli(txtNomeCli.Text, txtDataCli.Text, txtCasacli.Text, txtTelCli.Text, txtCPFCli.Text, sexo, txtEmail.Text, txtSenhaCli.Text);

                this.txtNomeCli.Clear();
                this.txtSenhaCli.Clear();
                this.txtEmail.Clear();
                this.txtCPFCli.Clear();
                this.txtDataCli.Clear();
                this.txtCasacli.Clear();
                this.txtTelCli.Clear();
            }
         }

        private void txtCPFven_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MostrarClientes FRM = new MostrarClientes();
            FRM.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtNomeCli.Clear();
            this.txtSenhaCli.Clear();
            this.txtEmail.Clear();
            this.txtCPFCli.Clear();
            this.txtDataCli.Clear();
            this.txtCasacli.Clear();
            this.txtTelCli.Clear();
            this.txtTelCli.Clear();
            this.txtNomeCli.ReadOnly = false;
            this.txtDataCli.ReadOnly = false;
            this.txtCPFCli.ReadOnly = false;
            this.txtSenhaCli.Show();
            this.label7.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (txtNomeCli.Text == "" || txtCPFCli.Text == "" || txtCasacli.Text == "" || txtTelCli.Text == "" || txtDataCli.Text == "")
            {
                MessageBox.Show("Faça uma consulta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                BLLCli bllcli = new BLLCli();
                bllcli.AtualizaCliente(txtCasacli.Text, txtTelCli.Text, txtEmail.Text, txtCPFCli.Text);

                this.txtNomeCli.Clear();
                this.txtSenhaCli.Clear();
                this.txtEmail.Clear();
                this.txtCPFCli.Clear();
                this.txtDataCli.Clear();
                this.txtCasacli.Clear();
                this.txtTelCli.Clear();
                this.txtNomeCli.ReadOnly = false;
                this.txtDataCli.ReadOnly = false;
                this.txtCPFCli.ReadOnly = false;
                this.txtSenhaCli.Show();
            }
        }
        //gerir relatorio de todos os clientes
        //fazer consulta no form de cadastro
        //desabilitar itens inalteraveis

    }
}
