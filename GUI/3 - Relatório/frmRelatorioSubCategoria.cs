using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class frmRelatorioSubCategoria : Form
    {
        public static int CodCategoria { get; set; }

        public frmRelatorioSubCategoria()
        {
            InitializeComponent();
        }

        private void frmRelatorioSubCategoria_Load(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(@"B:\smartVenda\GUI\5 - Report\SubCategoria.rpt");
            ParameterField parametro = rd.ParameterFields["CodigoCategoria"];
            parametro.CurrentValues.AddValue(CodCategoria);
            crvSubCategoria.ReportSource = rd;
        }
    }
}
