using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class BLLNivelAcesso
    {
        public void InserirUsuario(string usu,string senha,string nlvacesso,string status,int fk_func)
        {
            NivelAcesso nlv = new NivelAcesso();
            nlv.usuariologin = usu;
            nlv.senhalogin = senha;
            nlv.nivelacesso = nlvacesso;
            nlv.status = status;
            nlv.fk_funcionario = fk_func;


            DAONivelAcesso dao = new DAONivelAcesso();
            dao.inserirnivelacesso(nlv);
        }


        public DataTable SelecionarLogin(string usu, string sen)
        {
            DAONivelAcesso dao = new DAONivelAcesso();
            return dao.buscarLogin(usu, sen);
        }

        public void AtualizarSenha (string usu, string senha,string status)
        {
            NivelAcesso nlv = new NivelAcesso();
            nlv.usuariologin = usu;
            nlv.senhalogin = senha;
            nlv.status = status;
           
            DAONivelAcesso dao = new DAONivelAcesso();
            dao.atualizarSenha(nlv);
        }


        public Funcionario pegardados(int id)
        {
            DAONivelAcesso dao = new DAONivelAcesso();
            return dao.pegardados(id);
        }
       
    }
}
