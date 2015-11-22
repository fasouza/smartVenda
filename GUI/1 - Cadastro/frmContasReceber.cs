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
    public partial class frmContasReceber : GUI.frmModeloFormularioCadastro
    {
        public void LimpaTela()
        {
            txtValor.Clear();
           
        }

        public frmContasReceber()
        {
            InitializeComponent();
            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            cbCliente.DataSource = bll.Localizar("");
            cbCliente.DisplayMember = "cli_nome";
            cbCliente.ValueMember = "cli_cod";
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
                ModeloContasReceber modelo = new ModeloContasReceber();
                modelo.CPVencimento = Convert.ToDateTime(txtVencimento.Text);
                modelo.CPPagamento = Convert.ToDateTime(txtPagamento.Text);
                modelo.CPStatus = cbPago.Text;
                modelo.CPValor = Convert.ToDouble(txtValor.Text);
                modelo.CPCliente = Convert.ToInt32(cbCliente.SelectedValue); 

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLContasReceber bll = new BLLContasReceber(cx);

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
        private void frmContasReceber_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            cbCliente.DataSource = bll.Localizar("");
            cbCliente.DisplayMember = "cli_nome";
            cbCliente.ValueMember = "cli_cod";
      
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaContasReceber f = new frmConsultaContasReceber();
            f.ShowDialog();
            f.Dispose();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLContasReceber bll = new BLLContasReceber(cx);
                ModeloContasReceber modelo = bll.CarregaModeloContasReceber(f.codigo);


                //txtCodigo.Text = modelo.CPCod.ToString();
              //  txtDescricao.Text = modelo.CPDescricao;

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
                    BLLContasReceber bll = new BLLContasReceber(cx);
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

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            frmCadastroCliente f = new frmCadastroCliente();
            f.ShowDialog();
            f.Dispose();

            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            cbCliente.DataSource = bll.Localizar("");
            cbCliente.DisplayMember = "cli_nome";
            cbCliente.ValueMember = "cli_cod";
        }          
    }
}
