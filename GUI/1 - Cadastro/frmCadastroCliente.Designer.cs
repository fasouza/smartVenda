namespace GUI
{
    partial class frmCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCliente));
            this.lbCliente = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rbnPessoaFísica = new System.Windows.Forms.RadioButton();
            this.rbnPessoajuridica = new System.Windows.Forms.RadioButton();
            this.lbCpf = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lbRg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.groupBox1);
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
            this.pnDados.Controls.Add(this.txtCPF);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.txtRG);
            this.pnDados.Controls.Add(this.lbRg);
            this.pnDados.Controls.Add(this.lbCpf);
            this.pnDados.Controls.Add(this.txtNome);
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
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(29, 75);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(39, 13);
            this.lbCliente.TabIndex = 0;
            this.lbCliente.Text = "Cliente";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(105, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(296, 20);
            this.txtNome.TabIndex = 4;
            // 
            // rbnPessoaFísica
            // 
            this.rbnPessoaFísica.AutoSize = true;
            this.rbnPessoaFísica.Checked = true;
            this.rbnPessoaFísica.Location = new System.Drawing.Point(12, 14);
            this.rbnPessoaFísica.Name = "rbnPessoaFísica";
            this.rbnPessoaFísica.Size = new System.Drawing.Size(92, 17);
            this.rbnPessoaFísica.TabIndex = 2;
            this.rbnPessoaFísica.TabStop = true;
            this.rbnPessoaFísica.Text = "Pessoa Física";
            this.rbnPessoaFísica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbnPessoaFísica.UseVisualStyleBackColor = true;
            this.rbnPessoaFísica.CheckedChanged += new System.EventHandler(this.rbnPessoaFísica_CheckedChanged);
            // 
            // rbnPessoajuridica
            // 
            this.rbnPessoajuridica.AutoSize = true;
            this.rbnPessoajuridica.Location = new System.Drawing.Point(169, 14);
            this.rbnPessoajuridica.Name = "rbnPessoajuridica";
            this.rbnPessoajuridica.Size = new System.Drawing.Size(101, 17);
            this.rbnPessoajuridica.TabIndex = 3;
            this.rbnPessoajuridica.Text = "Pessoa Jurídica";
            this.rbnPessoajuridica.UseVisualStyleBackColor = true;
            this.rbnPessoajuridica.CheckedChanged += new System.EventHandler(this.rbnPessoajuridica_CheckedChanged);
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(29, 101);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(27, 13);
            this.lbCpf.TabIndex = 4;
            this.lbCpf.Text = "CPF";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(302, 98);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 20);
            this.txtRG.TabIndex = 6;
            // 
            // lbRg
            // 
            this.lbRg.AutoSize = true;
            this.lbRg.Location = new System.Drawing.Point(274, 101);
            this.lbRg.Name = "lbRg";
            this.lbRg.Size = new System.Drawing.Size(23, 13);
            this.lbRg.TabIndex = 6;
            this.lbRg.Text = "RG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "CEP";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(106, 98);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(97, 20);
            this.txtCPF.TabIndex = 5;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(106, 148);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(218, 20);
            this.txtEndereco.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Endereço";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(106, 174);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(296, 20);
            this.txtBairro.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bairro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Estado";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(106, 200);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(295, 20);
            this.txtCidade.TabIndex = 11;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(106, 123);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(68, 20);
            this.txtCEP.TabIndex = 7;
            this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
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
            this.txtEstado.Location = new System.Drawing.Point(106, 229);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(121, 21);
            this.txtEstado.TabIndex = 12;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(106, 256);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(86, 20);
            this.txtTelefone.TabIndex = 13;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(106, 282);
            this.txtCelular.Mask = "(99) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(86, 20);
            this.txtCelular.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Telefone";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(107, 46);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(67, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Código";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(354, 148);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(48, 20);
            this.txtNumero.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(329, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Nº";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 308);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(296, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 311);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "E-Mail";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnPessoajuridica);
            this.groupBox1.Controls.Add(this.rbnPessoaFísica);
            this.groupBox1.Location = new System.Drawing.Point(253, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 37);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Cliente";
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroCliente";
            this.Text = "Cadastro de Cliente";
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.RadioButton rbnPessoajuridica;
        private System.Windows.Forms.RadioButton rbnPessoaFísica;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lbRg;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.ComboBox txtEstado;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
