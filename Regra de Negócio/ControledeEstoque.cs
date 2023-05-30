using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Casamento
{
    public partial class ControledeEstoque : Form
    {
        public ControledeEstoque()
        {
            InitializeComponent();
        }

        public string produto;

        private void ControledeEstoque_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            BLLEstoque bllest = new BLLEstoque();
            if (txtConsultProd.Text == ""|| txtQuantProd.Text=="")
            {
                MessageBox.Show("Preencha os campos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bllest.incluirestoque(int.Parse(txtCodEst.Text),int.Parse(txtQuantProd.Text),int.Parse(txtestmin.Text));
                this.txtCodEst.Clear();
                this.txtConsultProd.Clear();
                this.txtQuantProd.Clear();
                this.txtestmin.Clear();
                this.txtCodEst.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mostrar_Catalogo m = new Mostrar_Catalogo();
            m.ShowDialog();
            txtCodEst.Focus();
            produto = m.prod.ToString();
            txtCodEst.Text = produto;
        }

        private void btnConsuEst_Click(object sender, EventArgs e)
        {
            BLLEstoque bllest = new BLLEstoque();

            DataTable dt = bllest.SelecionarProd(int.Parse(txtCodEst.Text));

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Produto invalido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nome = dt.Rows[0][2].ToString();
                txtConsultProd.Text = nome; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostarEstoque FRM = new MostarEstoque();
            FRM.Show();
        }
    }
}
