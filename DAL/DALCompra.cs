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
    public class DALCompra
    {
        private DALConexao conexao;

        public DALCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into compra (com_data, com_nfiscal, com_total, com_nparcelas, com_status, for_cod, tpa_cod) "+
            "values ( @data, @notafiscal, @total, @nparcelas, @status, @codfornecedor, @codtipopagamento); select @@IDENTITY;";
                        
            cmd.Parameters.AddWithValue("@data", modelo.ComData);                    
            cmd.Parameters.AddWithValue("@notafiscal", modelo.ComNfiscal);
            cmd.Parameters.AddWithValue("@total", modelo.ComTotal);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.ComParcelas);
            cmd.Parameters.AddWithValue("@status", modelo.ComStatus);
            cmd.Parameters.AddWithValue("@codfornecedor", modelo.ForCod);
            cmd.Parameters.AddWithValue("@codtipopagamento", modelo.TpaCod);

            conexao.Conectar();
            modelo.ComCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from compra where (com_cod) = (@codigo)";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE compra SET com_cod = @codigo , com_data = @data, com_nfiscal = @notafiscal, com_total = @total ,"+
                              "com_nparcelas = @nparcelas, com_status = @status, for_cod = @codfornecedor, tpa_cod = @codtipopagamento)  WHERE com_cod = (@codigo) ";
           
            cmd.Parameters.AddWithValue("@data", modelo.ComData);
            cmd.Parameters.AddWithValue("@notafiscal", modelo.ComNfiscal);
            cmd.Parameters.AddWithValue("@total", modelo.ComTotal);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.ComParcelas);
            cmd.Parameters.AddWithValue("@status", modelo.ComStatus);
            cmd.Parameters.AddWithValue("@codfornecedor", modelo.ForCod);
            cmd.Parameters.AddWithValue("@codtipopagamento", modelo.TpaCod);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT  c.*, f.for_rsocial, f.for_cnpj, f.for_cep, f.for_bairro, f.for_cidade, f.for_estado, f.for_endnumero, "+ 
                                                    "f.for_email, t.tpa_nome FROM compra c "+
                                                	"LEFT JOIN fornecedor f ON f.for_cod = c.for_cod "+
	                                                "LEFT JOIN tipopagamento t ON t.tpa_cod = c.tpa_cod "+
                                                    "WHERE c.com_status like '%"+ valor+"%'" , conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            ModeloCompra modelo = new ModeloCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM compra WHERE (com_nfiscal) =" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ComCod       = Convert.ToInt32(registro["com_cod"]);
                modelo.ComData      = Convert.ToString(registro["com_data"]);
                modelo.ComNfiscal   = Convert.ToInt32(registro["com_nfiscal"]);                
                modelo.ComTotal     = Convert.ToDecimal(registro["com_total"]);
                modelo.ComParcelas  = Convert.ToInt32(registro["com_nparcelas"]);
                modelo.ComStatus    = Convert.ToString(registro["com_status"]);
                modelo.ForCod       = Convert.ToInt32(registro["for_cod"]);
                modelo.TpaCod       = Convert.ToInt32(registro["tpa_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
