namespace GUI._3___Relatório
{
    partial class frmRelatorioProduto
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
            this.crvProduto = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvProduto
            // 
            this.crvProduto.ActiveViewIndex = -1;
            this.crvProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProduto.Location = new System.Drawing.Point(0, 0);
            this.crvProduto.Name = "crvProduto";
            this.crvProduto.Size = new System.Drawing.Size(614, 482);
            this.crvProduto.TabIndex = 0;
            this.crvProduto.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRelatorioProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 482);
            this.Controls.Add(this.crvProduto);
            this.Name = "frmRelatorioProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Produto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorioProduto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProduto;
    }
}