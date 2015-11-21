namespace GUI._3___Relatório
{
    partial class frmRelatorioSubCategoria
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
            this.crvSubCategoria = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvSubCategoria
            // 
            this.crvSubCategoria.ActiveViewIndex = -1;
            this.crvSubCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSubCategoria.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSubCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSubCategoria.Location = new System.Drawing.Point(0, 0);
            this.crvSubCategoria.Name = "crvSubCategoria";
            this.crvSubCategoria.Size = new System.Drawing.Size(603, 478);
            this.crvSubCategoria.TabIndex = 0;
            this.crvSubCategoria.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRelatorioSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 478);
            this.Controls.Add(this.crvSubCategoria);
            this.Name = "frmRelatorioSubCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de SubCategoria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorioSubCategoria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSubCategoria;
    }
}