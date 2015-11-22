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

       public class DALContasReceber
    {
        private DALConexao conexao;

        public DALContasReceber(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloContasReceber modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into conta_areceber (data_vencimento,data_pagamento,status,valor,cli_cod) values"+
                              "(@vencimento,@pagamento,@status,@valor,@cliente); select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@vencimento", modelo.CPVencimento);
            cmd.Parameters.AddWithValue("@pagamento", modelo.CPPagamento);
            cmd.Parameters.AddWithValue("@status", modelo.CPStatus);
            cmd.Parameters.AddWithValue("@valor", modelo.CPValor);
            cmd.Parameters.AddWithValue("@cliente", modelo.CPCliente);


            conexao.Conectar();
            modelo.CPCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from conta_areceber where areceber_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloContasReceber modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE conta_areceber SET  data_vencimento = (@vencimento), data_pagamento = (@pagamento), status = (@status), valor =(@valor) where areceber_cod = (@codigo)";

            cmd.Parameters.AddWithValue("@vencimento", modelo.CPVencimento);
            cmd.Parameters.AddWithValue("@pagamento", modelo.CPPagamento);
            cmd.Parameters.AddWithValue("@status", modelo.CPStatus);
            cmd.Parameters.AddWithValue("@valor", modelo.CPValor);
            cmd.Parameters.AddWithValue("@cliente", modelo.CPCliente); conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select areceber_cod, data_vencimento,cli_cod from conta_areceber where status !=  'pago' and descricao like '%" + valor + "%'  ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;


        }

        public ModeloContasReceber CarregaModeloContasReceber(int codigo)
        {
            ModeloContasReceber modelo = new ModeloContasReceber();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from conta_areceber where cli_cod =" + codigo.ToString();
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();

                modelo.CPCod       = Convert.ToInt32(registro["areceber_cod"]);
                modelo.CPDescricao      = Convert.ToString(registro["descricao"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public ModeloContasReceber CarregaModeloContasReceber(String cpfcnpj)
        {
            ModeloContasReceber modelo = new ModeloContasReceber();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from conta_areceber where cli_cpfcnpj = @cpfcnpj";
            cmd.Parameters.AddWithValue("@cpfcnpj", cpfcnpj);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CPCod = Convert.ToInt32(registro["areceber_cod"]);
                modelo.CPDescricao = Convert.ToString(registro["descricao"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
