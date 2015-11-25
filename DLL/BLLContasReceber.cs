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
    public class BLLContasReceber
    {
        private DALConexao conexao;
        public BLLContasReceber(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloContasReceber obj)
        {

            if (obj.CPStatus.Trim().Length == 0)
            {
                throw new Exception("Status é obrigatorio");
            } 
            DALContasReceber DALobj = new DALContasReceber(conexao);
            DALobj.Incluir(obj);
        }

        public void Excluir(int codigo)
        {
            DALContasReceber DALobj = new DALContasReceber(conexao);
            DALobj.Excluir(codigo);
        }

        public void Alterar(ModeloContasReceber obj)
        {
            if (obj.CPStatus.Trim().Length == 0)
            {
                throw new Exception("Status é obrigatorio");
            } 
            DALContasReceber DALobj = new DALContasReceber(conexao);
            DALobj.Alterar(obj);
        }

        public DataTable Localizar(String valor)
        {
            DALContasReceber DALobj = new DALContasReceber(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloContasReceber CarregaModeloContasReceber(int codigo)
        {
            DALContasReceber DALobj = new DALContasReceber(conexao);
            return DALobj.CarregaModeloContasReceber(codigo);
        }
       
    }
}
