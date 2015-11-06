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
    public class BLLFornecedor
    {
         private DALConexao conexao;
        public BLLFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor obj)
        {
            if (obj.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do fornecedor é obrigatório");
            }

            if (obj.ForRSocial.Trim().Length == 0)
            {
                throw new Exception("A razão social do fornecedor é obrigatória");
            }

            if (obj.ForIe.Trim().Length == 0)
            {
                throw new Exception("A inscrição estadual é obrigatória");
            }

            if (obj.For_CNPJ.Trim().Length <= 0)
            {
                throw new Exception("O CNPJ do fornecedor é obrigatório");
            }

            if (obj.ForCep.Trim().Length <= 0)
            {
                throw new Exception("O CEP do fornecedor é obrigatório");
            }

            if (obj.ForEndereco.Trim().Length <= 0)
            {
                throw new Exception("O endereço do fornecedor é obrigatório");
            }

            if (obj.ForBairro.Trim().Length <= 0)
            {
                throw new Exception("O bairro do fornecedoe é obrigatório");
            }
            if (obj.ForFone.Trim().Length <= 0 || obj.ForCel.Trim().Length <=0)
            {
                throw new Exception("Pelo menos um contato do fornecedor é obrigatório");
            }
            if (obj.ForEndNumero.Trim().Length <= 0)
            {
                throw new Exception("O Número do fornecedor é obrigatório");
            }
            if (obj.ForCidade.Trim().Length <= 0)
            {
                throw new Exception("A cidade do fornecedor é obrigatório");
            }
            if (obj.ForEstado.Trim().Length <= 0)
            {
                throw new Exception("O estado do fornecedor é obrigatório");
            }

            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Incluir(obj);
        }

        public void Excluir(int codigo)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Excluir(codigo);
        }

        public void Alterar(ModeloFornecedor obj)
        {
            if (obj.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do fornecedor é obrigatório");
            }

            if (obj.ForRSocial.Trim().Length == 0)
            {
                throw new Exception("A razão social do fornecedor é obrigatória");
            }

            if (obj.ForIe.Trim().Length == 0)
            {
                throw new Exception("A inscrição estadual é obrigatória");
            }

            if (obj.For_CNPJ.Trim().Length <= 0)
            {
                throw new Exception("O CNPJ do fornecedor é obrigatório");
            }

            if (obj.ForCep.Trim().Length <= 0)
            {
                throw new Exception("O CEP do fornecedor é obrigatório");
            }

            if (obj.ForEndereco.Trim().Length <= 0)
            {
                throw new Exception("O endereço do fornecedor é obrigatório");
            }

            if (obj.ForBairro.Trim().Length <= 0)
            {
                throw new Exception("O bairro do fornecedoe é obrigatório");
            }
            if (obj.ForFone.Trim().Length <= 0 || obj.ForCel.Trim().Length <= 0)
            {
                throw new Exception("Pelo menos um contato do fornecedor é obrigatório");
            }
            if (obj.ForEndNumero.Trim().Length <= 0)
            {
                throw new Exception("O Número do fornecedor é obrigatório");
            }
            if (obj.ForCidade.Trim().Length <= 0)
            {
                throw new Exception("A cidade do fornecedor é obrigatório");
            }
            if (obj.ForEstado.Trim().Length <= 0)
            {
                throw new Exception("O estado do fornecedor é obrigatório");
            }

            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Alterar(obj);
        }

        public DataTable Localizar(String valor)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.CarregaModeloFornecedor(codigo);
        }

    }
}
