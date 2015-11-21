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

namespace GUI
{
    public partial class frmContasPagar : GUI.frmModeloFormularioCadastro
    {
        public void LimpaTela()
        {
            txtDescricao.Clear();
           
        }

        public frmContasPagar()
        {
            InitializeComponent();
        }
       
        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
            
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
                ModeloContasPagar modelo = new ModeloContasPagar();
                modelo.CPDescricao      = txtDescricao.Text;
                modelo.CPVencimento = Convert.ToDateTime(txtVencimento.Text);
                modelo.CPPagamento = Convert.ToDateTime(txtPagamento.Text);
                modelo.CPStatus = cbPago.Text;
                modelo.CPValor = Convert.ToDouble(txtValor.Text);
                modelo.CPFornecedor = Convert.ToInt32(txtFornecedor.Text);

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLContasPagar bll = new BLLContasPagar(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código: " + modelo.CPCod.ToString());

                }
                else
                {
                    //alterar uma categoria
                    //modelo.CPCod = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
   
        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmContasPagar f = new frmContasPagar();
            f.ShowDialog();
            f.Dispose();

       /*     if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLContasPagar bll = new BLLContasPagar(cx);
                ModeloContasPagar modelo = bll.CarregaModeloContasPagar(f.codigo);


                //txtCodigo.Text = modelo.CPCod.ToString();
                txtDescricao.Text = modelo.CPDescricao;

                this.alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }*/
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
                    BLLContasPagar bll = new BLLContasPagar(cx);
                 //   bll.Excluir(Convert.ToInt32(txtCodigo.Text));
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
    }
}
