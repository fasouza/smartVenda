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

namespace GUI._2___Consulta
{
    public partial class frmConsultaUsuario : Form
    {
        public int codigo = 0;

        public frmConsultaUsuario()
        {
            InitializeComponent();
        }

        private void frmConsultaUsuario_Load(object sender, EventArgs e)
        {
            btnPesquizar_Click(sender, e);

            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 55;
            dgvDados.Columns[1].HeaderText = "Nome";
            dgvDados.Columns[1].Width = 200;
            dgvDados.Columns[2].HeaderText = "CPF";
            dgvDados.Columns[2].Width = 100;
            dgvDados.Columns[3].HeaderText = "Tipo";
            dgvDados.Columns[3].Width = 100;
            dgvDados.Columns[4].HeaderText = "Status";
            dgvDados.Columns[4].Width = 100;
            dgvDados.Columns[5].HeaderText = "Login";
            dgvDados.Columns[5].Width = 100;
            dgvDados.Columns[6].HeaderText = "Senha";
            dgvDados.Columns[6].Width = 55;

            dgvDados.Columns["usu_senha"].Visible = false;
            dgvDados.Columns["usu_cpf"].Visible = false;
            dgvDados.Columns["usu_login"].Visible = false;

        }

        private void btnPesquizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLUsuario bll = new BLLUsuario(cx);
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
            BLLUsuario bll = new BLLUsuario(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
        }
    }
}
