using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DAO;

namespace BLL
{
    public class BLLCli
    {
        Cliente cliente = new Cliente();
        DAOCliente daocl = new DAOCliente();

       
        //INSERE O CLIENTE
        public void incluircli(string Nome, string Nasc, string DateCasa , string Telefone, string CPF, string Sexo, string Email, string Senha )
        {
            cliente = new DAO.Cliente();
            cliente.Nome = Nome;
            cliente.DateCli = Nasc;
            cliente.DateCasa = DateCasa;
            cliente.Telefone = Telefone;
            cliente.CPF = CPF;
            cliente.Sexo = Sexo;
            cliente.Email = Email;
            cliente.Senha = Senha;

            daocl = new DAOCliente();
            daocl.inserircli(cliente);

        }

        public DataTable SelecionarClienteCPF(string CPF)
        {
            DAOCliente daocli = new DAOCliente();
            return daocli.buscarClienteId(CPF);

        }

        public void BuscarClientesgrid(DataGridView dgv)
        {
            DAOCliente daocli = new DAOCliente();
            dgv.DataSource = daocli.BuscarClientesDao();
        }

        public void AtualizaCliente(string DateCasa, string Telefone,string Email, string CPF)
        {
            cliente = new DAO.Cliente();
            cliente.DateCasa = DateCasa;
            cliente.Telefone = Telefone;
            cliente.Email = Email;
            cliente.CPF = CPF;

            daocl = new DAOCliente();
            daocl.AtualizarCli(cliente);

        }
    }
}
