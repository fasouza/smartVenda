namespace GUI
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadeDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tipoDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadeDeMedidaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tipoDePagamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rlatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoDoBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDoBancoDeBadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.rlatórioToolStripMenuItem,
            this.ferramentaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.subCategoriaToolStripMenuItem,
            this.unidadeDeMedidaToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.toolStripSeparator1,
            this.clienteToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.toolStripSeparator2,
            this.tipoDePagamentoToolStripMenuItem,
            this.toolStripSeparator6,
            this.usuarioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // subCategoriaToolStripMenuItem
            // 
            this.subCategoriaToolStripMenuItem.Name = "subCategoriaToolStripMenuItem";
            this.subCategoriaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.subCategoriaToolStripMenuItem.Text = "SubCategoria";
            this.subCategoriaToolStripMenuItem.Click += new System.EventHandler(this.subCategoriaToolStripMenuItem_Click);
            // 
            // unidadeDeMedidaToolStripMenuItem
            // 
            this.unidadeDeMedidaToolStripMenuItem.Name = "unidadeDeMedidaToolStripMenuItem";
            this.unidadeDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.unidadeDeMedidaToolStripMenuItem.Text = "Unidade de Medida";
            this.unidadeDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.unidadeDeMedidaToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // tipoDePagamentoToolStripMenuItem
            // 
            this.tipoDePagamentoToolStripMenuItem.Name = "tipoDePagamentoToolStripMenuItem";
            this.tipoDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.tipoDePagamentoToolStripMenuItem.Text = "Tipo de Pagamento";
            this.tipoDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.tipoDePagamentoToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(175, 6);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem1,
            this.subCategoriaToolStripMenuItem1,
            this.unidadeDeMedidaToolStripMenuItem1,
            this.produtoToolStripMenuItem1,
            this.toolStripSeparator3,
            this.clienteToolStripMenuItem1,
            this.fornecedorToolStripMenuItem1,
            this.toolStripSeparator4,
            this.tipoDePagamentoToolStripMenuItem1,
            this.toolStripSeparator7,
            this.usuárioToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // categoriaToolStripMenuItem1
            // 
            this.categoriaToolStripMenuItem1.Name = "categoriaToolStripMenuItem1";
            this.categoriaToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.categoriaToolStripMenuItem1.Text = "Categoria";
            this.categoriaToolStripMenuItem1.Click += new System.EventHandler(this.categoriaToolStripMenuItem1_Click);
            // 
            // subCategoriaToolStripMenuItem1
            // 
            this.subCategoriaToolStripMenuItem1.Name = "subCategoriaToolStripMenuItem1";
            this.subCategoriaToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.subCategoriaToolStripMenuItem1.Text = "SubCategoria";
            this.subCategoriaToolStripMenuItem1.Click += new System.EventHandler(this.subCategoriaToolStripMenuItem1_Click);
            // 
            // unidadeDeMedidaToolStripMenuItem1
            // 
            this.unidadeDeMedidaToolStripMenuItem1.Name = "unidadeDeMedidaToolStripMenuItem1";
            this.unidadeDeMedidaToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.unidadeDeMedidaToolStripMenuItem1.Text = "Unidade de Medida";
            this.unidadeDeMedidaToolStripMenuItem1.Click += new System.EventHandler(this.unidadeDeMedidaToolStripMenuItem1_Click);
            // 
            // produtoToolStripMenuItem1
            // 
            this.produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            this.produtoToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.produtoToolStripMenuItem1.Text = "Produto";
            this.produtoToolStripMenuItem1.Click += new System.EventHandler(this.produtoToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(175, 6);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // fornecedorToolStripMenuItem1
            // 
            this.fornecedorToolStripMenuItem1.Name = "fornecedorToolStripMenuItem1";
            this.fornecedorToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.fornecedorToolStripMenuItem1.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem1.Click += new System.EventHandler(this.fornecedorToolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(175, 6);
            // 
            // tipoDePagamentoToolStripMenuItem1
            // 
            this.tipoDePagamentoToolStripMenuItem1.Name = "tipoDePagamentoToolStripMenuItem1";
            this.tipoDePagamentoToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.tipoDePagamentoToolStripMenuItem1.Text = "Tipo de Pagamento";
            this.tipoDePagamentoToolStripMenuItem1.Click += new System.EventHandler(this.tipoDePagamentoToolStripMenuItem1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(175, 6);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // rlatórioToolStripMenuItem
            // 
            this.rlatórioToolStripMenuItem.Name = "rlatórioToolStripMenuItem";
            this.rlatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.rlatórioToolStripMenuItem.Text = "Relatório";
            // 
            // ferramentaToolStripMenuItem
            // 
            this.ferramentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçãoDoBancoDeDadosToolStripMenuItem,
            this.backupDoBancoDeBadosToolStripMenuItem,
            this.toolStripSeparator5,
            this.calculadoraToolStripMenuItem});
            this.ferramentaToolStripMenuItem.Name = "ferramentaToolStripMenuItem";
            this.ferramentaToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.ferramentaToolStripMenuItem.Text = "Ferramenta";
            // 
            // configuraçãoDoBancoDeDadosToolStripMenuItem
            // 
            this.configuraçãoDoBancoDeDadosToolStripMenuItem.Name = "configuraçãoDoBancoDeDadosToolStripMenuItem";
            this.configuraçãoDoBancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.configuraçãoDoBancoDeDadosToolStripMenuItem.Text = "Configuração do Banco de Dados";
            this.configuraçãoDoBancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.configuraçãoDoBancoDeDadosToolStripMenuItem_Click);
            // 
            // backupDoBancoDeBadosToolStripMenuItem
            // 
            this.backupDoBancoDeBadosToolStripMenuItem.Name = "backupDoBancoDeBadosToolStripMenuItem";
            this.backupDoBancoDeBadosToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.backupDoBancoDeBadosToolStripMenuItem.Text = "Backup do Banco de Bados";
            this.backupDoBancoDeBadosToolStripMenuItem.Click += new System.EventHandler(this.backupDoBancoDeBadosToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(248, 6);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 519);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rlatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadeDeMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem subCategoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unidadeDeMedidaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoDoBancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupDoBancoDeBadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tipoDePagamentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}