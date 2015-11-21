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
   public class DALVenda
    {
         private DALConexao conexao;

        public DALVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into venda (ven_data, ven_nfiscal, ven_total, ven_nparcelas, ven_status, cli_cod, tpa_cod) "+
            "values ( @data, @notafiscal, @total, @nparcelas, @status, @codfornecedor, @codtipopagamento); select @@IDENTITY;";
                        
            cmd.Parameters.AddWithValue("@data", modelo.VenData);                    
            cmd.Parameters.AddWithValue("@notafiscal", modelo.VenNfiscal);
            cmd.Parameters.AddWithValue("@total", modelo.VenTotal);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.VenParcelas);
            cmd.Parameters.AddWithValue("@status", modelo.VenStatus);
            cmd.Parameters.AddWithValue("@codfornecedor", modelo.CliCod);
            cmd.Parameters.AddWithValue("@codtipopagamento", modelo.TpaCod);

            conexao.Conectar();
            modelo.VenCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "DELETE FROM venda WHERE (Ven_cod) = (@codigo)";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE venda SET ven_cod = @codigo , ven_data = @data, ven_nfiscal = @notafiscal, ven_total = @total ,"+
                              "ven_nparcelas = @nparcelas, ven_status = @status, for_cod = @codfornecedor, tpa_cod = @codtipopagamento)  WHERE ven_cod = (@codigo) ";
           
            cmd.Parameters.AddWithValue("@data", modelo.VenData);
            cmd.Parameters.AddWithValue("@notafiscal", modelo.VenNfiscal);
            cmd.Parameters.AddWithValue("@total", modelo.VenTotal);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.VenParcelas);
            cmd.Parameters.AddWithValue("@status", modelo.VenStatus);
            cmd.Parameters.AddWithValue("@codfornecedor", modelo.CliCod);
            cmd.Parameters.AddWithValue("@codtipopagamento", modelo.TpaCod);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM venda v "+ 
                                                    "LEFT JOIN cliente c on c.cli_cod = v.cli_cod "+
                                                    "LEFT JOIN tipopagamento t on t.tpa_cod = v.tpa_cod"+
                                                    "WHERE c.ven_status = '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            ModeloVenda modelo = new ModeloVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM venda WHERE (ven_nfiscal) =" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.VenCod       = Convert.ToInt32(registro["ven_cod"]);
                modelo.VenData      = Convert.ToDateTime(registro["ven_data"]);
                modelo.VenNfiscal   = Convert.ToInt32(registro["ven_nfiscal"]);                
                modelo.VenTotal     = Convert.ToDecimal(registro["ven_total"]);
                modelo.VenParcelas  = Convert.ToInt32(registro["ven_nparcelas"]);
                modelo.VenStatus    = Convert.ToString(registro["ven_status"]);
                modelo.CliCod       = Convert.ToInt32(registro["cli_cod"]);
                modelo.TpaCod       = Convert.ToInt32(registro["tpa_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
