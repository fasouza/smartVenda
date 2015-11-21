using BBL;
using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroVenda : GUI.frmModeloFormularioCadastro
    {
        public int codigo = 0;

        public frmCadastroVenda()
        {
            InitializeComponent();
        }


        public void LimpaTela()
        {
           
        }           
        
        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela(); //limpar tela
            this.alteraBotoes(1);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }
       

        private void frmCadastroVenda_Load(object sender, EventArgs e)
        {
                    
            this.alteraBotoes(1);
            //combo de cliente
            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            cbCliente.DataSource = bll.Localizar("");
            cbCliente.DisplayMember = "cli_nome";
            cbCliente.ValueMember = "cli_cod";

           
            //combo de Produto            
            BLLProduto bllp = new BLLProduto(cx);
            cbCliente.DataSource = bll.Localizar("");
            cbCliente.DisplayMember = "pro_nome";
            cbCliente.ValueMember = "pro_cod";
        }

        
    }
}
