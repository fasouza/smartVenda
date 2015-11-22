using System;
using Modelo;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALVenda
    {
        private DALConexao conexao;

        public DALVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        //metodo incluir registro
        public void Incluir(ModeloVenda modelo)
        {
            SqlCommand cmd = new SqlCommand(); //comando de conexao
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into venda (ven_nfiscal, ven_total, ven_nparcelas, ven_status, cli_cod, tpa_cod) " +
                "values (@nfiscal, @total, @nparcelas, @status, @clicod, @tpacod); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nfiscal", modelo.VenNfiscal);
            cmd.Parameters.AddWithValue("@total", modelo.VenTotal);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.VenNparcelas);
            cmd.Parameters.AddWithValue("@status", modelo.VenStatus);
            cmd.Parameters.AddWithValue("@clicod", modelo.CliCod);
            cmd.Parameters.AddWithValue("@tpacod", modelo.TpaCod);

            conexao.Conectar();
            modelo.VenCod = Convert.ToInt32(cmd.ExecuteScalar());//retorna parametro(poucos)
            conexao.Desconectar();
        }

        //metodo alterar registro
        public void Alterar(ModeloVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update venda set ven_nfiscal = @nfiscal, ven_total = @total, ven_nparcelas = @nparcelas, ven_status = @status, cli_cod = @clicod, tpa_cod = @tpacod where ven_cod = @codigo;";
            cmd.Parameters.AddWithValue("@nfiscal", modelo.VenNfiscal);
            cmd.Parameters.AddWithValue("@total", modelo.VenTotal);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.VenNparcelas);
            cmd.Parameters.AddWithValue("@status", modelo.VenStatus);
            cmd.Parameters.AddWithValue("@clicod", modelo.CliCod);
            cmd.Parameters.AddWithValue("@tpacod", modelo.TpaCod);
            cmd.Parameters.AddWithValue("@codigo", modelo.VenCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar(); //desconectar
        }

        //metodo excluir registro
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from venda where ven_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();//não retorna parametro algum
            conexao.Desconectar();
        }

        //metodo localizar
        public DataTable Localizar(string cliente)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select venda.*, cliente.cli_nome from venda inner join cliente on (venda.cli_cod = cliente.cli_cod) where cliente.cli_nome like '%" + cliente + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //pegar informações e preencher objeto do tipo venda
        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            ModeloVenda modelo = new ModeloVenda();
            SqlCommand cmd = new SqlCommand(); //comando
            cmd.Connection = conexao.ObjetoConexao; //define conexao
            cmd.CommandText = "select * from venda where ven_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);//adicionar parametro 
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();//executa comando Reader(retorna varios registro do banco)

            if (registro.HasRows)//se existir dados
            {
                registro.Read();//retorna os dados do banco
                modelo.VenCod = Convert.ToInt32(registro["ven_cod"]);
                modelo.VenData = Convert.ToDateTime(registro["ven_data"]);
                modelo.VenNfiscal = Convert.ToInt32(registro["ven_nfiscal"]);
                modelo.VenTotal = Convert.ToDouble(registro["ven_total"]);
                modelo.VenNparcelas = Convert.ToInt32(registro["ven_nparcelas"]);
                modelo.VenStatus = Convert.ToString(registro["ven_status"]);
                modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);

            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
