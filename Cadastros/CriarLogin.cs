using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;
using BLL;

namespace Casamento
{
    public partial class CriarLogin : Form
    {

        public string status = "MUDAR_SENHA";

        public CriarLogin()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodfunc.Text != "")
                {
                    BLLNivelAcesso bll = new BLLNivelAcesso();
                    Funcionario func = bll.pegardados(Convert.ToInt32(txtCodfunc.Text));
                    txtnome.Text = func.Nome;
                    txtcpf.Text = func.CPF;
                    if (txtnome.Text == "")
                    {
                        MessageBox.Show("Funcionário não encontrado");
                    }
                    if (txtnome.Text.IndexOf(" ") == -1)
                    {
                        txtusuario.Text = txtnome.Text.Substring(0) + "_" + txtCodfunc.Text;
                    }
                    else
                    {
                        txtusuario.Text = txtnome.Text.Substring(0, txtnome.Text.IndexOf(" ")) + "_" + txtCodfunc.Text;
                    }

                    txtsenha.Text = "123456";
  
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbnlvacesso.Text =="")
                {
                    MessageBox.Show("Informe o nivel de acesso");
                }
                else
                {
                    BLLNivelAcesso bll = new BLLNivelAcesso();
                    bll.InserirUsuario(txtusuario.Text, txtsenha.Text, cbnlvacesso.Text, status, Convert.ToInt32(txtCodfunc.Text));
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbnlvacesso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

     
    }
}
