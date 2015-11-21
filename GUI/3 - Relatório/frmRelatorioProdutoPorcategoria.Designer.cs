namespace GUI._3___Relatório
{
    partial class frmRelatorioProdutoPorcategoria
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
            this.crvProdutoPorCategoria = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvProdutoPorCategoria
            // 
            this.crvProdutoPorCategoria.ActiveViewIndex = -1;
            this.crvProdutoPorCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProdutoPorCategoria.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProdutoPorCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProdutoPorCategoria.Location = new System.Drawing.Point(0, 0);
            this.crvProdutoPorCategoria.Name = "crvProdutoPorCategoria";
            this.crvProdutoPorCategoria.Size = new System.Drawing.Size(604, 425);
            this.crvProdutoPorCategoria.TabIndex = 0;
            this.crvProdutoPorCategoria.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRelatorioProdutoPorcategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 425);
            this.Controls.Add(this.crvProdutoPorCategoria);
            this.Name = "frmRelatorioProdutoPorcategoria";
            this.Text = "Relatório de Produto por categoria";
            this.Load += new System.EventHandler(this.frmRelatorioProdutoPorcategoria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProdutoPorCategoria;

    }
}