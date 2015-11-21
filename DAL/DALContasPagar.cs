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

       public class DALContasPagar
    {
        private DALConexao conexao;

        public DALContasPagar(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloContasPagar modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into conta_apagar (descricao,data_vencimento,data_pagamento,status,valor) values"+
                              "(@descricao,@vencimento,@pagamento,@status,@valor); select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@descricao", modelo.CPDescricao);
            cmd.Parameters.AddWithValue("@vencimento", modelo.CPVencimento);
            cmd.Parameters.AddWithValue("@pagamento", modelo.CPPagamento);
            cmd.Parameters.AddWithValue("@status", modelo.CPStatus);
            cmd.Parameters.AddWithValue("@valor", modelo.CPValor);

            conexao.Conectar();
            modelo.CPCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from conta_apagar where apagar_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloContasPagar modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE conta_apagar SET descricao = (@descricao), data_vencimento = (@vencimento), data_pagamento = (@pagamento), status = (@status), valor =(@valor) where apagar_cod = (@codigo)";

            cmd.Parameters.AddWithValue("@descricao", modelo.CPDescricao);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from conta_apagar where descricao like '%" + valor + "%'  ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;


        }

        public ModeloContasPagar CarregaModeloContasPagar(int codigo)
        {
            ModeloContasPagar modelo = new ModeloContasPagar();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from conta_apagar where cli_cod =" + codigo.ToString();
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();

                modelo.CPCod       = Convert.ToInt32(registro["apagar_cod"]);
                modelo.CPDescricao      = Convert.ToString(registro["descricao"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public ModeloContasPagar CarregaModeloContasPagar(String cpfcnpj)
        {
            ModeloContasPagar modelo = new ModeloContasPagar();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from conta_apagar where cli_cpfcnpj = @cpfcnpj";
            cmd.Parameters.AddWithValue("@cpfcnpj", cpfcnpj);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CPCod = Convert.ToInt32(registro["apagar_cod"]);
                modelo.CPDescricao = Convert.ToString(registro["descricao"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
