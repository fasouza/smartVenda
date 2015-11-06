using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    //classe com os metodos para manipulação com o banco. 
    public class DALCategoria
    {
        private DALConexao conexao;

        public DALCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        //metodo incluir registro
        public void Incluir(ModeloCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand(); //comando de conexao
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into categoria(cat_nome) values (@nome); select @@IDENTITY;"; 
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
            conexao.Conectar();
            modelo.CatCod = Convert.ToInt32(cmd.ExecuteScalar());//retorna parametro(poucos)
            conexao.Desconectar();
        }

        //metodo alterar registro
        public void Alterar(ModeloCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update categoria set cat_nome = @nome where cat_cod = @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.CatCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar(); //desconectar
        }

        //metodo excluir registro
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from categoria where cat_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();//não retorna parametro algum
            conexao.Desconectar();
        }

        //metodo localizar
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from categoria where cat_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //pegar informações e preencher objeto do tipo categoria
        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            ModeloCategoria modelo = new ModeloCategoria();
            SqlCommand cmd = new SqlCommand(); //comando
            cmd.Connection = conexao.ObjetoConexao; //define conexao
            cmd.CommandText = "select * from categoria where cat_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);//adicionar parametro 
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();//executa comando Reader(retorna varios registro do banco)
            
            if (registro.HasRows)//se existir dados
            {
                registro.Read();//retorna os dados do banco
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
                modelo.CatNome = Convert.ToString(registro["cat_nome"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
