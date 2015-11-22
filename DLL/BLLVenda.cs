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

        //metodo incluir
        public void Incluir(ModeloVenda modelo)
        {
            /*if (modelo.CatNome.Trim().Length == 0)//nome categoria obrigatorio
            {
                throw new Exception("O nome da categoria é obrigatório");
            }*/
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DALVenda DALobj = new DALVenda(conexao); //utiliza objeto de conexao
            DALobj.Incluir(modelo);
        }

        //metodo alterar
        public void Alterar(ModeloVenda modelo)
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

            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Alterar(modelo);
        }

        //metodo exclir
        public void Excluir(int codigo)
        {
            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Excluir(codigo);
        }

        //metodo localizar
        public DataTable Localizar(string cliente)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.Localizar(cliente);
        }

        //metodo carrega categoria
        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.CarregaModeloVenda(codigo);
        }
    }
}
