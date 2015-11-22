using BBL;
using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroVenda : GUI.frmModeloFormularioCadastro
    {
        private int codigo;
        List<ModeloItemVenda> itensVenda = new List<ModeloItemVenda>();

        public frmCadastroVenda()
        {
            InitializeComponent();

            dataGridItens.AutoGenerateColumns = false;
        }

        private void LimpaTela()
        {
            txtNumParcelas.Text = Convert.ToString(1);
            itensVenda.Clear();
            dataGridItens.DataSource = null;
            atualizarTotal();
        }

        private void frmCadastroVenda_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);

            //dataGridItens.DataSource = itensVenda;
        }

        private void btnAddTipoPag_Click(object sender, EventArgs e)
        {
            frmCadastroTipoPagamento f = new frmCadastroTipoPagamento();
            f.ShowDialog();
            f.Dispose();

            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cbxTipoPagamento.DataSource = bll.Localizar("");
            cbxTipoPagamento.DisplayMember = "tpa_nome";
            cbxTipoPagamento.ValueMember = "tpa_cod";
        }

        private void btnAddCli_Click(object sender, EventArgs e)
        {
            frmCadastroCliente f = new frmCadastroCliente();
            f.ShowDialog();
            f.Dispose();

            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLCliente bllcli = new BLLCliente(cx);
            cbxCliente.DataSource = bllcli.Localizar("");
            cbxCliente.DisplayMember = "cli_nome";
            cbxCliente.ValueMember = "cli_cod";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean existe = false;

            DataRow selectedDataRow = ((DataRowView)cbxProduto.SelectedItem).Row;

            ModeloItemVenda itemVenda = new ModeloItemVenda();
            itemVenda.ItemVendaQtde = Convert.ToDouble(txtQtde.Text);
            itemVenda.ItemVendaValor = Convert.ToDouble(txtPreco.Text) * Convert.ToDouble(txtQtde.Text);
            itemVenda.ProCod = Convert.ToInt32(selectedDataRow[0]);
            itemVenda.ItemVendaProduto = Convert.ToString(cbxProduto.Text);

            foreach (ModeloItemVenda item in itensVenda)
            {
                if (item.ProCod == itemVenda.ProCod)
                {
                    existe = true;

                    item.ItemVendaQtde += itemVenda.ItemVendaQtde;
                    item.ItemVendaValor += itemVenda.ItemVendaValor;

                    break;
                }
            }

            if (!existe)
            {
                itensVenda.Add(itemVenda);
            }

            dataGridItens.DataSource = null;
            dataGridItens.DataSource = itensVenda;
            dataGridItens.Refresh();

            atualizarTotal();
        }

        private double atualizarTotal()
        {
            double total = 0;

            foreach (ModeloItemVenda item in itensVenda)
            {
                total += item.ItemVendaValor;
            }

            label8.Text = "R$ " + String.Format(CultureInfo.InvariantCulture, "{0:0.00}", total);

            return total;
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);

            this.operacao = "inserir";

            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cbxTipoPagamento.DataSource = bll.Localizar("");
            cbxTipoPagamento.DisplayMember = "tpa_nome";
            cbxTipoPagamento.ValueMember = "tpa_cod";

            BLLCliente bllcli = new BLLCliente(cx);
            cbxCliente.DataSource = bllcli.Localizar("");
            cbxCliente.DisplayMember = "cli_nome";
            cbxCliente.ValueMember = "cli_cod";

            BLLProduto bllpro = new BLLProduto(cx);
            cbxProduto.DataSource = bllpro.Localizar("");
            cbxProduto.DisplayMember = "pro_nome";
            cbxProduto.ValueMember = "pro_cod";
        }

        private void cbxProduto_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataRow selectedDataRow = ((DataRowView)cbxProduto.SelectedItem).Row;
                txtPreco.Text = Convert.ToString(selectedDataRow[3]);
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataGridItens.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    itensVenda.RemoveAt(selectedIndex);

                    dataGridItens.DataSource = null;
                    dataGridItens.DataSource = itensVenda;
                    dataGridItens.Refresh();

                    atualizarTotal();
                }
            }
            catch
            {

            }
        }

        private void cbxProduto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtQtde.Text = Convert.ToString(1);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloVenda modelo = new ModeloVenda();
                modelo.CliCod = Convert.ToInt32(cbxCliente.SelectedValue);
                modelo.TpaCod = Convert.ToInt32(cbxTipoPagamento.SelectedValue);
                modelo.VenNparcelas = Convert.ToInt32(txtNumParcelas.Text);
                modelo.VenStatus = "A";
                modelo.VenTotal = atualizarTotal();

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                BLLItemVenda bll2 = new BLLItemVenda(cx);

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);

                    foreach (ModeloItemVenda item in itensVenda)
                    {
                        item.VenCod = modelo.VenCod;
                        bll2.Incluir(item);
                    }

                    MessageBox.Show("Cadastro efetuado: Código: " + modelo.VenCod.ToString());

                }
                else
                {
                    modelo.VenCod = this.codigo;
                    bll.Alterar(modelo);

                    foreach (ModeloItemVenda item in itensVenda)
                    {
                        item.VenCod = modelo.VenCod;

                        if (item.ItemVendaCod > 0)
                            bll2.Alterar(item);
                        else
                            bll2.Incluir(item);
                    }
                                        
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

        private void btAlterar_Click(object sender, EventArgs e)
        {
            {
                alteraBotoes(2);
                this.operacao = "alterar";
            }
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
                    bll.Excluir(Convert.ToInt32(lbVenda.Text));
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaVenda f = new frmConsultaVenda();
            f.ShowDialog();
            f.Dispose();

            if (f.codigo != 0)
            {
                itensVenda.Clear();

                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);

                BLLTipoPagamento blltp = new BLLTipoPagamento(cx);
                cbxTipoPagamento.DataSource = blltp.Localizar("");
                cbxTipoPagamento.DisplayMember = "tpa_nome";
                cbxTipoPagamento.ValueMember = "tpa_cod";

                BLLCliente bllcli = new BLLCliente(cx);
                cbxCliente.DataSource = bllcli.Localizar("");
                cbxCliente.DisplayMember = "cli_nome";
                cbxCliente.ValueMember = "cli_cod";

                BLLProduto bllpro = new BLLProduto(cx);
                cbxProduto.DataSource = bllpro.Localizar("");
                cbxProduto.DisplayMember = "pro_nome";
                cbxProduto.ValueMember = "pro_cod";

                BLLVenda bllvenda = new BLLVenda(cx);
                ModeloVenda modelo = bllvenda.CarregaModeloVenda(f.codigo);

                cbxTipoPagamento.SelectedValue = modelo.TpaCod;
                cbxCliente.SelectedValue = modelo.CliCod;
                txtNumParcelas.Text = Convert.ToString(modelo.VenNparcelas);

                this.codigo = modelo.VenCod;

                BLLItemVenda bll2 = new BLLItemVenda(cx);
                DataTable itens = bll2.Localizar(Convert.ToInt32(modelo.VenCod));
                foreach(DataRow linha in itens.Rows)
                {
                    ModeloItemVenda item = new ModeloItemVenda();
                    item = bll2.CarregaModeloItemVenda(Convert.ToInt32(linha["itemvenda_cod"].ToString()));
                    itensVenda.Add(item);
                }
                
                dataGridItens.DataSource = null;
                dataGridItens.DataSource = itensVenda;
                dataGridItens.Refresh();

                alteraBotoes(3);

                atualizarTotal();
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
