﻿namespace GUI
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.cbPago = new System.Windows.Forms.ComboBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.txtVencimento = new System.Windows.Forms.DateTimePicker();
            this.txtPagamento = new System.Windows.Forms.DateTimePicker();
            this.btnAddFor = new System.Windows.Forms.Button();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.btnAddFor);
            this.pnDados.Controls.Add(this.txtPagamento);
            this.pnDados.Controls.Add(this.cbFornecedor);
            this.pnDados.Controls.Add(this.txtVencimento);
            this.pnDados.Controls.Add(this.lblPago);
            this.pnDados.Controls.Add(this.cbPago);
            this.pnDados.Controls.Add(this.lblFornecedor);
            this.pnDados.Controls.Add(this.lblValor);
            this.pnDados.Controls.Add(this.txtValor);
            this.pnDados.Controls.Add(this.lblVencimento);
            this.pnDados.Controls.Add(this.lblPagamento);
            this.pnDados.Controls.Add(this.lblDescricao);
            this.pnDados.Controls.Add(this.txtCodigo);
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
            this.txtDescricao.Size = new System.Drawing.Size(392, 20);
            this.txtDescricao.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(35, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(42, 20);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.Visible = false;
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
            this.lblPagamento.Location = new System.Drawing.Point(273, 111);
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
            this.txtValor.Location = new System.Drawing.Point(433, 73);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(78, 20);
            this.txtValor.TabIndex = 12;
            this.txtValor.Text = "0,00";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(430, 57);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 13;
            this.lblValor.Text = "Valor";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // cbPago
            // 
            this.cbPago.FormattingEnabled = true;
            this.cbPago.Items.AddRange(new object[] {
            "Pago",
            "Pendente"});
            this.cbPago.Location = new System.Drawing.Point(413, 183);
            this.cbPago.Name = "cbPago";
            this.cbPago.Size = new System.Drawing.Size(98, 21);
            this.cbPago.TabIndex = 18;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(410, 167);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(37, 13);
            this.lblPago.TabIndex = 19;
            this.lblPago.Text = "Status";
            this.lblPago.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtVencimento
            // 
            this.txtVencimento.Location = new System.Drawing.Point(35, 131);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Size = new System.Drawing.Size(235, 20);
            this.txtVencimento.TabIndex = 20;
            // 
            // txtPagamento
            // 
            this.txtPagamento.Location = new System.Drawing.Point(276, 131);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(235, 20);
            this.txtPagamento.TabIndex = 21;
            // 
            // btnAddFor
            // 
            this.btnAddFor.Location = new System.Drawing.Point(379, 183);
            this.btnAddFor.Name = "btnAddFor";
            this.btnAddFor.Size = new System.Drawing.Size(28, 23);
            this.btnAddFor.TabIndex = 24;
            this.btnAddFor.Text = "+";
            this.btnAddFor.UseVisualStyleBackColor = true;
            this.btnAddFor.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(35, 183);
            this.cbFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(339, 21);
            this.cbFornecedor.TabIndex = 23;
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
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblVencimento;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.ComboBox cbPago;
        private System.Windows.Forms.DateTimePicker txtPagamento;
        private System.Windows.Forms.DateTimePicker txtVencimento;
        private System.Windows.Forms.Button btnAddFor;
        private System.Windows.Forms.ComboBox cbFornecedor;
       }
}
