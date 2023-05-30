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
    public partial class AtualizarSenha : Form
    {

        public string status="ATIVO";
        public AtualizarSenha()
        {
            InitializeComponent();
        }

     

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
           
                BLLNivelAcesso bllacess = new BLLNivelAcesso();
                bllacess.AtualizarSenha(txtUsuario.Text, txtSenha.Text, status);


           
        }
    }
}
