using DAL;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using BBL;
using Modelo;
using System.Timers;


namespace GUI
{
    public partial class frmLogin : Form
    {         
        public frmLogin()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtLogin.Clear();
            txtSenha.Clear();
            txtCPF.Clear();
            txtEsqueceSenha.Clear();
            txtEsqueceLogin.Clear();

            lbCPF.Visible = false;
            lbEsqSenha.Visible = false;
            txtCPF.Visible = false;
            txtEsqueceLogin.Visible = false;
            txtEsqueceSenha.Visible = false;
            lbEsqlogin.Visible = false;
            btnMudarSenha.Visible = false;
            btnCancelaNovaSenha.Visible = false;


            lbSenha.Visible = true;
            txtSenha.Visible = true;
            txtLogin.Visible = true;
            btnEntrar.Visible = true;
            btnCancelar.Visible = true;

            lbAlteradaSucesso.Visible = false;

        }


        private void  btnEntrar_Click(object sender, EventArgs e)
        {
            //leitura dos dados
            ModeloUsuario modelo = new ModeloUsuario();            
            modelo.UsuLogin = txtLogin.Text;
            modelo.UsuSenha = txtSenha.Text;

            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLUsuario bll = new BLLUsuario(cx);

            if (bll.AutenticarUsuario(modelo))
            {                
                    this.Hide();
                    frmPrincipal f = new frmPrincipal();
                    f.ShowDialog();
                    f.Dispose();
                    this.Close();             
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválidos", "Verifique", MessageBoxButtons.OK);
            }
        }            

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    frmLogin f = new frmLogin();
                    this.Close();
                }
            }
            catch
            {
               
            }
        }          

        private void lbesqueceSenha_Click(object sender, EventArgs e)
        {
            //visível no click do esquecer senha
            lbCPF.Visible           = true;
            lbEsqSenha.Visible      = true;
            txtCPF.Visible          = true;
            txtEsqueceLogin.Visible = true;
            txtEsqueceSenha.Visible = true;
            lbEsqlogin.Visible      = true;
            btnMudarSenha.Visible   = true;
            btnCancelaNovaSenha.Visible = true;


            lbSenha.Visible = false;
            txtSenha.Visible = false;
            txtLogin.Visible = false;
            btnEntrar.Visible = false;
            btnCancelar.Visible = false;     

        }
       
        private void btnMudarSenha_Click(object sender, EventArgs e)
        {       

            try
            {
                //leitura dos dados para verificar CPF
                ModeloUsuario validacpflogin = new ModeloUsuario();
                validacpflogin.UsuCpf = txtCPF.Text;
                validacpflogin.UsuLogin = txtEsqueceLogin.Text;

                //leitura dos dados para mudar senha
                ModeloUsuario mudarsenha = new ModeloUsuario();
                mudarsenha.UsuSenha = txtEsqueceSenha.Text;
                mudarsenha.UsuCpf = txtCPF.Text;


               
                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);

                if (bll.VerificarCPFLogin(validacpflogin))
                {
                    bll.VerificarCPFLogin(validacpflogin);

                    if (bll.AlterarSenha(mudarsenha))
                    {
                        bll.AlterarSenha(mudarsenha);
                        lbAlteradaSucesso.Visible = true;
                     }
                    else
                    {
                        MessageBox.Show("O CPF ou Login é inválido", "Verifique", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("O CPF ou Login é inválido", "Verifique", MessageBoxButtons.OK);
                } 
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
        }

        private void btnCancelaNovaSenha_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(btnEntrar.Visible == true)
                {
                    btnEntrar_Click(sender, e);
                }
                else
                {
                    btnMudarSenha_Click(sender, e);
                }
            }
        }

       
    }   

                    
}
