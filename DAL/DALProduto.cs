﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelo;
using System.Data;


namespace DAL
{
    public class DALProduto
    {
        private DALConexao conexao;

        public DALProduto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloProduto modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into Produto (pro_nome, pro_descricao, pro_foto,  pro_valorpago, pro_valorvenda, pro_qtde, umed_cod, cat_cod, scat_cod) "+
            "values (@nome, @descricao, @foto, @valorpago, @valorvenda, @qtde, @undmedcod, @catcod, @scatcod); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.ProNome);
            cmd.Parameters.AddWithValue("@descricao", modelo.ProDescricao);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (modelo.ProFoto == null)
            {
                //cmd.Parameters.AddWithValue("@pro_foto", DBNull.Value);
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                //cmd.Parameters.AddWithValue("@pro_foto", obj.pro_foto);
                cmd.Parameters["@foto"].Value = modelo.ProFoto;
            }
            cmd.Parameters.AddWithValue("@valorpago", modelo.ProValorPago);
            cmd.Parameters.AddWithValue("@valorvenda", modelo.ProValorVenda);
            cmd.Parameters.AddWithValue("@qtde", modelo.ProQtde);
            cmd.Parameters.AddWithValue("@undmedcod", modelo.UmedCod);
            cmd.Parameters.AddWithValue("@catcod", modelo.CatCod);
            cmd.Parameters.AddWithValue("@scatcod", modelo.ScatCod);
            conexao.Conectar();
            modelo.ProCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from Produto where (pro_cod) = (@codigo)";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloProduto modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE Produto SET pro_nome = (@nome), pro_descricao = (@descricao), "+
                "pro_foto = (@foto), pro_valorpago = (@valorpago), pro_valorvenda = (@valorvenda), "+
                "pro_qtde = (@qtde), umed_cod = (@undmedcod), cat_cod = (@catcod), "+
                "scat_cod = (@scatcod) WHERE pro_cod = (@codigo) ";
            cmd.Parameters.AddWithValue("@nome", modelo.ProNome);
            cmd.Parameters.AddWithValue("@descricao", modelo.ProDescricao);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (modelo.ProFoto == null)
            {
                //cmd.Parameters.AddWithValue("@foto", DBNull.Value);
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                //cmd.Parameters.AddWithValue("@foto", obj.pro_foto);
                cmd.Parameters["@foto"].Value = modelo.ProFoto;
            }
            cmd.Parameters.AddWithValue("@valorpago", modelo.ProValorPago);
            cmd.Parameters.AddWithValue("@valorvenda", modelo.ProValorVenda);
            cmd.Parameters.AddWithValue("@qtde", modelo.ProQtde);
            cmd.Parameters.AddWithValue("@undmedcod", modelo.UmedCod);
            cmd.Parameters.AddWithValue("@catcod", modelo.CatCod);
            cmd.Parameters.AddWithValue("@scatcod", modelo.ScatCod);
            cmd.Parameters.AddWithValue("@codigo", modelo.ProCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select pro_cod, pro_nome, pro_descricao, pro_valorvenda, pro_qtde, c.cat_nome, s.scat_nome, u.umed_nome"+ 
                                                    " from Produto p"+ 
                                                    " LEFT JOIN undmedida u ON u.umed_cod = p.umed_cod"+
                                                    " LEFT JOIN categoria c ON c.cat_cod = p.cat_cod"+
                                                    " LEFT JOIN subcategoria s ON s.scat_cod = p.scat_cod "+
                                                    "where pro_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            ModeloProduto modelo = new ModeloProduto();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from Produto where (pro_cod) =" + codigo.ToString();
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ProCod = Convert.ToInt32(registro["pro_cod"]);
                modelo.ProNome = Convert.ToString(registro["pro_nome"]);
                modelo.ProDescricao = Convert.ToString(registro["pro_descricao"]);
                try
                {
                    modelo.ProFoto = (byte[])registro["pro_foto"];

                }
                catch { }
                modelo.ProValorPago = Convert.ToDouble(registro["pro_valorpago"]);
                modelo.ProValorVenda = Convert.ToDouble(registro["pro_valorvenda"]);
                modelo.ProQtde = Convert.ToInt32(registro["pro_qtde"]);
                modelo.UmedCod = Convert.ToInt32(registro["umed_cod"]);
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
                modelo.ScatCod = Convert.ToInt32(registro["scat_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
