using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Ferramentas;

namespace GUI
{
    public partial class frmBackupBanco : Form
    {
        public frmBackupBanco()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {

           
                SaveFileDialog d = new SaveFileDialog();
                d.Filter = "Backup Files|*.bak";
                d.ShowDialog();
                if (d.FileName != "")
                {
                    String nomeBanco = DadosConexao.banco;
                    String localBackup = d.FileName;
                    String conexao = @"Data Source=" + DadosConexao.servidor +";Initial Catalog=master; User="+
                                    DadosConexao.usuario+";Password="+DadosConexao.senha;

                    SQLServerBackup.BackupDataBase(conexao, nomeBanco, d.FileName);
                    MessageBox.Show("Backup realisado com sucesso!");
                 }
            }
            catch (Exception erro)
            {
                
               MessageBox.Show(erro.Message);
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
               OpenFileDialog d = new OpenFileDialog();
                d.Filter = "Backup Files|*.bak";
                d.ShowDialog();
                if (d.FileName != "")
                {
                    String nomeBanco = DadosConexao.banco;
                    String localBackup = d.FileName;
                    String conexao = @"Data Source=" + DadosConexao.servidor + ";Initial Catalog=master; User=" +
                                    DadosConexao.usuario + ";Password=" + DadosConexao.senha;

                    SQLServerBackup.RestauraDatabase(conexao, nomeBanco, d.FileName);                    
                    MessageBox.Show("Backup restaurado com sucesso!");
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }
    }
}
