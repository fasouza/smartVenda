using BBL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaFornecedor : Form
    {
        public int codigo = 0;

        public frmConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void frmConsultaFornecedor_Load(object sender, EventArgs e)
        {
            btnPesquizar_Click(sender, e);

            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 55;
            dgvDados.Columns[1].HeaderText = "Fornecedor";
            dgvDados.Columns[1].Width = 200;
            dgvDados.Columns[2].HeaderText = "Razão Social ";
            dgvDados.Columns[2].Width = 200;
            dgvDados.Columns[3].HeaderText = "Inscrição Estadual";
            dgvDados.Columns[3].Width = 130;
            dgvDados.Columns[4].HeaderText = "CNPJ";
            dgvDados.Columns[4].Width = 130;           
            dgvDados.Columns[5].HeaderText = "CEP";
            dgvDados.Columns[5].Width = 80;
            dgvDados.Columns[6].HeaderText = "Endereço";
            dgvDados.Columns[6].Width = 200;
            dgvDados.Columns[7].HeaderText = "Bairro";
            dgvDados.Columns[7].Width = 200;
            dgvDados.Columns[8].HeaderText = "Telefone";
            dgvDados.Columns[8].Width = 100;
            dgvDados.Columns[9].HeaderText = "Celular";
            dgvDados.Columns[9].Width = 100;
            dgvDados.Columns[10].HeaderText = "E-mail";
            dgvDados.Columns[10].Width = 200;
            dgvDados.Columns[11].HeaderText = "Número";
            dgvDados.Columns[11].Width = 70;
            dgvDados.Columns[12].HeaderText = "Cidade";
            dgvDados.Columns[12].Width = 150;
            dgvDados.Columns[13].HeaderText = "Estado";
            dgvDados.Columns[13].Width = 150;


            //dgvDados.Columns["cli_rgie"].Visible = false;
            //dgvDados.Columns["cli_rsocial"].Visible = false;    
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //verifica se a linha é maior que zero
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void btnPesquizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLFornecedor bll = new BLLFornecedor(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLFornecedor bll = new BLLFornecedor(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);

        }
    }
}