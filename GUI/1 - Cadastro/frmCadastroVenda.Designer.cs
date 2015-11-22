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
            this.btnAddCli = new System.Windows.Forms.Button();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddTipoPag = new System.Windows.Forms.Button();
            this.cbxTipoPagamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumParcelas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridItens = new System.Windows.Forms.DataGridView();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbVenda = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItens)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.lbVenda);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.button3);
            this.pnDados.Controls.Add(this.button2);
            this.pnDados.Controls.Add(this.txtPreco);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.txtQtde);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.cbxProduto);
            this.pnDados.Controls.Add(this.dataGridItens);
            this.pnDados.Controls.Add(this.txtNumParcelas);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.btnAddTipoPag);
            this.pnDados.Controls.Add(this.cbxTipoPagamento);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.btnAddCli);
            this.pnDados.Controls.Add(this.cbxCliente);
            this.pnDados.Controls.Add(this.label3);
            // 
            // btAlterar
            // 
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btnAddCli
            // 
            this.btnAddCli.Location = new System.Drawing.Point(289, 48);
            this.btnAddCli.Name = "btnAddCli";
            this.btnAddCli.Size = new System.Drawing.Size(27, 23);
            this.btnAddCli.TabIndex = 9;
            this.btnAddCli.Text = "+";
            this.btnAddCli.UseVisualStyleBackColor = true;
            this.btnAddCli.Click += new System.EventHandler(this.btnAddCli_Click);
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(12, 49);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(271, 21);
            this.cbxCliente.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cliente";
            // 
            // btnAddTipoPag
            // 
            this.btnAddTipoPag.Location = new System.Drawing.Point(289, 89);
            this.btnAddTipoPag.Name = "btnAddTipoPag";
            this.btnAddTipoPag.Size = new System.Drawing.Size(27, 23);
            this.btnAddTipoPag.TabIndex = 12;
            this.btnAddTipoPag.Text = "+";
            this.btnAddTipoPag.UseVisualStyleBackColor = true;
            this.btnAddTipoPag.Click += new System.EventHandler(this.btnAddTipoPag_Click);
            // 
            // cbxTipoPagamento
            // 
            this.cbxTipoPagamento.FormattingEnabled = true;
            this.cbxTipoPagamento.Location = new System.Drawing.Point(12, 89);
            this.cbxTipoPagamento.Name = "cbxTipoPagamento";
            this.cbxTipoPagamento.Size = new System.Drawing.Size(271, 21);
            this.cbxTipoPagamento.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tipo de Pagamento";
            // 
            // txtNumParcelas
            // 
            this.txtNumParcelas.Location = new System.Drawing.Point(12, 129);
            this.txtNumParcelas.Name = "txtNumParcelas";
            this.txtNumParcelas.Size = new System.Drawing.Size(97, 20);
            this.txtNumParcelas.TabIndex = 14;
            this.txtNumParcelas.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Número de Parcelas";
            // 
            // dataGridItens
            // 
            this.dataGridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProduto,
            this.colQtde,
            this.colValor});
            this.dataGridItens.Location = new System.Drawing.Point(12, 194);
            this.dataGridItens.Name = "dataGridItens";
            this.dataGridItens.Size = new System.Drawing.Size(578, 134);
            this.dataGridItens.TabIndex = 15;
            // 
            // colProduto
            // 
            this.colProduto.DataPropertyName = "ItemVendaProduto";
            this.colProduto.HeaderText = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.Width = 250;
            // 
            // colQtde
            // 
            this.colQtde.DataPropertyName = "ItemVendaQtde";
            this.colQtde.HeaderText = "Quantidade";
            this.colQtde.Name = "colQtde";
            // 
            // colValor
            // 
            this.colValor.DataPropertyName = "ItemVendaValorString";
            this.colValor.HeaderText = "Total";
            this.colValor.Name = "colValor";
            // 
            // cbxProduto
            // 
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(12, 168);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(304, 21);
            this.cbxProduto.TabIndex = 16;
            this.cbxProduto.SelectionChangeCommitted += new System.EventHandler(this.cbxProduto_SelectionChangeCommitted);
            this.cbxProduto.SelectedValueChanged += new System.EventHandler(this.cbxProduto_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Produto";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(322, 168);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(97, 20);
            this.txtQtde.TabIndex = 19;
            this.txtQtde.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Quantidade";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(425, 168);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(97, 20);
            this.txtPreco.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Preço";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(528, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(563, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(445, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(428, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 29);
            this.label8.TabIndex = 25;
            this.label8.Text = "R$ 0,00";
            // 
            // lbVenda
            // 
            this.lbVenda.AutoSize = true;
            this.lbVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVenda.Location = new System.Drawing.Point(275, 10);
            this.lbVenda.Name = "lbVenda";
            this.lbVenda.Size = new System.Drawing.Size(75, 26);
            this.lbVenda.TabIndex = 26;
            this.lbVenda.Text = "Venda";
            // 
            // frmCadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Name = "frmCadastroVenda";
            this.Text = "Cadastro de Vendas";
            this.Load += new System.EventHandler(this.frmCadastroVenda_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddTipoPag;
        private System.Windows.Forms.ComboBox cbxTipoPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCli;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridItens;
        private System.Windows.Forms.TextBox txtNumParcelas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.Label lbVenda;
    }
}
