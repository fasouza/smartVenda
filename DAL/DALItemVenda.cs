using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace DAL
{
    public class DALItemVenda
    {
         private DALConexao conexao;

        public DALItemVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItemVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into itensvenda (itemvenda_qtd, itemvenda_valor, ven_cod, pro_cod) "+
            "values ( @quantidade, @valor, @codvenda, @codproduto); select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@quantidade", modelo.ItemVendaQtd);
            cmd.Parameters.AddWithValue("@valor", modelo.ItemVendaValor);
            cmd.Parameters.AddWithValue("@codvenda", modelo.VenCod);
            cmd.Parameters.AddWithValue("@codproduto", modelo.ProCod);
           

            conexao.Conectar();
            modelo.ItemVendaCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from itensvenda where (itemvenda_cod) = (@codigo)";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloItemVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE compra SET itemvenda_qtd = (@quantidade), itemvenda_valor = (@valor), ven_cod = (@codvenda), pro_cod = (@codproduto)  WHERE itemvenda_cod = (@codigo) ";

            cmd.Parameters.AddWithValue("@quantidade", modelo.ItemVendaQtd);
            cmd.Parameters.AddWithValue("@valor", modelo.ItemVendaValor);
            cmd.Parameters.AddWithValue("@codvenda", modelo.VenCod);
            cmd.Parameters.AddWithValue("@codproduto", modelo.ProCod);
           

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM itensvenda i "+ 
                                                   "LEFT JOIN venda v ON v.ven_cod = i.ven_cod "+ 
                                                    "LEFT JOIN  produto p ON p.pro_cod = i.pro_cod "+  
                                                    "WHERE ven_nfiscal = '"+ valor+"'" , conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloItemVenda CarregaModeloItemVenda(int codigo)
        {
            ModeloItemVenda modelo = new ModeloItemVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM itensvenda WHERE (com_nfiscal) =" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ItemVendaQtd   = Convert.ToInt32(registro["itemvenda_qtd"]);
                modelo.ItemVendaValor = Convert.ToDecimal(registro["itemvenda_valor"]);
                modelo.VenCod         = Convert.ToInt32(registro["ven_cod"]);
                modelo.ProCod         = Convert.ToInt32(registro["pro_cod"]);
               
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
