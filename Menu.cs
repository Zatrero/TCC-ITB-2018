using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Casamento
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //Login log = new Login();
            //LblUser.Text = log.user.ToString();
            
            
        }

        private void btnConsultarFunc_Click(object sender, EventArgs e)
        {
            Compra FRM = new Compra();
            FRM.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            CadProd FRM = new CadProd();
            FRM.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            CadCli FRM = new CadCli();
            FRM.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            Venda FRM = new Venda();
            FRM.Show();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            CadForn FRM = new CadForn();
            FRM.Show();
        }

        private void btnFuncionário_Click(object sender, EventArgs e)
        {
            CadFuncio FRM = new CadFuncio();
            FRM.Show();
        }

        private void btnConsultarFunc_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
