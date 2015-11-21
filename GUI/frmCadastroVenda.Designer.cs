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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroVenda));
            this.txtFornNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNParcelas = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPesquizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.txtTipoPagamento = new System.Windows.Forms.ComboBox();
            this.txtDataVenda = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.txtFornNome);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.txtNParcelas);
            this.pnDados.Controls.Add(this.txtValorTotal);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.btnPesquizar);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtFornecedor);
            this.pnDados.Controls.Add(this.txtStatus);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtNota);
            this.pnDados.Controls.Add(this.txtTipoPagamento);
            this.pnDados.Controls.Add(this.txtDataVenda);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.label1);
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
            // btSalvar
            // 
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // txtFornNome
            // 
            this.txtFornNome.Location = new System.Drawing.Point(204, 178);
            this.txtFornNome.Name = "txtFornNome";
            this.txtFornNome.Size = new System.Drawing.Size(262, 20);
            this.txtFornNome.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Nº Parcelas";
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Total";
            // 
            // txtNParcelas
            // 
            this.txtNParcelas.Location = new System.Drawing.Point(140, 230);
            this.txtNParcelas.Name = "txtNParcelas";
            this.txtNParcelas.Size = new System.Drawing.Size(70, 20);
            this.txtNParcelas.TabIndex = 32;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(140, 204);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(70, 20);
            this.txtValorTotal.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Fornecedor";
            // 
            // btnPesquizar
            // 
            this.btnPesquizar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquizar.Image")));
            this.btnPesquizar.Location = new System.Drawing.Point(472, 173);
            this.btnPesquizar.Name = "btnPesquizar";
            this.btnPesquizar.Size = new System.Drawing.Size(41, 28);
            this.btnPesquizar.TabIndex = 29;
            this.btnPesquizar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tipo de Pagamento";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(140, 178);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(68, 20);
            this.txtFornecedor.TabIndex = 26;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(140, 152);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(121, 20);
            this.txtStatus.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nota Fiscal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Data da Venda";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(140, 99);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(70, 20);
            this.txtNota.TabIndex = 22;
            // 
            // txtTipoPagamento
            // 
            this.txtTipoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipoPagamento.FormattingEnabled = true;
            this.txtTipoPagamento.Location = new System.Drawing.Point(140, 125);
            this.txtTipoPagamento.Name = "txtTipoPagamento";
            this.txtTipoPagamento.Size = new System.Drawing.Size(121, 21);
            this.txtTipoPagamento.TabIndex = 21;
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Location = new System.Drawing.Point(140, 73);
            this.txtDataVenda.Mask = "00/00/0000";
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(70, 20);
            this.txtDataVenda.TabIndex = 20;
            this.txtDataVenda.ValidatingType = typeof(System.DateTime);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(140, 47);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(68, 20);
            this.txtCodigo.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Código";
            // 
            // frmCadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Name = "frmCadastroVenda";
            this.Text = "Cadastro de Venda";
            this.Load += new System.EventHandler(this.frmCadastroVenda_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFornNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNParcelas;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPesquizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.ComboBox txtTipoPagamento;
        private System.Windows.Forms.MaskedTextBox txtDataVenda;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
    }
}
