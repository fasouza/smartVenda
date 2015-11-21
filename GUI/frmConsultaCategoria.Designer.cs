namespace GUI
{
    partial class frmConsultaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCategoria));
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnPesquizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria";           
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(31, 62);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(515, 20);
            this.txtValor.TabIndex = 1;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(31, 118);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(578, 351);
            this.dgvDados.TabIndex = 3;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // btnPesquizar
            // 
            this.btnPesquizar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquizar.Image")));
            this.btnPesquizar.Location = new System.Drawing.Point(553, 58);
            this.btnPesquizar.Name = "btnPesquizar";
            this.btnPesquizar.Size = new System.Drawing.Size(56, 28);
            this.btnPesquizar.TabIndex = 2;
            this.btnPesquizar.UseVisualStyleBackColor = true;
            this.btnPesquizar.Click += new System.EventHandler(this.btnPesquizar_Click);
            // 
            // frmConsultaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 561);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnPesquizar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Categoria";
            this.Load += new System.EventHandler(this.frmConsultaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnPesquizar;
        private System.Windows.Forms.DataGridView dgvDados;
    }
}