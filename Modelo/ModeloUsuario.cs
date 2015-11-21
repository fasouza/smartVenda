using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUsuario
    {
        public ModeloUsuario()
        {
            this.UsuCod     = 0;
            this.UsuNome    = "";
            this.UsuCpf     = "";
            this.UsuTipo    = "";
            this.UsuStatus  = "";
            this.UsuLogin   = "";
            this.UsuSenha   = "";
            
        }

        public ModeloUsuario(int usu_cod, string usu_nome, string usu_cpf, string usu_tipo, string usu_status, string usu_login, string usu_senha)
        {
            this.UsuCod     = usu_cod;
            this.UsuNome    = usu_nome;
            this.UsuCpf     = usu_cpf;
            this.UsuTipo    = usu_tipo;
            this.UsuStatus  = usu_status;
            this.UsuLogin   = usu_login;
            this.UsuSenha   = usu_senha;

        }


        private int usu_cod;
        public int UsuCod
        {
            get { return this.usu_cod; }
            set { this.usu_cod = value; }
        }

        private string usu_nome;
        public string UsuNome
        {
            get { return this.usu_nome; }
            set { this.usu_nome = value; }
        }

        private string usu_cpf;
        public string UsuCpf
        {
            get { return this.usu_cpf; }
            set { this.usu_cpf = value; }
        }

        private string usu_tipo;
        public string UsuTipo
        {
            get { return this.usu_tipo; }
            set { this.usu_tipo = value; }
        }

        private string usu_status;
        public string UsuStatus
        {
            get { return this.usu_status; }
            set { this.usu_status = value; }
        }

        private string usu_login;
        public string UsuLogin
        {
            get { return this.usu_login; }
            set { this.usu_login = value; }
        }


        private string usu_senha;
        public string UsuSenha
        {
            get { return this.usu_senha; }
            set { this.usu_senha = value; }
        }

    }
}
