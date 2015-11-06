using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BLL
{
    //classe responsavel por interagir com a interface. verifica a regra de negocio, chama a classe DAL e executa as operações no banco 
    public class BLLCategoria
    {
       private DALConexao conexao;
        public BLLCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }


        //metodo incluir
        public void Incluir(ModeloCategoria modelo)
        {
            if (modelo.CatNome.Trim().Length == 0)//nome categoria obrigatorio
            {
                throw new Exception("O nome da categoria é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();
            
            DALCategoria DALobj = new DALCategoria(conexao);//utiliza objeto de conexao
            DALobj.Incluir(modelo);
        }

        //metodo alterar
        public void Alterar(ModeloCategoria modelo)
        {
            if (modelo.CatCod <= 0)//menor ou igual a 0
            {
                throw new Exception("O código da categoria é obrigatório");
            }
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Alterar(modelo);
        }

        //metodo exclir
        public void Excluir(int codigo)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Excluir(codigo);
        }

        //metodo localizar
        public DataTable Localizar(String valor)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.Localizar(valor);
        }

        //metodo carrega categoria
        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.CarregaModeloCategoria(codigo);
        }
    }

    }

