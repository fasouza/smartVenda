using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace GUI._3___Relatório
{
    public partial class frmRelatorioProduto : Form
    {
        public static int CodCategoria { get; set; }

        public frmRelatorioProduto()
        {
            InitializeComponent();
        }

        private void frmRelatorioProduto_Load(object sender, EventArgs e)
        {
            ReportDocument rb = new ReportDocument();
            rb.Load(@"B:\smartVenda\GUI\5 - Report\Produto.rpt");
            //ParameterField parametro = rb.ParameterFields["Categoria"];
            //parametro.CurrentValues.AddValue(CodCategoria);
            crvProduto.ReportSource = rb;
                       
        }
    }
}
