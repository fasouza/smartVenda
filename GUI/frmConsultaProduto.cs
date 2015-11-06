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
    public partial class frmConsultaProduto : Form
    {
        public int codigo = 0;
        public frmConsultaProduto()
        {
            InitializeComponent();
        }

        private void btnPesquizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
        }

        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            btnPesquizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 55;
            dgvDados.Columns[1].HeaderText = "Produto";
            dgvDados.Columns[1].Width = 200;
            dgvDados.Columns[2].HeaderText = "Descrição";
            dgvDados.Columns[2].Width = 200;
            dgvDados.Columns[3].HeaderText = "Valor";
            dgvDados.Columns[3].Width = 100;
            dgvDados.Columns[4].HeaderText = "Quantidade";
            dgvDados.Columns[4].Width = 100;
            dgvDados.Columns[5].HeaderText = "Categoria";
            dgvDados.Columns[5].Width = 150;
            dgvDados.Columns[6].HeaderText = "Sub-Categoria";
            dgvDados.Columns[6].Width = 150;
            dgvDados.Columns[7].HeaderText = "Unidade";
            dgvDados.Columns[7].Width = 100;           
            
            
            
            //ocuta colunas
            //dgvDados.Columns["pro_valorpago"].Visible = false;
            //dgvDados.Columns["pro_foto"].Visible = false;
            //dgvDados.Columns["umed_cod"].Visible = false;
            //dgvDados.Columns["cat_cod"].Visible = false;
            //dgvDados.Columns["scat_cod"].Visible = false;
          

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
    }
}
