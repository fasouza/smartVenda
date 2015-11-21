namespace GUI
{
    partial class frmConsultaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCliente));
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquizar = new System.Windows.Forms.Button();
            this.rbnNome = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnCPF = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(22, 152);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(578, 335);
            this.dgvDados.TabIndex = 15;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(22, 119);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(515, 20);
            this.txtValor.TabIndex = 13;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cliente";
            // 
            // btnPesquizar
            // 
            this.btnPesquizar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquizar.Image")));
            this.btnPesquizar.Location = new System.Drawing.Point(544, 115);
            this.btnPesquizar.Name = "btnPesquizar";
            this.btnPesquizar.Size = new System.Drawing.Size(56, 28);
            this.btnPesquizar.TabIndex = 14;
            this.btnPesquizar.UseVisualStyleBackColor = true;
            this.btnPesquizar.Click += new System.EventHandler(this.btnPesquizar_Click);
            // 
            // rbnNome
            // 
            this.rbnNome.AutoSize = true;
            this.rbnNome.Checked = true;
            this.rbnNome.Location = new System.Drawing.Point(6, 19);
            this.rbnNome.Name = "rbnNome";
            this.rbnNome.Size = new System.Drawing.Size(53, 17);
            this.rbnNome.TabIndex = 16;
            this.rbnNome.TabStop = true;
            this.rbnNome.Text = "Nome";
            this.rbnNome.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnCPF);
            this.groupBox1.Controls.Add(this.rbnNome);
            this.groupBox1.Location = new System.Drawing.Point(22, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 68);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // rbnCPF
            // 
            this.rbnCPF.AutoSize = true;
            this.rbnCPF.Location = new System.Drawing.Point(6, 45);
            this.rbnCPF.Name = "rbnCPF";
            this.rbnCPF.Size = new System.Drawing.Size(77, 17);
            this.rbnCPF.TabIndex = 17;
            this.rbnCPF.Text = "CPF/CNPJ";
            this.rbnCPF.UseVisualStyleBackColor = true;
            // 
            // frmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 505);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnPesquizar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Cliente";
            this.Load += new System.EventHandler(this.frmConsultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnPesquizar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbnNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnCPF;
    }
}