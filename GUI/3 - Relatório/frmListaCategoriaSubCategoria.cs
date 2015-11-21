using BLL;
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

namespace GUI._3___Relatório
{
    public partial class frmListaCategoriaSubCategoria : Form
    {
       
        public frmListaCategoriaSubCategoria()
        {
            InitializeComponent();
        }

        public void frmListaCategoria_Load(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cboCategoria.DataSource = bll.Localizar("");//trás todos os dados
            cboCategoria.DisplayMember = "cat_nome";// valor que aparece
            cboCategoria.ValueMember = "cat_cod";//valor que vai ser passado
        }

        
        public void btnGerar_Click(object sender, EventArgs e)
        {

            frmRelatorioSubCategoria f = new frmRelatorioSubCategoria();      
            GUI._3___Relatório.frmRelatorioSubCategoria.CodCategoria = (int)cboCategoria.SelectedValue;
            f.ShowDialog();
            f.Dispose();

        }
    }
}
