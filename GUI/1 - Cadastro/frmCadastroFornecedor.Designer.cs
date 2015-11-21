namespace GUI
{
    partial class frmCadastroFornecedor
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
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.txtIe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.txtIe);
            this.pnDados.Controls.Add(this.lbCnpj);
            this.pnDados.Controls.Add(this.txtCnpj);
            this.pnDados.Controls.Add(this.txtEmail);
            this.pnDados.Controls.Add(this.label15);
            this.pnDados.Controls.Add(this.txtNumero);
            this.pnDados.Controls.Add(this.label14);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.label13);
            this.pnDados.Controls.Add(this.txtCelular);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.txtTelefone);
            this.pnDados.Controls.Add(this.txtEstado);
            this.pnDados.Controls.Add(this.txtCEP);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.txtCidade);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.txtBairro);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.txtEndereco);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.lbCpf);
            this.pnDados.Controls.Add(this.txtRazao);
            this.pnDados.Controls.Add(this.lbCliente);
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
            this.lbCnpj.Location = new System.Drawing.Point(20, 97);
            this.lbCnpj.Name = "lbCnpj";
            this.lbCnpj.Size = new System.Drawing.Size(34, 13);
            this.lbCnpj.TabIndex = 67;
            this.lbCnpj.Text = "CNPJ";
            this.lbCnpj.Visible = false;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(95, 94);
            this.txtCnpj.Mask = "00,000,000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(106, 20);
            this.txtCnpj.TabIndex = 43;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(96, 304);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(296, 20);
            this.txtEmail.TabIndex = 57;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 307);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 66;
            this.label15.Text = "E-Mail";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(344, 144);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(48, 20);
            this.txtNumero.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(319, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 65;
            this.label14.Text = "Nº";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(96, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(67, 20);
            this.txtCodigo.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "Código";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(96, 278);
            this.txtCelular.Mask = "(99) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(83, 20);
            this.txtCelular.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Celular";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(96, 252);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(83, 20);
            this.txtTelefone.TabIndex = 54;
            // 
            // txtEstado
            // 
            this.txtEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEstado.FormattingEnabled = true;
            this.txtEstado.Items.AddRange(new object[] {
            "",
            "Acre\t ",
            "Alagoas ",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão\t",
            "Mato Grosso",
            "Mato Grosso do Sul ",
            "Minas Gerais\t ",
            "Pará\t ",
            "Paraíba\t\t ",
            "Paraná\t",
            "Pernambuco\t",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte\t",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.txtEstado.Location = new System.Drawing.Point(96, 225);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(121, 21);
            this.txtEstado.TabIndex = 52;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(96, 119);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(67, 20);
            this.txtCEP.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Estado";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(96, 196);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(295, 20);
            this.txtCidade.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Cidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Telefone";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(96, 170);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(296, 20);
            this.txtBairro.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Bairro";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(96, 144);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(218, 20);
            this.txtEndereco.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "CEP";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(19, 97);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(27, 13);
            this.lbCpf.TabIndex = 41;
            this.lbCpf.Text = "CPF";
            // 
            // txtRazao
            // 
            this.txtRazao.Location = new System.Drawing.Point(95, 42);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(296, 20);
            this.txtRazao.TabIndex = 42;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(18, 45);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(70, 13);
            this.lbCliente.TabIndex = 36;
            this.lbCliente.Text = "Razão Social";
            // 
            // txtIe
            // 
            this.txtIe.Location = new System.Drawing.Point(308, 94);
            this.txtIe.Name = "txtIe";
            this.txtIe.Size = new System.Drawing.Size(83, 20);
            this.txtIe.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Inscrição Estadual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(95, 68);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(296, 20);
            this.txtNome.TabIndex = 71;
            // 
            // frmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Name = "frmCadastroFornecedor";
            this.Text = "Cadastro de Fornecedor";
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCnpj;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.ComboBox txtEstado;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
    }
}
