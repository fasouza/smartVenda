namespace GUI._2___Consulta
{
    partial class frmConsultaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaUsuario));
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(27, 73);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(578, 462);
            this.dgvDados.TabIndex = 19;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(27, 43);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(515, 20);
            this.txtValor.TabIndex = 17;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Usuário";
            // 
            // btnPesquizar
            // 
            this.btnPesquizar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquizar.Image")));
            this.btnPesquizar.Location = new System.Drawing.Point(549, 39);
            this.btnPesquizar.Name = "btnPesquizar";
            this.btnPesquizar.Size = new System.Drawing.Size(56, 28);
            this.btnPesquizar.TabIndex = 18;
            this.btnPesquizar.UseVisualStyleBackColor = true;
            this.btnPesquizar.Click += new System.EventHandler(this.btnPesquizar_Click);
            // 
            // frmConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnPesquizar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaUsuario";
            this.Text = "frmConsultaUsuario";
            this.Load += new System.EventHandler(this.frmConsultaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnPesquizar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
    }
}