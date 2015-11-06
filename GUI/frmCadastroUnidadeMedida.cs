using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelo;
using DAL;
using BLL;


namespace GUI
{
    public partial class frmCadastroUnidadeMedida : GUI.frmModeloFormularioCadastro
    {
        public frmCadastroUnidadeMedida()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
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
                    BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro.\n Pois o mesmo está sendo utilizado em outro local.");
                this.alteraBotoes(3);

            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloUnidadeMedida modelo = new ModeloUnidadeMedida();
                modelo.UmedNome = txtNome.Text;

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);             

                if (this.operacao == "inserir")
                {                   
                    //cadastrar uma Unidade de medida
                    bll.Incluir(modelo);                   
                    MessageBox.Show("Cadastro efetuado: Código: " + modelo.UmedCod.ToString());

                }
                else
                {                   
                    //alterar uma categoria
                    modelo.UmedCod = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
              
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
               MessageBox.Show(erro.Message+"erro");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela(); //limpar tela
            this.alteraBotoes(1);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeMedida f = new frmConsultaUnidadeMedida();
            f.ShowDialog();
            f.Dispose();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);
                ModeloUnidadeMedida modelo = bll.CarregaModeloUnidadeMedida(f.codigo);
                txtCodigo.Text = modelo.UmedCod.ToString();
                txtNome.Text = modelo.UmedNome;                
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();            
          }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (this.operacao == "inserir")
            {
                int r = 0;

                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);
                r = bll.VerificaUnidadeMedida(txtNome.Text);

                if (r > 0)
                {
                    DialogResult d = MessageBox.Show("Já existi o registro com esse valor. deseja alterar o registro?", "Aviso", MessageBoxButtons.YesNo);
                    if (d.ToString() == "Yes")
                    {
                        this.operacao = "alteracao";
                        ModeloUnidadeMedida modelo = bll.CarregaModeloUnidadeMedida(r);
                        txtCodigo.Text = modelo.UmedCod.ToString();
                        txtNome.Text = modelo.UmedNome;
                    }
                }

            }
        }  
       }
       
    }

