using BLL;
using DAL;
using Modelo;
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
    public partial class frmConsultaContasReceber : Form
    {
        public int codigo = 0;
        public frmConsultaContasReceber()
        {
            InitializeComponent();
        }

        private void btnPesquizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BBL.BLLContasReceber bll = new BBL.BLLContasReceber(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BBL.BLLContasReceber bll = new BBL.BLLContasReceber(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
        }

        private void frmConsultaContasReceber_Load_1(object sender, EventArgs e)
        {
            btnPesquizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 55;
            dgvDados.Columns[1].HeaderText = "Vencimento";
            dgvDados.Columns[1].Width = 200;
            dgvDados.Columns[2].HeaderText = "Cliente";
            dgvDados.Columns[2].Width = 200;
            dgvDados.Columns[3].HeaderText = "Valor";
            dgvDados.Columns[3].Width = 200;
        }

        private void dgvDados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            //verifica se a linha é maior que zero
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
       
    }
}
