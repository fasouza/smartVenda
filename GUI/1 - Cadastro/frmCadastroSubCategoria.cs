using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DAL;
using Modelo;
using BLL;
using System.Data.SqlClient;


namespace GUI
{
    public partial class frmCadastroSubCategoria : GUI.frmModeloFormularioCadastro
    {
        
        public frmCadastroSubCategoria()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            cbxCategoria.SelectedIndex = -1;
            
        }

        private void frmCadastroSubCategoria_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);

            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbxCategoria.DataSource = bll.Localizar("");//trás todos os dados
            cbxCategoria.DisplayMember = "cat_nome";// valor que aparece
            cbxCategoria.ValueMember = "cat_cod";//valor que vai ser passado
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.operacao = "inserir";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            alteraBotoes(2);
            this.operacao = "alterar";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloSubCategoria modelo = new ModeloSubCategoria();
                modelo.ScatNome = txtNome.Text;
                modelo.CatCod = Convert.ToInt32(cbxCategoria.SelectedValue);
             
                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código: " +modelo.ScatCod.ToString());

                }
                else
                {
                    //alterar uma Subcategoria
                    modelo.ScatCod = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (SqlException)
            {
                MessageBox.Show("A Subcategoria " + txtNome.Text + " já está cadastrada", "Verifique!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                    BLLSubCategoria bll = new BLLSubCategoria(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro.\n Pois o mesmo está sendo utilizado em outro local.");
                this.alteraBotoes(3);

            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {

            frmConsultaSubcategoria f = new frmConsultaSubcategoria();
            f.ShowDialog();
            f.Dispose();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);
                ModeloSubCategoria modelo = bll.CarregaModeloSubCategoria(f.codigo);
                txtCodigo.Text = modelo.ScatCod.ToString();
                txtNome.Text = modelo.ScatNome;
                cbxCategoria.SelectedValue = modelo.CatCod;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();            
          }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();

            DALConexao cx = new DALConexao(DadosConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbxCategoria.DataSource = bll.Localizar("");//trás todos os dados
            cbxCategoria.DisplayMember = "cat_nome";// valor que aparece
            cbxCategoria.ValueMember = "cat_cod";//valor que vai ser passado
        }            

        }
    }

