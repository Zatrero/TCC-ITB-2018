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
using DAO;

namespace Casamento
{
    public partial class MostrarClientes : Form
    {
        public MostrarClientes()
        {
            InitializeComponent();
        }

        BLLCli bllcli = new BLLCli();

        private void MostrarClientes_Load(object sender, EventArgs e)
        {
            BLLCli bllcli = new BLLCli();
            bllcli.BuscarClientesgrid(dataGridView1);
        }

        private void btnSairCli_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
