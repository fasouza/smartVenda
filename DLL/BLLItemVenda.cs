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
    public class BLLItemVenda
    {
        private DALConexao conexao;
        public BLLItemVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItemVenda obj)
        {
            if (obj.ItemVendaQtd <= 0)
            {
                throw new Exception("O item da venda é obrigatório");
            }

            if (obj.ItemVendaValor <= 0)
            {
                throw new Exception("O valor do item da venda é obrigatório");
            }

            if (obj.VenCod <= 0)
            {
                throw new Exception("A venda é obrigatório");
            }

            if (obj.ProCod <= 0)
            {
                throw new Exception("O produto da venda é obrigatporio");
            }

           
            DALItemVenda DALobj = new DALItemVenda(conexao);
            DALobj.Incluir(obj);
        }

        public void Excluir(int codigo)
        {
            DALItemVenda DALobj = new DALItemVenda(conexao);
            DALobj.Excluir(codigo);
        }

        public void Alterar(ModeloItemVenda obj)
        {
            if (obj.ItemVendaQtd <= 0)
            {
                throw new Exception("O item da venda é obrigatório");
            }

            if (obj.ItemVendaValor <= 0)
            {
                throw new Exception("O valor do item da venda é obrigatório");
            }

            if (obj.VenCod <= 0)
            {
                throw new Exception("A venda é obrigatório");
            }

            if (obj.ProCod <= 0)
            {
                throw new Exception("O produto da venda é obrigatporio");
            }


            DALItemVenda DALobj = new DALItemVenda(conexao);
            DALobj.Incluir(obj);
        }

        public DataTable Localizar(String valor)
        {
            DALItemVenda DALobj = new DALItemVenda(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloItemVenda CarregaModeloItemVenda(int codigo)
        {
            DALItemVenda DALobj = new DALItemVenda(conexao);
            return DALobj.CarregaModeloItemVenda(codigo);
        }

    }
}
