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
    public partial class frmConsultaCliente : Form
    {
        public int codigo = 0;
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            btnPesquizar_Click(sender, e);

            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 55;
            dgvDados.Columns[1].HeaderText = "Cliente";
            dgvDados.Columns[1].Width = 200;
            dgvDados.Columns[2].HeaderText = "CPF";
            dgvDados.Columns[2].Width = 130;
            dgvDados.Columns[3].HeaderText = "RG";
            dgvDados.Columns[3].Width = 150;
            dgvDados.Columns[4].HeaderText = "Razão Social";
            dgvDados.Columns[4].Width = 150;           
            dgvDados.Columns[5].HeaderText = "Tipo";
            dgvDados.Columns[5].Width = 100;
            dgvDados.Columns[6].HeaderText = "CEP";
            dgvDados.Columns[6].Width = 80;   
            dgvDados.Columns[7].HeaderText = "Endereço";
            dgvDados.Columns[7].Width = 200;
            dgvDados.Columns[8].HeaderText = "Bairro";
            dgvDados.Columns[8].Width = 200;
            dgvDados.Columns[9].HeaderText = "Telefone";
            dgvDados.Columns[9].Width = 100;
            dgvDados.Columns[10].HeaderText = "Celular";
            dgvDados.Columns[10].Width = 100;
            dgvDados.Columns[11].HeaderText = "E-mail";
            dgvDados.Columns[11].Width = 200;
            dgvDados.Columns[12].HeaderText = "Número";
            dgvDados.Columns[12].Width = 100;
            dgvDados.Columns[13].HeaderText = "Cidade";
            dgvDados.Columns[13].Width = 150;
            dgvDados.Columns[14].HeaderText = "Estado";
            dgvDados.Columns[14].Width = 150;


            dgvDados.Columns["cli_rgie"].Visible = false;
            dgvDados.Columns["cli_rsocial"].Visible = false;        
          
            
        }

        private void btnPesquizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
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

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
        }
    }
}
