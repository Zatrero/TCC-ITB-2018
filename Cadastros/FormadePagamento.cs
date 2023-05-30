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
    public partial class Forma_de_Pagamento : Form
    {
        public Forma_de_Pagamento()
        {
            InitializeComponent();
        }

        BLLForma forma = new BLLForma();        

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtAlfredo.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            forma = new BLLForma();
            forma.incluirforma(txtAlfredo.Text);
        }
    }
}
