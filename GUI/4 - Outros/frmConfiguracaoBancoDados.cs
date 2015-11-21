using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using DAL;

namespace GUI
{
    public partial class frmConfiguracaoBancoDados : Form
    {
        public frmConfiguracaoBancoDados()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter arquivo = new StreamWriter("Configuracao.txt", false);
                arquivo.WriteLine(txtServidor.Text);
                arquivo.WriteLine(txtBanco.Text);
                arquivo.WriteLine(txtUsuario.Text);
                arquivo.WriteLine(txtSenha.Text);
                arquivo.Close();
                MessageBox.Show("Arquivo atualizado com sucesso!!");
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void frmConfiguracaoBancoDados_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader arquivo = new StreamReader("Configuracao.txt");
                txtServidor.Text = arquivo.ReadLine();
                txtBanco.Text = arquivo.ReadLine();
                txtUsuario.Text = arquivo.ReadLine();
                txtSenha.Text = arquivo.ReadLine();               
                arquivo.Close();                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            try
            {
               
                DadosConexao.servidor = txtServidor.Text;
                DadosConexao.banco = txtBanco.Text;
                DadosConexao.usuario = txtUsuario.Text;
                DadosConexao.senha = txtSenha.Text;
                

                //testar conexao
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
                MessageBox.Show("Conexão efetuada com sucesso.");
            }
            catch (SqlException errob)
            {
                MessageBox.Show(errob+" Erro ao se conectar no banca de dados.\n" +
                                "Verifique os dados informados");
            }

            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }
        }
    }
}
