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
        public int codigo = 0;
        public void LimpaTela()
        {
            txtValor.Clear();
           
        }

        public frmContasReceber()
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
                    modelo.CPCod = Convert.ToInt32(txtCodigo.Text);
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
            frmConsultaContasReceber f = new frmConsultaContasReceber();
            f.ShowDialog();
            f.Dispose();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLContasReceber bll = new BLLContasReceber(cx);
                ModeloContasReceber modelo = bll.CarregaModeloContasReceber(f.codigo);
                txtCodigo.Text = modelo.CPCod.ToString();
                cbCliente.SelectedValue = modelo.CPCliente;
                txtValor.Text = Convert.ToString(modelo.CPValor);
                txtVencimento.Value = modelo.CPVencimento;
                txtPagamento.Value = modelo.CPPagamento;
                cbPago.Text = modelo.CPStatus;
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

        private void frmContasReceber_Load(object sender, EventArgs e)
        {

            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BBL.BLLContasReceber bll = new BBL.BLLContasReceber(cx);
            dgvDados.DataSource = bll.Localizar("");

            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 55;
            dgvDados.Columns[1].HeaderText = "Vencimento";
            dgvDados.Columns[1].Width = 200;
            dgvDados.Columns[2].HeaderText = "Cliente";
            dgvDados.Columns[2].Width = 200;
            dgvDados.Columns[3].HeaderText = "Valor";
            dgvDados.Columns[3].Width = 200;

            BBL.BLLCliente bllCliente = new BBL.BLLCliente(cx);
            cbCliente.DataSource = bllCliente.Localizar("");
            cbCliente.DisplayMember = "cli_nome";
            cbCliente.ValueMember = "cli_cod";
         //   this.alteraBotoes(4);


        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //verifica se a linha é maior que zero
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLContasReceber bll = new BLLContasReceber(cx);
                ModeloContasReceber modelo = bll.CarregaModeloContasReceber(this.codigo);
                txtCodigo.Text = modelo.CPCod.ToString();
                cbCliente.Text = Convert.ToString(modelo.CPCliente);

                this.alteraBotoes(3);
            }
        }

     /*   private void dgvDados_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvDados.SelectedRows.Count >= 0)
            {
                txtCodigo.Text = Convert.ToString(dgvDados.SelectedRows[0].Cells[0].Value);
            }
        }     */     
    }
}
