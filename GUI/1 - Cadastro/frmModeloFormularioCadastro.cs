﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmModeloFormularioCadastro : Form
    {
        public String operacao;
        public frmModeloFormularioCadastro()
        {
            InitializeComponent();
        }
        public void alteraBotoes(int op)
        {
            // op = operaçoes que serao feitas com os botoes
            // 1  = Preparar os botoes para inserir e localizar
            // 2  = preparar os para inserir/alterar um registro
            // 3  = preparar a tela para excluir ou alterar

            pnDados.Enabled = false;
            btInserir.Enabled = false;
            btAlterar.Enabled = false;
            btLocalizar.Enabled = false;
            btExcluir.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;

            if (op == 1)
            {
                btInserir.Enabled = true;
                btLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pnDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btAlterar.Enabled = true;
                btExcluir.Enabled = true;
                btCancelar.Enabled = true;
            }
            if (op == 4)
            {
                pnDados.Enabled = true;
                btInserir.Enabled = true;
                btAlterar.Enabled = true;
                btExcluir.Enabled = true;

            }
        }

        private void frmModeloDeFormularioDeCadastro_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void frmModeloDeFormularioDeCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            //tecla enter como TAB
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
