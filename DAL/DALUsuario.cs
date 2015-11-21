using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DALUsuario
    {
       private DALConexao conexao;

        public DALUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable dados;
       
        public void Incluir(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into usuario (usu_nome, usu_cpf, usu_tipo, usu_status, usu_login, usu_senha) values"+
                              "(@nome, @cpf, @tipo, @status, @login, @senha); select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@nome", modelo.UsuNome);
            cmd.Parameters.AddWithValue("@cpf", modelo.UsuCpf);                    
            cmd.Parameters.AddWithValue("@tipo", modelo.UsuTipo);
            cmd.Parameters.AddWithValue("@status", modelo.UsuStatus);
            cmd.Parameters.AddWithValue("@login", modelo.UsuLogin);
            cmd.Parameters.AddWithValue("@senha", modelo.UsuSenha);
            

            conexao.Conectar();
            modelo.UsuCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from usuario where usu_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE usuario SET usu_nome = (@nome), usu_cpf = (@cpf) , usu_tipo = (@tipo), usu_status = (@status), usu_login = (@login), usu_senha = (@senha) WHERE usu_cod = @codigo";

            cmd.Parameters.AddWithValue("@nome", modelo.UsuNome);
            cmd.Parameters.AddWithValue("@cpf", modelo.UsuCpf);
            cmd.Parameters.AddWithValue("@tipo", modelo.UsuTipo);
            cmd.Parameters.AddWithValue("@status", modelo.UsuStatus);
            cmd.Parameters.AddWithValue("@login", modelo.UsuLogin);
            cmd.Parameters.AddWithValue("@senha", modelo.UsuSenha);
            
            cmd.Parameters.AddWithValue("@codigo", modelo.UsuCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from usuario where usu_cpf like '%" + valor + "%' or usu_nome like '%" + valor + "%' ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM usuario WHERE usu_cod =" + codigo.ToString();
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();

                modelo.UsuCod = Convert.ToInt32(registro["usu_cod"]);
                modelo.UsuNome = Convert.ToString(registro["usu_nome"]);
                modelo.UsuCpf = Convert.ToString(registro["usu_cpf"]);
                modelo.UsuTipo = Convert.ToString(registro["usu_tipo"]);
                modelo.UsuStatus = Convert.ToString(registro["usu_status"]);
                modelo.UsuLogin = Convert.ToString(registro["usu_login"]);
                modelo.UsuSenha = Convert.ToString(registro["usu_senha"]);

            }
            conexao.Desconectar();
            return modelo;
        }    

        public Boolean AutenticarUsuario(ModeloUsuario modelo)
        {          
          
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from usuario where usu_login = '" + modelo.UsuLogin + "' and usu_senha = '" + modelo.UsuSenha + "' ", conexao.StringConexao);
            da.Fill(tabela);
            return (tabela.Rows.Count > 0);              

        }       

        public Boolean AlterarSenha(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE usuario SET usu_senha = (@senha) WHERE usu_cpf = @codigo";
            
            cmd.Parameters.AddWithValue("@senha", (modelo.UsuSenha));

            cmd.Parameters.AddWithValue("@codigo", modelo.UsuCpf);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
            return true;
        }

        public Boolean VerificarCPFLogin(ModeloUsuario modelo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from usuario where usu_cpf = '" + modelo.UsuCpf + "' and usu_login = '" + modelo.UsuLogin + "' ", conexao.StringConexao);
            da.Fill(tabela);
            return (tabela.Rows.Count > 0);
        }
    }


}
