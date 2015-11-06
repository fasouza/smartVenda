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
    public partial class frmConsultaTipoPagamento : Form
    {

        public int codigo = 0;

        public frmConsultaTipoPagamento()
        {
            InitializeComponent();
        }

        private void btnPesquizar_Click(object sender, EventArgs e)
        {

            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
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

        private void frmConsultaTipoPagamento_Load(object sender, EventArgs e)
        {
            btnPesquizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 55;
            dgvDados.Columns[1].HeaderText = "Tipo de Pagamento";
            dgvDados.Columns[1].Width = 480;

        }
    }
}
