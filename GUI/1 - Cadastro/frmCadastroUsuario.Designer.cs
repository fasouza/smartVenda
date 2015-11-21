namespace GUI._1___Cadastro
{
    partial class frmCadastroUsuario
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
            this.lbCnpj = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbRazao = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.ComboBox();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.txtTipo);
            this.pnDados.Controls.Add(this.lbCnpj);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.label13);
            this.pnDados.Controls.Add(this.txtStatus);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.txtSenha);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.txtLogin);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.txtCPF);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.lbRazao);
            this.pnDados.Controls.Add(this.lbCpf);
            this.pnDados.Controls.Add(this.txtNome);
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
            // lbCnpj
            // 
            this.lbCnpj.AutoSize = true;
            this.lbCnpj.Location = new System.Drawing.Point(32, 82);
            this.lbCnpj.Name = "lbCnpj";
            this.lbCnpj.Size = new System.Drawing.Size(27, 13);
            this.lbCnpj.TabIndex = 67;
            this.lbCnpj.Text = "CPF";
            this.lbCnpj.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(109, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(61, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "Código";
            // 
            // txtStatus
            // 
            this.txtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.txtStatus.Location = new System.Drawing.Point(107, 184);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(121, 21);
            this.txtStatus.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Status";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(108, 155);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(161, 20);
            this.txtSenha.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Senha";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(108, 129);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(161, 20);
            this.txtLogin.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Login";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(108, 79);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(84, 20);
            this.txtCPF.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Tipo";
            // 
            // lbRazao
            // 
            this.lbRazao.AutoSize = true;
            this.lbRazao.Location = new System.Drawing.Point(32, 56);
            this.lbRazao.Name = "lbRazao";
            this.lbRazao.Size = new System.Drawing.Size(35, 13);
            this.lbRazao.TabIndex = 49;
            this.lbRazao.Text = "Nome";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(31, 82);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(27, 13);
            this.lbCpf.TabIndex = 41;
            this.lbCpf.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(108, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(241, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtTipo
            // 
            this.txtTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.Items.AddRange(new object[] {
            "Usuario",
            "Administrador",
            "Moderado"});
            this.txtTipo.Location = new System.Drawing.Point(108, 103);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(161, 21);
            this.txtTipo.TabIndex = 4;
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Name = "frmCadastroUsuario";
            this.Text = "Cadastro de Usuário";
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCnpj;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbRazao;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox txtTipo;
    }
}
