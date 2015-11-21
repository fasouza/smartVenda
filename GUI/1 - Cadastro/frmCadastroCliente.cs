using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BBL;
using BLL;
using System.Data.SqlClient;
using Ferramentas;

namespace GUI
{
    public partial class frmCadastroCliente : GUI.frmModeloFormularioCadastro
    {
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtBairro.Clear();
            txtCelular.Clear();
            txtCEP.Clear();
            txtCidade.Clear();         
            txtCPF.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNome.Clear();
            txtNumero.Clear();           
            txtRG.Clear();
            txtTelefone.Clear();
            txtEstado.SelectedIndex = -1;
            rbnPessoaFísica.Checked = false;
            rbnPessoajuridica.Checked = false;
           
        }

        public frmCadastroCliente()
        {
            InitializeComponent();
        }
       
        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
            
        }

        private void rbnPessoaFísica_CheckedChanged(object sender, EventArgs e)
        {
           
            txtRG.Visible = true;
            lbRg.Visible = true;

            lbCliente.Text = "Nome";
            lbRg.Text = "RG";
            lbCpf.Text = "CPF";

        }

        private void rbnPessoajuridica_CheckedChanged(object sender, EventArgs e)
        {
           
            //txtCPF.Visible = false;

            lbCpf.Text = "CNPJ";        
            lbRg.Text = "IE";
            lbCliente.Text = "Razão Social";
            
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela(); //limpar tela
            this.alteraBotoes(1);
        }
        
        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
               
                //leitura dos dados
                ModeloCliente modelo = new ModeloCliente();
                modelo.CliNome      = txtNome.Text;               
                modelo.CliRG        = txtRG.Text;               
                modelo.CliNome      = txtNome.Text;
                modelo.CliCPF_CNPJ  = txtCPF.Text;               
                modelo.CliCep       = txtCEP.Text;
                modelo.CliEndereco  = txtEndereco.Text;
                modelo.CliBairro    = txtBairro.Text;
                modelo.CliFone      = txtTelefone.Text;
                modelo.CliCel       = txtCelular.Text;
                modelo.CliEmail     = txtEmail.Text;
                modelo.CliEndNumero = txtNumero.Text;
                modelo.CliCidade    = txtCidade.Text;
                if (rbnPessoaFísica.Checked )
                {
                    modelo.CliTipo = rbnPessoaFísica.Text;
                    modelo.CliRSocial = " ";
                }
                else
                {
                    modelo.CliTipo = rbnPessoajuridica.Text;                   
                }

                modelo.CliEstado    = txtEstado.Text;

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código: " + modelo.CliCod.ToString());

                }
                else
                {
                    //alterar uma categoria
                    modelo.CliCod = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (SqlException)
            {
                MessageBox.Show("O cliente com o cpf Nº "+ txtCPF.Text + " já está cadastrado", "Verifique!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
   
        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            f.Dispose();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);


                txtCodigo.Text = modelo.CliCod.ToString();
                txtBairro.Text = modelo.CliBairro;
                txtCelular.Text = modelo.CliCel;
                txtCEP.Text = modelo.CliCep;
                txtCidade.Text = modelo.CliCidade;               
                txtCPF.Text = modelo.CliCPF_CNPJ;
                txtEmail.Text = modelo.CliEmail;
                txtEndereco.Text = modelo.CliEndereco;
                txtNome.Text = modelo.CliNome;
                txtNumero.Text = modelo.CliEndNumero;
                txtRG.Text = modelo.CliRG;
                txtTelefone.Text = modelo.CliFone;
                txtEstado.Text = modelo.CliEstado;
                if (modelo.CliTipo == "Pessoa Física")
                {
                    rbnPessoajuridica.Checked = false;
                    rbnPessoaFísica.Checked = true;
                }
                else
                {
                    rbnPessoaFísica.Checked = false;
                    rbnPessoajuridica.Checked = true;
                }
               
               

                this.alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose(); 
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
                    BLLCliente bll = new BLLCliente(cx);
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

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            if (BuscaEndereco.verificaCEP(txtCEP.Text) == true)
            {
                txtBairro.Text = BuscaEndereco.bairro;
                txtEstado.Text = BuscaEndereco.estado;
                txtCidade.Text = BuscaEndereco.cidade;
                txtEndereco.Text = BuscaEndereco.endereco;

            }
            else
            {

            }
        }     

    }
}
