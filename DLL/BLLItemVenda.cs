using DAL;
using Modelo;
using System.Data;

namespace BBL
{
    public class BLLItemVenda
    {
        private DALConexao conexao;

        public BLLItemVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItemVenda modelo)
        {
            /*if (modelo.CatNome.Trim().Length == 0)//nome categoria obrigatorio
            {
                throw new Exception("O nome da categoria é obrigatório");
            }*/
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DALItemVenda DALobj = new DALItemVenda(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloItemVenda modelo)
        {
            /*if (modelo.CatCod <= 0)//menor ou igual a 0
            {
                throw new Exception("O código da categoria é obrigatório");
            }
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório");
            }*/
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DALItemVenda DALobj = new DALItemVenda(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALItemVenda DALobj = new DALItemVenda(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(int valor)
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
