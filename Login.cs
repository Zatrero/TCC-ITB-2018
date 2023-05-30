using BLL;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string user;

        


        private void btnLog_Click(object sender, EventArgs e)
        {
            ClasseConexaoSql conexao = new ClasseConexaoSql();

            //string user = txtUsuario.Text;


            BLLNivelAcesso bll = new BLLNivelAcesso();
            DataTable t = bll.SelecionarLogin(txtUsuario.Text, txtSenha.Text);
            if (t.Rows.Count == 0)
            {
                MessageBox.Show("Usuário ou senhas inválidos");
                txtSenha.Clear();
                txtUsuario.Clear();

            }
            else
            {
                if (t.Rows.Count != 0)
                {
                    if (t.Rows[0][4].ToString() == "MUDAR_SENHA")
                    {
                        AtualizarSenha f = new AtualizarSenha();
                        f.txtUsuario.Text = txtUsuario.Text;
                        this.Visible = false;
                        f.ShowDialog();
                        this.Close();

                    }
                    else if (t.Rows[0][3].ToString() == "INATIVO")
                    {
                        MessageBox.Show("Não foi possível efetuar o login");
                    }
                    else
                    {
                        if (t.Rows[0][2].ToString() == "ADMINISTRADOR")
                        {
                            Menu f = new Casamento.Menu();
                            // f.lblfunc.Text = txtusu.Text;
                            // f.lblidusu.Text = t.Rows[0][4].ToString();
                            this.Visible = false;
                            user = txtUsuario.Text;
                            f.ShowDialog();
                            
                        }
                        else if (t.Rows[0][2].ToString() == "RECEPÇÃO")
                        {

                        }
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             
            if (this.checkBox1.Checked)
            {
                this.txtSenha.PasswordChar = '\0';
            }
            else
            {
                this.txtSenha.PasswordChar = '*';
            }

        
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}


    

     