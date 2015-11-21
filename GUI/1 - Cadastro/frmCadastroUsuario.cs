using BBL;
using DAL;
using GUI._2___Consulta;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI._1___Cadastro
{
    public partial class frmCadastroUsuario : GUI.frmModeloFormularioCadastro
    {
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtCPF.Clear();
            txtTipo.SelectedIndex = -1;
            txtStatus.SelectedIndex = -1;
            txtLogin.Clear();
            txtSenha.Clear();
           

        }

        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                    BLLUsuario bll = new BLLUsuario(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);

                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado");
                this.alteraBotoes(3);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                //leitura dos dados
                ModeloUsuario modelo = new ModeloUsuario();
                modelo.UsuNome          = txtNome.Text;
                modelo.UsuCpf           = txtCPF.Text;
                modelo.UsuTipo          = Convert.ToString(txtTipo.Text);
                modelo.UsuStatus        = Convert.ToString(txtStatus.Text);
                modelo.UsuLogin         = txtLogin.Text;               
                modelo.UsuSenha         = txtSenha.Text;
              

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar um Usuario
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código: " + modelo.UsuCod.ToString());

                }
                else
                {
                    //alterar uma categoria
                    modelo.UsuCod = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (SqlException)
            {
                MessageBox.Show("O usuário com o cpf Nº" + txtCPF.Text + " já está cadastrado", "Verifique!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela(); //limpar tela
            this.alteraBotoes(1);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaUsuario f = new frmConsultaUsuario();
            f.ShowDialog();
            f.Dispose();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                ModeloUsuario modelo = bll.CarregaModeloUsuario(f.codigo);


                txtCodigo.Text  = modelo.UsuCod.ToString();                
                txtNome.Text    = modelo.UsuNome;
                txtCPF.Text     = modelo.UsuCpf;               
                txtTipo.Text    = modelo.UsuTipo;
                txtStatus.Text  = modelo.UsuStatus;
                txtLogin.Text   = modelo.UsuLogin;
                txtSenha.Text   = modelo.UsuSenha;               

                this.alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose(); 

        }
    }
}
