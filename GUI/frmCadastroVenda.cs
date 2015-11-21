using BBL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroVenda : GUI.frmModeloFormularioCadastro
    {
        public frmCadastroVenda()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtDataVenda.Clear();
            txtFornecedor.Clear();
            txtFornNome.Clear();
            txtNota.Clear();
            txtNParcelas.Clear();
            txtStatus.Clear();
            txtTipoPagamento.Text = "";
            txtValorTotal.Clear();            

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
                    BLLVenda bll = new BLLVenda(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);

                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado");
                this.alteraBotoes(2);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloVenda modelo = new ModeloVenda();

                modelo.VenData = Convert.ToDateTime(txtDataVenda.Text);
                modelo.VenNfiscal = Convert.ToInt32(txtNota.Text);
                modelo.VenTotal = Convert.ToDecimal(txtValorTotal.Text);
                modelo.VenParcelas = Convert.ToInt32(txtNParcelas.Text);
                modelo.VenStatus = Convert.ToString(txtStatus.Text);
                modelo.CliCod = Convert.ToInt32(txtFornecedor.SelectedText);
                modelo.TpaCod = Convert.ToInt32(txtTipoPagamento.SelectedValue);



                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar uma venda
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código: " + modelo.VenCod.ToString());

                }
                else
                {
                    //alterar uma categoria
                    modelo.VenCod = Convert.ToInt32(txtCodigo.Text);
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void frmCadastroVenda_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);

            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            txtTipoPagamento.DataSource = bll.Localizar("");//trás todos os dados
            txtTipoPagamento.DisplayMember = "tpa_nome";// valor que aparece
            txtTipoPagamento.ValueMember = "tpa_cod";//valor que vai ser passado
        }
    }
}
