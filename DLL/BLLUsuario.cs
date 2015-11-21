using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BBL
{
    public class BLLUsuario
    {
        private DALConexao conexao;
        
        public BLLUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUsuario obj)
        {
            if (obj.UsuNome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuário é obrigatório");
            }

            if (obj.UsuCpf.Trim().Length == 0)
            {
                throw new Exception("O CPF do usuário é obrigatório");
            }

            if (obj.UsuTipo.Trim().Length <= 0)
            {
                throw new Exception("O tipo de usuário é obrigatório");
            }

            if (obj.UsuStatus.Trim().Length <= 0)
            {
                throw new Exception("O status do usuário é obrigatório");
            }

            if (obj.UsuLogin.Trim().Length <= 0)
            {
                throw new Exception("O login do usuário é obrigatório");
            }

            if (obj.UsuSenha.Trim().Length <= 0)
            {
                throw new Exception("A senha do usuário é obrigatório");
            }            

            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Incluir(obj);
        }

        public void Excluir(int codigo)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Excluir(codigo);
        }

        public void Alterar(ModeloUsuario obj)
        {
            if (obj.UsuNome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuário é obrigatório");
            }

            if (obj.UsuCpf.Trim().Length == 0)
            {
                throw new Exception("O CPF do usuário é obrigatório");
            }

            if (obj.UsuTipo.Trim().Length <= 0)
            {
                throw new Exception("O tipo de usuário é obrigatório");
            }

            if (obj.UsuStatus.Trim().Length <= 0)
            {
                throw new Exception("O status do usuário é obrigatório");
            }

            if (obj.UsuLogin.Trim().Length <= 0)
            {
                throw new Exception("O login do usuário é obrigatório");
            }

            if (obj.UsuSenha.Trim().Length <= 0)
            {
                throw new Exception("A senha do usuário é obrigatório");
            }

            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Alterar(obj);
        }

        public DataTable Localizar(String valor)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.CarregaModeloUsuario(codigo);
        }


        public Boolean AutenticarUsuario(ModeloUsuario obj)
        {
           DALUsuario DALobj = new DALUsuario(conexao);
           return DALobj.AutenticarUsuario(obj);
        }

        public Boolean AlterarSenha(ModeloUsuario obj)
        { 
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.AlterarSenha(obj);
        }

        public Boolean VerificarCPFLogin(ModeloUsuario obj)
        {            
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.VerificarCPFLogin(obj);
        }        
    }
}
