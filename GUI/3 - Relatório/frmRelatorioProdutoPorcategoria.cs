using BLL;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
using Microsoft.Reporting.WinForms;
using CrystalDecisions.Windows.Forms;

namespace GUI._3___Relatório
{
    public partial class frmRelatorioProdutoPorcategoria : Form
    {
       
        public frmRelatorioProdutoPorcategoria()
        {
            InitializeComponent();
        }

        private void frmRelatorioProdutoPorcategoria_Load(object sender, EventArgs e)
        {
            ReportDocument rb = new ReportDocument();
            rb.Load(@"B:\smartVenda\GUI\5 - Report\ProdutoPorCategoria.rpt");
            crvProdutoPorCategoria.ReportSource = rb;
        }

                               
            //frmRelatorioProduto f = new frmRelatorioProduto();           
            ////GUI._3___Relatório.frmRelatorioProduto.CodCategoria = (int)cboCategoria.SelectedValue;
            //f.ShowDialog();
            //f.Dispose();
            
       
    }
}
