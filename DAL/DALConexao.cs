using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DALConexao
    {
        private String _stringConexao; //Armazena a string de conexao
        private SqlConnection _conexao; //Minha conexao

        public DALConexao(String dadosConexao)
        {
            this._conexao = new SqlConnection();//consultor de conexao
            this.StringConexao = dadosConexao; //instanciar dados conexao
            this._conexao.ConnectionString = dadosConexao;
        }


        
        public String StringConexao
        {
            get { return this._stringConexao; } 
            set { this._stringConexao = value; }
        }

        public SqlConnection ObjetoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }

        }
        public void Conectar()
        {
            this._conexao.Open();
        }

        public void Desconectar()
        {
            this._conexao.Close();
        }
    }
}
