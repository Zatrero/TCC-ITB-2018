using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casamento
{
    public partial class MostarEstoque : Form
    {
        public MostarEstoque()
        {
            InitializeComponent();
        }

        private void MostarEstoque_Load(object sender, EventArgs e)
        {
            BLL.BLLEstoque bllest = new BLL.BLLEstoque();
            bllest.buscarEstoque(dataGridView1);
        }
    }
}
