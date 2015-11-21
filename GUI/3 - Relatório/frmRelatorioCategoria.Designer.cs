namespace GUI._3___Relatório
{
    partial class frmRelatorioCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.crvCategoria = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(32102, 32056);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 1;
            // 
            // crvCategoria
            // 
            this.crvCategoria.ActiveViewIndex = -1;
            this.crvCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCategoria.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCategoria.Location = new System.Drawing.Point(0, 0);
            this.crvCategoria.Name = "crvCategoria";
            this.crvCategoria.Size = new System.Drawing.Size(634, 461);
            this.crvCategoria.TabIndex = 2;
            this.crvCategoria.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRelatorioCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.crvCategoria);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Categoria ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorioCategoria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCategoria;
    }
}