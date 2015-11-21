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
    public class BLLContasPagar
    {
        private DALConexao conexao;
        public BLLContasPagar(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloContasPagar obj)
        {
            if (obj.CPDescricao.Trim().Length == 0)
            {
                throw new Exception("Descrição é obrigatorio");
            }
          
            DALContasPagar DALobj = new DALContasPagar(conexao);
            DALobj.Incluir(obj);
        }

        public void Excluir(int codigo)
        {
            DALContasPagar DALobj = new DALContasPagar(conexao);
            DALobj.Excluir(codigo);
        }

        public void Alterar(ModeloContasPagar obj)
        {
            if (obj.CPDescricao.Trim().Length == 0)
            {
                throw new Exception("Descrição é obrigatorio");
            }
    
            DALContasPagar DALobj = new DALContasPagar(conexao);
            DALobj.Alterar(obj);
        }

        public DataTable Localizar(String valor)
        {
            DALContasPagar DALobj = new DALContasPagar(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloContasPagar CarregaModeloContasPagar(int codigo)
        {
            DALContasPagar DALobj = new DALContasPagar(conexao);
            return DALobj.CarregaModeloContasPagar(codigo);
        }
       
    }
}
