using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL
{
    public class BLLCliente
    {
        private DALConexao conexao;
        public BLLCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente obj)
        {
            if (obj.CliNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }

            if (obj.CliCPF_CNPJ.Trim().Length == 0)
            {
                throw new Exception("O CNPJ/CPF é obrigatório");
            }

            if (obj.CliTipo.Trim().Length <= 0)
            {
                throw new Exception("O tipo de cliente é obrigatório");
            }

            if (obj.CliCep.Trim().Length <= 0)
            {
                throw new Exception("O CEP do cliente é obrigatório");
            }

            if (obj.CliEndereco.Trim().Length <= 0)
            {
                throw new Exception("O endereço do cliente é obrigatório");
            }

            if (obj.CliBairro.Trim().Length <= 0)
            {
                throw new Exception("O bairro do cliente é obrigatório");
            }
            if (obj.CliFone.Trim().Length <= 0 || obj.CliCel.Trim().Length <=0)
            {
                throw new Exception("Pelo menos um contato do cliente é obrigatório");
            }
            if (obj.CliEndNumero.Trim().Length <= 0)
            {
                throw new Exception("O Número resedencial do cliente é obrigatório");
            }
            if (obj.CliCidade.Trim().Length <= 0)
            {
                throw new Exception("A cidade do cliente é obrigatório");
            }
            if (obj.CliEstado.Trim().Length <= 0)
            {
                throw new Exception("O estado do cliente é obrigatório");
            }

            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Incluir(obj);
        }

        public void Excluir(int codigo)
        {
            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Excluir(codigo);
        }

        public void Alterar(ModeloCliente obj)
        {
            if (obj.CliNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }

            if (obj.CliCPF_CNPJ.Trim().Length == 0)
            {
                throw new Exception("O CNPJ/CPF é obrigatório");
            }

            if (obj.CliRG.Trim().Length <= 0)
            {
                throw new Exception("O RG do cliente é obrigatório");
            }

            if (obj.CliTipo.Trim().Length <= 0)
            {
                throw new Exception("O tipo de cliente é obrigatório");
            }

            if (obj.CliCep.Trim().Length <= 0)
            {
                throw new Exception("O CEP do cliente é obrigatório");
            }

            if (obj.CliEndereco.Trim().Length <= 0)
            {
                throw new Exception("O endereço do cliente é obrigatório");
            }

            if (obj.CliBairro.Trim().Length <= 0)
            {
                throw new Exception("O bairro do cliente é obrigatório");
            }
            if (obj.CliFone.Trim().Length <= 0 || obj.CliCel.Trim().Length <=0)
            {
                throw new Exception("Pelo menos um contato do cliente é obrigatório");
            }
            if (obj.CliEndNumero.Trim().Length <= 0)
            {
                throw new Exception("O Número resedencial do cliente é obrigatório");
            }
            if (obj.CliCidade.Trim().Length <= 0)
            {
                throw new Exception("A cidade do cliente é obrigatório");
            }
            if (obj.CliEstado.Trim().Length <= 0)
            {
                throw new Exception("O estado do cliente é obrigatório");
            }

            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Alterar(obj);
        }

        public DataTable Localizar(String valor)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.CarregaModeloCliente(codigo);
        }
       
    }
}
