using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace GUI._3___Relatório
{
    public partial class frmRelatorioCategoria : Form
    {
        public frmRelatorioCategoria()
        {
            InitializeComponent();
        }

        private void frmRelatorioCategoria_Load(object sender, EventArgs e)
        {
            ReportDocument rb = new ReportDocument();
            rb.Load(@"B:\smartVenda\GUI\5 - Report\Categoria.rpt");
            crvCategoria.ReportSource = rb;
        }
             
       
    }
}
