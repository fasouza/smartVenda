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
            cmd.CommandText = "insert into itensvenda (itemvenda_qtde, itemvenda_valor, ven_cod, pro_cod) values" +
                              "(@qtde, @valor, @vencod, @procod); select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@qtde", modelo.ItemVendaQtde);
            cmd.Parameters.AddWithValue("@valor", modelo.ItemVendaValor);
            cmd.Parameters.AddWithValue("@vencod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@procod", modelo.ProCod);

            conexao.Conectar();
            modelo.ItemVendaCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from itensvenda where itemvenda_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloItemVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE itensvenda SET itemvenda_qtde = (@qtde), itemvenda_valor = (@valor), ven_cod = (@ven_cod), pro_cod = (@pro_cod) "
                + "where itemvenda_cod = (@codigo)";

            cmd.Parameters.AddWithValue("@qtde", modelo.ItemVendaQtde);
            cmd.Parameters.AddWithValue("@valor", modelo.ItemVendaValor);
            cmd.Parameters.AddWithValue("@ven_cod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@pro_cod", modelo.ProCod);
            cmd.Parameters.AddWithValue("@codigo", modelo.ItemVendaCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(int valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select itensvenda.*, produto.pro_nome from itensvenda inner join produto on (produto.pro_cod = itensvenda.pro_cod) where ven_cod = " + valor, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloItemVenda CarregaModeloItemVenda(int codigo)
        {
            ModeloItemVenda modelo = new ModeloItemVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select itensvenda.*, produto.pro_nome from itensvenda inner join produto on (produto.pro_cod = itensvenda.pro_cod) where itemvenda_cod =" + codigo.ToString();
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();

                modelo.ItemVendaCod = Convert.ToInt32(registro["itemvenda_cod"]);
                modelo.ItemVendaQtde = Convert.ToDouble(registro["itemvenda_qtde"]);
                modelo.ItemVendaValor = Convert.ToDouble(registro["itemvenda_valor"]);
                modelo.VenCod = Convert.ToInt32(registro["ven_cod"]);
                modelo.ProCod = Convert.ToInt32(registro["pro_cod"]);
                modelo.ItemVendaProduto = registro["pro_nome"].ToString();
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
