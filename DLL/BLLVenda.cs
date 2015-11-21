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
   public class BLLVenda
    {
        private DALConexao conexao;
        public BLLVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloVenda obj)
        {
            if (obj.VenData.ToString() == "")
            {
                throw new Exception("A data da venda é obrigatória");
            }

            if (obj.VenNfiscal < 0)
            {
                throw new Exception("O número de nota fiscal é obrigatório");
            }

            if (obj.VenTotal <= 0)
            {
                throw new Exception("O valor da venda é obrigatório");
            }

           if (obj.VenStatus.ToString().Length < 0)
            {
                throw new Exception("O status da venda é obrigatório");
            }

            if (obj.CliCod <= 0)
            {
                throw new Exception("O cliente da venda é obrigatório");
            }

            if (obj.TpaCod < 0)
            {
                throw new Exception("O tipo de pagamento é obrigatório");
            }
            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Incluir(obj);
        }

        public void Excluir(int codigo)
        {
            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Excluir(codigo);
        }

        public void Alterar(ModeloVenda obj)
        {
            if (obj.VenData.ToString() == "")
            {
                throw new Exception("A data da venda é obrigatória");
            }

            if (obj.VenNfiscal < 0)
            {
                throw new Exception("O número de nota fiscal é obrigatório");
            }

            if (obj.VenTotal <= 0)
            {
                throw new Exception("O valor da venda é obrigatório");
            }

            if (obj.VenStatus.ToString().Length < 0)
            {
                throw new Exception("O status da venda é obrigatório");
            }

            if (obj.CliCod <= 0)
            {
                throw new Exception("O cliente da venda é obrigatório");
            }

            if (obj.TpaCod < 0)
            {
                throw new Exception("O tipo de pagamento é obrigatório");
            }

            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Alterar(obj);
        }

        public DataTable Localizar(String valor)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.CarregaModeloVenda(codigo);
        }
    }
}
