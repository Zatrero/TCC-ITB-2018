using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class MostrarFuncionario : Form
    {
        public MostrarFuncionario()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MostrarFuncionario_Load(object sender, EventArgs e)
        {
            BLLFunci bllfun = new BLLFunci();
            bllfun.BuscarFuncionariogrid(dataGridView1);
            
        }

        private void btnSairCli_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
