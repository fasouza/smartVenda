namespace GUI
{
    partial class frmContasPagar
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtVencimento = new System.Windows.Forms.TextBox();
            this.cbPago = new System.Windows.Forms.ComboBox();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.lblPago);
            this.pnDados.Controls.Add(this.cbPago);
            this.pnDados.Controls.Add(this.txtPagamento);
            this.pnDados.Controls.Add(this.txtVencimento);
            this.pnDados.Controls.Add(this.lblFornecedor);
            this.pnDados.Controls.Add(this.txtFornecedor);
            this.pnDados.Controls.Add(this.lblValor);
            this.pnDados.Controls.Add(this.txtValor);
            this.pnDados.Controls.Add(this.lblVencimento);
            this.pnDados.Controls.Add(this.lblPagamento);
            this.pnDados.Controls.Add(this.lblDescricao);
            this.pnDados.Controls.Add(this.Codigo);
            this.pnDados.Controls.Add(this.txtDescricao);
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
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(35, 73);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(367, 20);
            this.txtDescricao.TabIndex = 4;
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(35, 27);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(42, 20);
            this.Codigo.TabIndex = 5;
            this.Codigo.Visible = false;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(32, 57);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Location = new System.Drawing.Point(209, 111);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(61, 13);
            this.lblPagamento.TabIndex = 10;
            this.lblPagamento.Text = "Pagamento";
            this.lblPagamento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Location = new System.Drawing.Point(32, 111);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(63, 13);
            this.lblVencimento.TabIndex = 11;
            this.lblVencimento.Text = "Vencimento";
            this.lblVencimento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(422, 73);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(61, 20);
            this.txtValor.TabIndex = 12;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(419, 57);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 13;
            this.lblValor.Text = "Valor";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(35, 184);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(448, 20);
            this.txtFornecedor.TabIndex = 14;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(32, 168);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 15;
            this.lblFornecedor.Text = "Fornecedor";
            this.lblFornecedor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtVencimento
            // 
            this.txtVencimento.Location = new System.Drawing.Point(35, 130);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Size = new System.Drawing.Size(165, 20);
            this.txtVencimento.TabIndex = 16;
            // 
            // cbPago
            // 
            this.cbPago.FormattingEnabled = true;
            this.cbPago.Items.AddRange(new object[] {
            "Pago",
            "Pendente"});
            this.cbPago.Location = new System.Drawing.Point(393, 130);
            this.cbPago.Name = "cbPago";
            this.cbPago.Size = new System.Drawing.Size(90, 21);
            this.cbPago.TabIndex = 18;
            // 
            // txtPagamento
            // 
            this.txtPagamento.Location = new System.Drawing.Point(212, 130);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(165, 20);
            this.txtPagamento.TabIndex = 17;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(390, 111);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(32, 13);
            this.lblPago.TabIndex = 19;
            this.lblPago.Text = "Pago";
            this.lblPago.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Name = "frmContasPagar";
            this.Text = "Cadastro de Contas a Pagar";
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblVencimento;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtVencimento;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.ComboBox cbPago;
        private System.Windows.Forms.TextBox txtPagamento;
       }
}
