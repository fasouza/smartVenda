namespace GUI
{
    partial class frmCadastroVenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.gpbNovaVenda = new System.Windows.Forms.GroupBox();
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.gpbNovaVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.gpbNovaVenda);
            this.pnDados.Controls.Add(this.btnNovaVenda);
            this.pnDados.Controls.Add(this.cbCliente);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Size = new System.Drawing.Size(614, 389);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(21, 403);
            // 
            // btAlterar
            // 
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cliente";
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(74, 19);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(342, 21);
            this.cbCliente.TabIndex = 1;
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Location = new System.Drawing.Point(432, 18);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(75, 23);
            this.btnNovaVenda.TabIndex = 2;
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            // 
            // gpbNovaVenda
            // 
            this.gpbNovaVenda.Controls.Add(this.btnNovoItem);
            this.gpbNovaVenda.Controls.Add(this.dataGridView1);
            this.gpbNovaVenda.Controls.Add(this.txtValor);
            this.gpbNovaVenda.Controls.Add(this.label5);
            this.gpbNovaVenda.Controls.Add(this.txtQuant);
            this.gpbNovaVenda.Controls.Add(this.txtCodigo);
            this.gpbNovaVenda.Controls.Add(this.cbxProduto);
            this.gpbNovaVenda.Controls.Add(this.label4);
            this.gpbNovaVenda.Controls.Add(this.label3);
            this.gpbNovaVenda.Controls.Add(this.label2);
            this.gpbNovaVenda.Location = new System.Drawing.Point(12, 55);
            this.gpbNovaVenda.Name = "gpbNovaVenda";
            this.gpbNovaVenda.Size = new System.Drawing.Size(585, 323);
            this.gpbNovaVenda.TabIndex = 17;
            this.gpbNovaVenda.TabStop = false;
            this.gpbNovaVenda.Text = "NovaVenda";
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.Location = new System.Drawing.Point(212, 94);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(75, 23);
            this.btnNovoItem.TabIndex = 18;
            this.btnNovoItem.Text = "Novo Item";
            this.btnNovoItem.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProduto,
            this.Produto,
            this.Quantidade,
            this.Valor});
            this.dataGridView1.Location = new System.Drawing.Point(9, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(570, 173);
            this.dataGridView1.TabIndex = 24;
            // 
            // CodProduto
            // 
            this.CodProduto.HeaderText = "CódProduto";
            this.CodProduto.MinimumWidth = 40;
            this.CodProduto.Name = "CodProduto";
            this.CodProduto.ReadOnly = true;
            this.CodProduto.Width = 70;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.MinimumWidth = 40;
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 200;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.MinimumWidth = 40;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 70;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(74, 97);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Valor";
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(74, 71);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(100, 20);
            this.txtQuant.TabIndex = 21;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(74, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(52, 20);
            this.txtCodigo.TabIndex = 20;
            // 
            // cbxProduto
            // 
            this.cbxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(74, 47);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(281, 21);
            this.cbxProduto.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Código";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI.Properties.Resources.Sem_Título_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(652, 501);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmCadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(652, 501);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCadastroVenda";
            this.Text = "Cadastro de Venda";
            this.Load += new System.EventHandler(this.frmCadastroVenda_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.gpbNovaVenda.ResumeLayout(false);
            this.gpbNovaVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.GroupBox gpbNovaVenda;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
