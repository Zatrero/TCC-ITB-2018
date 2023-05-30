using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using System.Windows.Forms;

namespace BLL
{
    public class BLLFunci
    {
        Funcionario funcionario = new Funcionario();
        DAOFu daofu = new DAOFu();

        public void incluirfu(string Nome, string CPF, string RG, string CEP, string Cidade, string Bairro, string Logradouro, int Numero, string Complemento,string UF, string Sexo, string Email, double Salario, string Cargo)
        {
            funcionario = new DAO.Funcionario();
            funcionario.Nome = Nome;
            funcionario.CPF = CPF;
            funcionario.RG = RG;
            funcionario.CEP = CEP;
            funcionario.Cidade = Cidade;
            funcionario.Bairro = Bairro;
            funcionario.Logradouro = Logradouro;
            funcionario.Numero = Numero;
            funcionario.Complemento = Complemento;
            funcionario.UF = UF;
            funcionario.Sexo = Sexo;
            funcionario.Email = Email;
            funcionario.Salario = Salario;
            funcionario.Cargo = Cargo;            

            daofu = new DAO.DAOFu();
            daofu.inserirfunc(funcionario);
        }

        public DataTable SelecionarFun(string CPF)
        {
            return daofu.ConsultarFuncionario(CPF);
        }

        public void BuscarFuncionariogrid(DataGridView dgv)
        {
            DAOFu daofu = new DAOFu();
            dgv.DataSource = daofu.BuscarFuncionario();
        }

        public void atualizafuncio(string Nome, string CEP, string Cidade, string Bairro, string Logradouro, int Numero, string Complemento, string UF, string Email, double Salario, string Cargo)
        {
            funcionario = new DAO.Funcionario();
            funcionario.Nome = Nome;
            funcionario.CEP = CEP;
            funcionario.Cidade = Cidade;
            funcionario.Bairro = Bairro;
            funcionario.Logradouro = Logradouro;
            funcionario.Numero = Numero;
            funcionario.Complemento = Complemento;
            funcionario.UF = UF;
            funcionario.Email = Email;
            funcionario.Salario = Salario;
            funcionario.Cargo = Cargo;

            daofu = new DAO.DAOFu();
            daofu.AtualizarFuncio (funcionario);
        }







    }

}
