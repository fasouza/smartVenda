namespace GUI
{
    partial class frmContasReceber
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbPago = new System.Windows.Forms.ComboBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.txtVencimento = new System.Windows.Forms.DateTimePicker();
            this.txtPagamento = new System.Windows.Forms.DateTimePicker();
            this.btnAddFor = new System.Windows.Forms.Button();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.dgvDados);
            this.pnDados.Controls.Add(this.btnAddFor);
            this.pnDados.Controls.Add(this.txtPagamento);
            this.pnDados.Controls.Add(this.cbCliente);
            this.pnDados.Controls.Add(this.txtVencimento);
            this.pnDados.Controls.Add(this.lblPago);
            this.pnDados.Controls.Add(this.cbPago);
            this.pnDados.Controls.Add(this.lblCliente);
            this.pnDados.Controls.Add(this.lblValor);
            this.pnDados.Controls.Add(this.txtValor);
            this.pnDados.Controls.Add(this.lblVencimento);
            this.pnDados.Controls.Add(this.lblPagamento);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Size = new System.Drawing.Size(614, 511);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(11, 525);
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
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(18, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(42, 20);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.Visible = false;
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Location = new System.Drawing.Point(358, 115);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(61, 13);
            this.lblPagamento.TabIndex = 10;
            this.lblPagamento.Text = "Pagamento";
            this.lblPagamento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Location = new System.Drawing.Point(106, 115);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(63, 13);
            this.lblVencimento.TabIndex = 11;
            this.lblVencimento.Text = "Vencimento";
            this.lblVencimento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(18, 131);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(78, 20);
            this.txtValor.TabIndex = 12;
            this.txtValor.Text = "0,00";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(15, 115);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 13;
            this.lblValor.Text = "Valor";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(15, 56);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 15;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbPago
            // 
            this.cbPago.FormattingEnabled = true;
            this.cbPago.Items.AddRange(new object[] {
            "Pago",
            "Pendente"});
            this.cbPago.Location = new System.Drawing.Point(498, 72);
            this.cbPago.Name = "cbPago";
            this.cbPago.Size = new System.Drawing.Size(98, 21);
            this.cbPago.TabIndex = 18;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(495, 56);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(37, 13);
            this.lblPago.TabIndex = 19;
            this.lblPago.Text = "Status";
            this.lblPago.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtVencimento
            // 
            this.txtVencimento.Location = new System.Drawing.Point(109, 131);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Size = new System.Drawing.Size(235, 20);
            this.txtVencimento.TabIndex = 20;
            // 
            // txtPagamento
            // 
            this.txtPagamento.Location = new System.Drawing.Point(361, 131);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(235, 20);
            this.txtPagamento.TabIndex = 21;
            // 
            // btnAddFor
            // 
            this.btnAddFor.Location = new System.Drawing.Point(442, 70);
            this.btnAddFor.Name = "btnAddFor";
            this.btnAddFor.Size = new System.Drawing.Size(28, 23);
            this.btnAddFor.TabIndex = 24;
            this.btnAddFor.Text = "+";
            this.btnAddFor.UseVisualStyleBackColor = true;
            this.btnAddFor.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(18, 72);
            this.cbCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(419, 21);
            this.cbCliente.TabIndex = 23;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(18, 170);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(578, 329);
            this.dgvDados.TabIndex = 25;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            // 
            // frmContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 623);
            this.Name = "frmContasReceber";
            this.Text = "Cadastro de Contas a Receber";
            this.Load += new System.EventHandler(this.frmContasReceber_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblVencimento;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.ComboBox cbPago;
        private System.Windows.Forms.DateTimePicker txtPagamento;
        private System.Windows.Forms.DateTimePicker txtVencimento;
        private System.Windows.Forms.Button btnAddFor;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.DataGridView dgvDados;
       }
}
