namespace GUI
{
    partial class frmConsultaVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaVenda));
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquizar = new System.Windows.Forms.Button();
            this.dataGridVenda = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridItens = new System.Windows.Forms.DataGridView();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItens)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(22, 31);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(515, 20);
            this.txtValor.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cliente";
            // 
            // btnPesquizar
            // 
            this.btnPesquizar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquizar.Image")));
            this.btnPesquizar.Location = new System.Drawing.Point(544, 27);
            this.btnPesquizar.Name = "btnPesquizar";
            this.btnPesquizar.Size = new System.Drawing.Size(56, 28);
            this.btnPesquizar.TabIndex = 17;
            this.btnPesquizar.UseVisualStyleBackColor = true;
            this.btnPesquizar.Click += new System.EventHandler(this.btnPesquizar_Click);
            // 
            // dataGridVenda
            // 
            this.dataGridVenda.AllowUserToAddRows = false;
            this.dataGridVenda.AllowUserToDeleteRows = false;
            this.dataGridVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dataGridVenda.Location = new System.Drawing.Point(22, 57);
            this.dataGridVenda.Name = "dataGridVenda";
            this.dataGridVenda.ReadOnly = true;
            this.dataGridVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVenda.Size = new System.Drawing.Size(578, 180);
            this.dataGridVenda.TabIndex = 18;
            this.dataGridVenda.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVenda_CellContentDoubleClick);
            this.dataGridVenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVenda_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ven_cod";
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "cli_nome";
            this.Column2.HeaderText = "Cliente";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ven_status";
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ven_data";
            this.Column5.HeaderText = "Data";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ven_total";
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dataGridItens
            // 
            this.dataGridItens.AllowUserToAddRows = false;
            this.dataGridItens.AllowUserToDeleteRows = false;
            this.dataGridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProduto,
            this.colQtde,
            this.colValor});
            this.dataGridItens.Location = new System.Drawing.Point(22, 243);
            this.dataGridItens.Name = "dataGridItens";
            this.dataGridItens.ReadOnly = true;
            this.dataGridItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridItens.Size = new System.Drawing.Size(578, 149);
            this.dataGridItens.TabIndex = 19;
            // 
            // colProduto
            // 
            this.colProduto.DataPropertyName = "pro_nome";
            this.colProduto.HeaderText = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.ReadOnly = true;
            this.colProduto.Width = 250;
            // 
            // colQtde
            // 
            this.colQtde.DataPropertyName = "itemvenda_qtde";
            this.colQtde.HeaderText = "Quantidade";
            this.colQtde.Name = "colQtde";
            this.colQtde.ReadOnly = true;
            // 
            // colValor
            // 
            this.colValor.DataPropertyName = "itemvenda_valor";
            this.colValor.HeaderText = "Total";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // frmConsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 404);
            this.Controls.Add(this.dataGridItens);
            this.Controls.Add(this.dataGridVenda);
            this.Controls.Add(this.btnPesquizar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaVenda";
            this.Text = "Consulta de Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquizar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridVenda;
        private System.Windows.Forms.DataGridView dataGridItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
    }
}