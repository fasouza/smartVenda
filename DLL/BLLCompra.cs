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
    public class BLLCompra
    {
        private DALConexao conexao;
        public BLLCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCompra obj)
        {
            if (obj.ComData.ToString() == "")
            {
                throw new Exception("A data da compra é obrigatória");
            }

            if (obj.ComNfiscal < 0)
            {
                throw new Exception("O número de nota fiscal é obrigatório");
            }

            if (obj.ComTotal <= 0)
            {
                throw new Exception("O valor da compra é obrigatório");
            }

           if (obj.ComStatus.ToString().Length < 0)
            {
                throw new Exception("O status da compra é obrigatório");
            }

            //if (obj.ForCod <= 0)
            //{
            //    throw new Exception("O fornecedor da compra é obrigatório");
            //}

            if (obj.TpaCod < 0)
            {
                throw new Exception("O tipo de pagamento é obrigatório");
            }
            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Incluir(obj);
        }

        public void Excluir(int codigo)
        {
            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Excluir(codigo);
        }

        public void Alterar(ModeloCompra obj)
        {
            if (obj.ComData.ToString() == "")
            {
                throw new Exception("A data da compra é obrigatória");
            }

            if (obj.ComNfiscal < 0)
            {
                throw new Exception("O número de nota fiscal é obrigatório");
            }

            if (obj.ComTotal <= 0)
            {
                throw new Exception("O valor da compra é obrigatório");
            }

            if (obj.ComStatus.ToString().Length < 0)
            {
                throw new Exception("O status da compra é obrigatório");
            }

            if (obj.ForCod <= 0)
            {
                throw new Exception("O fornecedor da compra é obrigatório");
            }

            if (obj.TpaCod < 0)
            {
                throw new Exception("O tipo de pagamento é obrigatório");
            }

            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Alterar(obj);
        }

        public DataTable Localizar(String valor)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.CarregaModeloCompra(codigo);
        }
    }
}
