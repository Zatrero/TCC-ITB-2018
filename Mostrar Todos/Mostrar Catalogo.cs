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
    public partial class Mostrar_Catalogo : Form
    {
        int linha;
        public int prod;

        public Mostrar_Catalogo()
        {
            InitializeComponent();
           
        }

        private void Mostrar_Catalogo_Load(object sender, EventArgs e)
        {
            BLLProd bllpro = new BLLProd();
            bllpro.SelcionarTodosProdutos(dataGridView1);
        }

        private void btnSairCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp;
            temp = dataGridView1.Rows[linha].Cells[0].Value.ToString();
            Venda ve = new Venda();
            ve.produto = temp;
            prod = int.Parse(temp);
            this.Close();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linha = e.RowIndex;
            
        }
    }
}
