using BBL;
using BLL;
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
    public partial class frmCadastroCompra : GUI.frmModeloFormularioCadastro
    {
       

        public frmCadastroCompra()
        {
            InitializeComponent();
        }

        private void LimpaTela()
        {



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
                    BLLCompra bll = new BLLCompra(cx);
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
                ModeloCompra modelo = new ModeloCompra();          

                modelo.ComData          = Convert.ToString(txtDataCompra.Text);
                modelo.ComNfiscal       = Convert.ToInt32(txtNota.Text);
                modelo.TpaCod           = Convert.ToInt32(txtTipoPagamento.SelectedValue);
                modelo.ComStatus        = Convert.ToString(txtStatus.Text);
                modelo.ComTotal         = Convert.ToDecimal(txtValorTotal.Text);
                modelo.ComParcelas      = Convert.ToInt32(txtNParcelas.Text);
                modelo.ForCod           = Convert.ToInt32(txtFornecedor.Text);
                
                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código: " + modelo.ComCod.ToString());

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
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
      
        private void btnPesquizar_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            f.Dispose();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);
                txtFornNome.Text   = modelo.ForNome;
                txtFornecedor.Text = modelo.ForCod.ToString();

                
            }
        }
       
        private void frmCadastroCompra_Load(object sender, EventArgs e)
        {
                      
            this.alteraBotoes(1);
            //combo do tipo de pagamento
            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            txtTipoPagamento.DataSource = bll.Localizar("");
            txtTipoPagamento.DisplayMember = "tpa_nome";
            txtTipoPagamento.ValueMember = "tpa_cod";
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCompra f = new frmConsultaCompra();
            f.ShowDialog();
            f.Dispose();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);
                ModeloCompra modelo = bll.CarregaModeloCompra(f.codigo);

                txtCodigo.Text = modelo.ComCod.ToString();
                txtDataCompra.Text = modelo.ComData;
                txtNota.Text = modelo.ComNfiscal.ToString();
                txtValorTotal.Text = modelo.ComTotal.ToString();
                txtNParcelas.Text = modelo.ComParcelas.ToString();
                txtStatus.Text = modelo.ComStatus.ToString();
                txtFornecedor.Text = modelo.ForCod.ToString();
                txtTipoPagamento.Text = modelo.TpaCod.ToString();

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
