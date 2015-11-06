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
   public class DALTipoPagamento
    {
        private DALConexao conexao;

        public DALTipoPagamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        //metodo incluir registro
        public void Incluir(ModeloTipoPagamento modelo)
        {
            SqlCommand cmd = new SqlCommand(); //comando de conexao
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into tipopagamento (tpa_nome) values (@nome); select @@IDENTITY;"; 
            cmd.Parameters.AddWithValue("@nome", modelo.TpaNome);
            conexao.Conectar();
            modelo.TpaCod = Convert.ToInt32(cmd.ExecuteScalar());//retorna parametro(poucos)
            conexao.Desconectar();
        }

        //metodo alterar registro
        public void Alterar(ModeloTipoPagamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update tipopagamento set tpa_nome = @nome where tpa_cod = @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.TpaNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.TpaCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar(); //desconectar
        }

        //metodo excluir registro
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from tipopagamento where tpa_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();//não retorna parametro algum
            conexao.Desconectar();
        }

        //metodo localizar
        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tipopagamento where tpa_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //pegar informações e preencher objeto do tipo de pagamento
        public ModeloTipoPagamento CarregaModeloTipoPagamento(int codigo)
        {
            ModeloTipoPagamento modelo = new ModeloTipoPagamento();
            SqlCommand cmd = new SqlCommand(); //comando
            cmd.Connection = conexao.ObjetoConexao; //define conexao
            cmd.CommandText = "select * from tipopagamento where tpa_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);//adicionar parametro 
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();//executa comando Reader(retorna varios registro do banco)
            
            if (registro.HasRows)//se existir dados
            {
                registro.Read();//retorna os dados do banco
                modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);
                modelo.TpaNome = Convert.ToString(registro["tpa_nome"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
