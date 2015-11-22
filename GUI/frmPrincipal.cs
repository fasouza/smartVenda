using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Modelo;
using System.IO;
using DAL;
using System.Data.SqlClient;
using GUI._3___Relatório;
using GUI._1___Cadastro;

namespace GUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog(); //chama o form e não permite alteração em outro form enquanto ele estiver aberto
            f.Dispose(); //matar o objeto form(quando fechar elemina o mesmo)
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria f = new frmConsultaCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        
        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria f = new frmCadastroSubCategoria();
            f.ShowDialog(); //chama o form e não permite alteração em outro form enquanto ele estiver aberto
            f.Dispose(); //matar o objeto form(quando fechar elemina o mesmo)
        }

        

        private void subCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaSubcategoria f = new frmConsultaSubcategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUnidadeMedida f = new frmCadastroUnidadeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeMedida f = new frmConsultaUnidadeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto f = new frmCadastroProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void configuraçãoDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracaoBancoDados f = new frmConfiguracaoBancoDados();
            f.ShowDialog();
            f.Dispose();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //verifica conexão com o banco
            try
            {
                StreamReader arquivo = new StreamReader("Configuracao.txt");
                DadosConexao.servidor   = arquivo.ReadLine();
                DadosConexao.banco      = arquivo.ReadLine();
                DadosConexao.usuario    = arquivo.ReadLine();
                DadosConexao.senha      = arquivo.ReadLine();
                arquivo.Close();
                
                //testar conexao
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();

                
                
            }
            catch(SqlException errob)
            {
                MessageBox.Show(errob+" Erro ao se conectar no banco de dados\n"+
                                "Acesse as configurações do banco de dados e informe os parâmetros de conexão");
            }

            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }
        }

        private void backupDoBancoDeBadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackupBanco f = new frmBackupBanco();
            f.ShowDialog();
            f.Dispose();
        }

        private void tipoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroTipoPagamento f = new frmCadastroTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void tipoDePagamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaTipoPagamento f = new frmConsultaTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente f = new frmCadastroCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor f = new frmCadastroFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void relatórioDeCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioCategoria f = new frmRelatorioCategoria();
            f.ShowDialog();
            f.Dispose();

        }

        private void relatórioDeSubCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaCategoriaSubCategoria f = new frmListaCategoriaSubCategoria();
            f.ShowDialog();
            f.Dispose();

        }       

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario f = new frmCadastroUsuario();
            f.ShowDialog();
            f.Dispose();

        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            frmRelatorioProduto f = new frmRelatorioProduto();
            f.ShowDialog();
            f.Dispose();

        }

        private void toolStripMenuItem2_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void porCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioProdutoPorcategoria f = new frmRelatorioProdutoPorcategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                 
                }
            }          

        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContasPagar f = new frmContasPagar();
            f.ShowDialog();
            f.Dispose();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroVenda f = new frmCadastroVenda();
            f.ShowDialog();
            f.Dispose();
        }       
    }
}
