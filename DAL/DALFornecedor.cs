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
    public class DALFornecedor
    {
         private DALConexao conexao;

        public DALFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into fornecedor (for_nome, for_rsocial, for_ie, for_cnpj, for_cep, for_endereco," +
                              "for_bairro, for_fone, for_cel, for_email, for_endnumero, for_cidade, for_estado) values"+
                              "(@nome, @razao, @ie, @cnpj, @cep, @endereco, @bairro, @fone, @celular, @email, @numero,"+
                              "@cidade, @estado); select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@nome", modelo.ForNome);
            cmd.Parameters.AddWithValue("@razao", modelo.ForRSocial );                    
            cmd.Parameters.AddWithValue("@ie", modelo.ForIe);
            cmd.Parameters.AddWithValue("@cnpj", modelo.For_CNPJ);
            cmd.Parameters.AddWithValue("@cep", modelo.ForCep);
            cmd.Parameters.AddWithValue("@endereco", modelo.ForEndereco);
            cmd.Parameters.AddWithValue("@bairro", modelo.ForBairro);
            cmd.Parameters.AddWithValue("@fone", modelo.ForFone);
            cmd.Parameters.AddWithValue("@celular", modelo.ForCel);
            cmd.Parameters.AddWithValue("@email", modelo.ForEmail);
            cmd.Parameters.AddWithValue("@numero", modelo.ForEndNumero);
            cmd.Parameters.AddWithValue("@cidade", modelo.ForCidade);
            cmd.Parameters.AddWithValue("@estado", modelo.ForEstado);


            conexao.Conectar();
            modelo.ForCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from fornecedor where for_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloFornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE fornecedor SET for_nome = (@nome), for_rsocial = (@razao), for_ie = (@ie), for_cnpj = (@cnpj), "+
                                "for_cep = (@cep), for_endereco = (@endereco), for_bairro = (@bairro), for_fone = (@fone), "+
                                "for_cel = (@celular), for_email = (@email), for_endnumero = (@numero), for_cidade = (@cidade), "+
                                "for_estado = (@estado) where for_cod = (@codigo)";

            cmd.Parameters.AddWithValue("@nome", modelo.ForNome);
            cmd.Parameters.AddWithValue("@razao", modelo.ForRSocial);
            cmd.Parameters.AddWithValue("@ie", modelo.ForIe);
            cmd.Parameters.AddWithValue("@cnpj", modelo.For_CNPJ);
            cmd.Parameters.AddWithValue("@cep", modelo.ForCep);
            cmd.Parameters.AddWithValue("@endereco", modelo.ForEndereco);
            cmd.Parameters.AddWithValue("@bairro", modelo.ForBairro);
            cmd.Parameters.AddWithValue("@fone", modelo.ForFone);
            cmd.Parameters.AddWithValue("@celular", modelo.ForCel);
            cmd.Parameters.AddWithValue("@email", modelo.ForEmail);
            cmd.Parameters.AddWithValue("@numero", modelo.ForEndNumero);
            cmd.Parameters.AddWithValue("@cidade", modelo.ForCidade);
            cmd.Parameters.AddWithValue("@estado", modelo.ForEstado);
            cmd.Parameters.AddWithValue("@codigo", modelo.ForCod);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from fornecedor where for_nome like '%" + valor + "%' OR for_cnpj like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from fornecedor where for_cod =" + codigo.ToString();
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();

                modelo.ForCod       = Convert.ToInt32(registro["for_cod"]);
                modelo.ForNome      = Convert.ToString(registro["for_nome"]);
                modelo.ForRSocial  = Convert.ToString(registro["for_rsocial"]);
                modelo.ForIe        = Convert.ToString(registro["for_ie"]);
                modelo.For_CNPJ   = Convert.ToString(registro["for_cnpj"]);
                modelo.ForCep       = Convert.ToString(registro["for_cep"]);
                modelo.ForEndereco  = Convert.ToString(registro["for_endereco"]);
                modelo.ForBairro    = Convert.ToString(registro["for_bairro"]);
                modelo.ForFone      = Convert.ToString(registro["for_fone"]);
                modelo.ForCel       = Convert.ToString(registro["for_cel"]);
                modelo.ForEmail     = Convert.ToString(registro["for_email"]);
                modelo.ForEndNumero = Convert.ToString(registro["for_endnumero"]);
                modelo.ForCidade    = Convert.ToString(registro["for_cidade"]);
                modelo.ForEstado    = Convert.ToString(registro["for_estado"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public ModeloFornecedor CarregaModeloFornecedor(String cnpj)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from fornecedor where for_cnpj = @cnpj";
            cmd.Parameters.AddWithValue("@cnpj", cnpj);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();

                modelo.ForCod = Convert.ToInt32(registro["for_cod"]);
                modelo.ForNome = Convert.ToString(registro["for_nome"]);
                modelo.ForRSocial = Convert.ToString(registro["for_rsocial"]);
                modelo.ForIe = Convert.ToString(registro["for_ie"]);
                modelo.For_CNPJ = Convert.ToString(registro["for_cnpj"]);
                modelo.ForCep = Convert.ToString(registro["for_cep"]);
                modelo.ForEndereco = Convert.ToString(registro["for_endereco"]);
                modelo.ForBairro = Convert.ToString(registro["for_bairro"]);
                modelo.ForFone = Convert.ToString(registro["for_fone"]);
                modelo.ForCel = Convert.ToString(registro["for_cel"]);
                modelo.ForEmail = Convert.ToString(registro["for_email"]);
                modelo.ForEndNumero = Convert.ToString(registro["for_endnumero"]);
                modelo.ForCidade = Convert.ToString(registro["for_cidade"]);
                modelo.ForEstado = Convert.ToString(registro["for_estado"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
