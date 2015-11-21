namespace GUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbesqueceSenha = new System.Windows.Forms.Label();
            this.txtEsqueceLogin = new System.Windows.Forms.TextBox();
            this.txtEsqueceSenha = new System.Windows.Forms.TextBox();
            this.lbEsqSenha = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbEsqlogin = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnMudarSenha = new System.Windows.Forms.Button();
            this.btnCancelaNovaSenha = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbAlteradaSucesso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.White;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnEntrar.Location = new System.Drawing.Point(53, 177);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(86, 23);
            this.btnEntrar.TabIndex = 8;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbLogin.Location = new System.Drawing.Point(59, 108);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(53, 20);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "Login";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbSenha.Location = new System.Drawing.Point(59, 133);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(61, 20);
            this.lbSenha.TabIndex = 3;
            this.lbSenha.Text = "Senha";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(137, 107);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(83, 20);
            this.txtLogin.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(137, 136);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(83, 20);
            this.txtSenha.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCancelar.Location = new System.Drawing.Point(160, 177);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbesqueceSenha
            // 
            this.lbesqueceSenha.AutoSize = true;
            this.lbesqueceSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbesqueceSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbesqueceSenha.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbesqueceSenha.Location = new System.Drawing.Point(174, 9);
            this.lbesqueceSenha.Name = "lbesqueceSenha";
            this.lbesqueceSenha.Size = new System.Drawing.Size(140, 17);
            this.lbesqueceSenha.TabIndex = 7;
            this.lbesqueceSenha.Text = "Esqueceu a Senha? ";
            this.lbesqueceSenha.Click += new System.EventHandler(this.lbesqueceSenha_Click);
            // 
            // txtEsqueceLogin
            // 
            this.txtEsqueceLogin.Location = new System.Drawing.Point(137, 107);
            this.txtEsqueceLogin.Name = "txtEsqueceLogin";
            this.txtEsqueceLogin.Size = new System.Drawing.Size(83, 20);
            this.txtEsqueceLogin.TabIndex = 2;
            this.txtEsqueceLogin.Visible = false;
            // 
            // txtEsqueceSenha
            // 
            this.txtEsqueceSenha.Location = new System.Drawing.Point(137, 136);
            this.txtEsqueceSenha.Name = "txtEsqueceSenha";
            this.txtEsqueceSenha.PasswordChar = '*';
            this.txtEsqueceSenha.Size = new System.Drawing.Size(83, 20);
            this.txtEsqueceSenha.TabIndex = 3;
            this.txtEsqueceSenha.Visible = false;
            // 
            // lbEsqSenha
            // 
            this.lbEsqSenha.AutoSize = true;
            this.lbEsqSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEsqSenha.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbEsqSenha.Location = new System.Drawing.Point(59, 137);
            this.lbEsqSenha.Name = "lbEsqSenha";
            this.lbEsqSenha.Size = new System.Drawing.Size(61, 20);
            this.lbEsqSenha.TabIndex = 11;
            this.lbEsqSenha.Text = "Senha";
            this.lbEsqSenha.Visible = false;
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbCPF.Location = new System.Drawing.Point(59, 77);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(43, 20);
            this.lbCPF.TabIndex = 1;
            this.lbCPF.Text = "CPF";
            this.lbCPF.Visible = false;
            // 
            // lbEsqlogin
            // 
            this.lbEsqlogin.AutoSize = true;
            this.lbEsqlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEsqlogin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbEsqlogin.Location = new System.Drawing.Point(59, 105);
            this.lbEsqlogin.Name = "lbEsqlogin";
            this.lbEsqlogin.Size = new System.Drawing.Size(53, 20);
            this.lbEsqlogin.TabIndex = 14;
            this.lbEsqlogin.Text = "Login";
            this.lbEsqlogin.Visible = false;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(137, 79);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(83, 20);
            this.txtCPF.TabIndex = 1;
            this.txtCPF.Visible = false;
            // 
            // btnMudarSenha
            // 
            this.btnMudarSenha.BackColor = System.Drawing.Color.White;
            this.btnMudarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMudarSenha.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnMudarSenha.Location = new System.Drawing.Point(53, 177);
            this.btnMudarSenha.Name = "btnMudarSenha";
            this.btnMudarSenha.Size = new System.Drawing.Size(86, 23);
            this.btnMudarSenha.TabIndex = 4;
            this.btnMudarSenha.Text = "Mudar";
            this.btnMudarSenha.UseVisualStyleBackColor = false;
            this.btnMudarSenha.Visible = false;
            this.btnMudarSenha.Click += new System.EventHandler(this.btnMudarSenha_Click);
            // 
            // btnCancelaNovaSenha
            // 
            this.btnCancelaNovaSenha.BackColor = System.Drawing.Color.White;
            this.btnCancelaNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelaNovaSenha.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCancelaNovaSenha.Location = new System.Drawing.Point(160, 177);
            this.btnCancelaNovaSenha.Name = "btnCancelaNovaSenha";
            this.btnCancelaNovaSenha.Size = new System.Drawing.Size(90, 23);
            this.btnCancelaNovaSenha.TabIndex = 5;
            this.btnCancelaNovaSenha.Text = "Voltar";
            this.btnCancelaNovaSenha.UseVisualStyleBackColor = false;
            this.btnCancelaNovaSenha.Visible = false;
            this.btnCancelaNovaSenha.Click += new System.EventHandler(this.btnCancelaNovaSenha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.Sem_Título_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbAlteradaSucesso
            // 
            this.lbAlteradaSucesso.AutoSize = true;
            this.lbAlteradaSucesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlteradaSucesso.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbAlteradaSucesso.Location = new System.Drawing.Point(28, 219);
            this.lbAlteradaSucesso.Name = "lbAlteradaSucesso";
            this.lbAlteradaSucesso.Size = new System.Drawing.Size(253, 13);
            this.lbAlteradaSucesso.TabIndex = 15;
            this.lbAlteradaSucesso.Text = "Senha alterada com sucesso!, Faça Login..";
            this.lbAlteradaSucesso.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 438);
            this.Controls.Add(this.lbAlteradaSucesso);
            this.Controls.Add(this.btnCancelaNovaSenha);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lbEsqlogin);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.txtEsqueceSenha);
            this.Controls.Add(this.txtEsqueceLogin);
            this.Controls.Add(this.lbesqueceSenha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbEsqSenha);
            this.Controls.Add(this.btnMudarSenha);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartVenda";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbesqueceSenha;
        private System.Windows.Forms.TextBox txtEsqueceLogin;
        private System.Windows.Forms.TextBox txtEsqueceSenha;
        private System.Windows.Forms.Label lbEsqSenha;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbEsqlogin;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Button btnMudarSenha;
        private System.Windows.Forms.Button btnCancelaNovaSenha;
        private System.Windows.Forms.Label lbAlteradaSucesso;
    }
}