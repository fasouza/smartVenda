using BBL;
using DAL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaVenda : Form
    {
        public int codigo = 0;

        public frmConsultaVenda()
        {
            InitializeComponent();

            dataGridVenda.AutoGenerateColumns = false;
            dataGridItens.AutoGenerateColumns = false;
        }

        private void btnPesquizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLVenda bll = new BLLVenda(cx);
            dataGridVenda.DataSource = null;
            dataGridVenda.DataSource = bll.Localizar(txtValor.Text);
            dataGridVenda.Refresh();

            string numeroVenda = dataGridVenda[0, 0].Value.ToString();

            BLLItemVenda bll2 = new BLLItemVenda(cx);
            dataGridItens.DataSource = null;
            dataGridItens.DataSource = bll2.Localizar(Convert.ToInt32(numeroVenda));
            dataGridItens.Refresh();
        }

        private void dataGridVenda_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dataGridVenda.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
