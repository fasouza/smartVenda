using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloFornecedor
    {

        //construtor
        public ModeloFornecedor()
        {
            this.ForCod         = 0;
            this.ForNome        = "";
            this.ForRSocial     = "";
            this.ForIe          = "";
            this.For_CNPJ       = "";
            this.ForCep         = "";
            this.ForEndereco    = "";
            this.ForBairro      = "";
            this.ForFone        = "";
            this.ForCel         = "";
            this.ForEmail       = "";
            this.ForEndNumero   = "";
            this.ForCidade      = "";
            this.ForEstado      = "";
            
        }

        public ModeloFornecedor(int for_cod, String for_nome, String for_rsocial, String for_ie, String for_cnpj, String for_cep,
                                String for_endereco, String for_bairro, String for_fone, String for_cel, String for_email, 
                                String for_endnumero, String for_cidade, String for_estado)
        {
            this.ForCod         = for_cod;
            this.ForNome        = for_nome;
            this.ForRSocial     = for_rsocial;
            this.ForIe          = for_ie;
            this.For_CNPJ       = for_cnpj;
            this.ForCep         = for_cep;
            this.ForEndereco    = for_endereco;
            this.ForBairro      = for_bairro;
            this.ForFone        = for_fone;
            this.ForCel         = for_cel;
            this.ForEmail       = for_email;
            this.ForEndNumero   = for_endnumero;
            this.ForCidade      = for_cidade;
            this.ForEstado      = for_estado;

        }

        private int for_cod;
        public int ForCod
        {
            get { return this.for_cod; }
            set { this.for_cod = value; }
        }

        private String for_nome;
        public String ForNome
        {
            get { return this.for_nome; }
            set { this.for_nome = value; }
        }

        private String for_rsocial;
        public String ForRSocial
        {
            get { return this.for_rsocial; }
            set { this.for_rsocial = value; }
        }

        private String for_ie;
        public String ForIe
        {
            get { return this.for_ie; }
            set { this.for_ie = value; }
        }

        private String for_cnpj;
        public String For_CNPJ
        {
            get { return this.for_cnpj; }
            set { this.for_cnpj = value; }
        }

        private String for_cep;
        public String ForCep
        {
            get { return this.for_cep; }
            set { this.for_cep = value; }
        }      
        
        private String for_endereco;
        public String ForEndereco
        {
            get { return this.for_endereco; }
            set { this.for_endereco = value; }
        }

        private String for_bairro;
        public String ForBairro
        {
            get { return this.for_bairro; }
            set { this.for_bairro = value; }
        }

        private String for_fone;
        public String ForFone
        {
            get { return this.for_fone; }
            set { this.for_fone = value; }
        }

        private String for_cel;
        public String ForCel
        {
            get { return this.for_cel; }
            set { this.for_cel = value; }
        }

        private String for_email;
        public String ForEmail
        {
            get { return this.for_email; }
            set { this.for_email = value; }
        }

        private String for_endnumero;
        public String ForEndNumero
        {
            get { return this.for_endnumero; }
            set { this.for_endnumero = value; }
        }

        private String for_cidade;
        public String ForCidade
        {
            get { return this.for_cidade; }
            set { this.for_cidade = value; }
        }

        private String for_estado;
        public String ForEstado
        {
            get { return this.for_estado; }
            set { this.for_estado = value; }
        }


    }
}
