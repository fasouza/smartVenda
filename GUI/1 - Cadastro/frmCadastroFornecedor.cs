using BBL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroFornecedor : GUI.frmModeloFormularioCadastro
    {
        public frmCadastroFornecedor()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtBairro.Clear();
            txtCelular.Clear();
            txtCEP.Clear();
            txtCidade.Clear();
            txtCnpj.Clear(); 
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNome.Clear();
            txtNumero.Clear();          
            txtTelefone.Clear();
            txtEstado.SelectedIndex = -1;
            txtIe.Clear();
            txtRazao.Clear();
           

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
                    BLLFornecedor bll = new BLLFornecedor(cx);
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
                ModeloFornecedor modelo = new ModeloFornecedor();

                modelo.ForNome          = txtNome.Text;
                modelo.ForRSocial       = txtRazao.Text;
                modelo.ForIe            = txtIe.Text;
                modelo.For_CNPJ         = txtCnpj.Text;
                modelo.ForCep           = txtCEP.Text;
                modelo.ForEndereco      = txtEndereco.Text;
                modelo.ForBairro        = txtBairro.Text;
                modelo.ForFone          = txtTelefone.Text;
                modelo.ForCel           = txtCelular.Text;
                modelo.ForEmail         = txtEmail.Text;
                modelo.ForEndNumero     = txtNumero.Text;
                modelo.ForCidade        = txtCidade.Text;
                modelo.ForEstado        = txtEstado.Text;

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código: " + modelo.ForCod.ToString());

                }
                else
                {
                    //alterar uma categoria
                    modelo.ForCod = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (SqlException)
            {
                MessageBox.Show("O fornecedor com o CNPJ Nº " +txtCnpj.Text+ " já está cadastrado", "Verifique!");
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
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            f.Dispose();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);

                txtCodigo.Text = modelo.ForCod.ToString();
                txtNome.Text = modelo.ForNome;
                txtRazao.Text = modelo.ForRSocial;
                txtIe.Text = modelo.ForIe;
                txtCnpj.Text = modelo.For_CNPJ;
                txtCEP.Text = modelo.ForCep;
                txtEndereco.Text = modelo.ForEndereco;  
                txtBairro.Text = modelo.ForBairro;
                txtTelefone.Text = modelo.ForFone;
                txtCelular.Text = modelo.ForCel;
                txtEmail.Text = modelo.ForEmail;
                txtNumero.Text = modelo.ForEndNumero;                
                txtCidade.Text = modelo.ForCidade;
                txtEstado.Text = modelo.ForEstado;

                alteraBotoes(3);
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
