using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Estoque_Fácil_7._4
{
    public partial class frmInclusãodeFornecedores : Form
    {
        public frmInclusãodeFornecedores()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_CursorChanged(object sender, EventArgs e)
        {
            txtFornecedor.BackColor = System.Drawing.Color.OldLace;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimpaCampos()
        {
            txtFornecedor.Text = "";
            txtRazaoSocial.Text = "";
            txtNomeContato.Text = ""; 
            txtInscEstadual.Text = "";
            txtCnpj.Text = "";
            txtTel1.Text = "";
            txtTel2.Text = "";
            txtFax.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtCep.Text = "";
            txtCidade.Text = "";
            cmbUf.Text = "";
            txtPontoReferencia.Text = "";
            txtEmail.Text = "";
            txtSite.Text = ""; 
            txtObs1.Text = "";
            txtObs2.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtFornecedor.Text != "" && txtRazaoSocial.Text != "" && txtNomeContato.Text != "" && txtInscEstadual.Text != "" && txtCnpj.Text != "" && txtTel1.Text != "" &&
                txtTel2.Text != "" && txtFax.Text != "" && txtEndereco.Text != "" && txtBairro.Text != "" && txtCep.Text != "" && txtCidade.Text != "" && cmbUf.Text != "" &&
                txtPontoReferencia.Text != "" && txtEmail.Text != "" && txtSite.Text != "" && txtObs1.Text != "" && txtObs2.Text != "")
            {
                Fornecedor objFornecedor = new Fornecedor();

                objFornecedor.NomeFornecedor = txtFornecedor.Text;
                objFornecedor.RazaoSocial = txtRazaoSocial.Text;
                objFornecedor.NomeContato = txtNomeContato.Text;
                objFornecedor.InscEstadual = txtInscEstadual.Text;
                objFornecedor.Cnpj = txtCnpj.Text;
                objFornecedor.Tel1 = txtTel1.Text;
                objFornecedor.Tel2 = txtTel2.Text;
                objFornecedor.Fax = txtFax.Text;
                objFornecedor.Endereco = txtEndereco.Text;
                objFornecedor.Bairro = txtBairro.Text;
                objFornecedor.Cep = txtCep.Text;
                objFornecedor.Cidade = txtCidade.Text;
                objFornecedor.Uf = cmbUf.Text;
                objFornecedor.PontoReferencia = txtPontoReferencia.Text;
                objFornecedor.Email = txtEmail.Text;
                objFornecedor.Site = txtSite.Text;
                objFornecedor.Obs1 = txtObs1.Text;
                objFornecedor.Obs2 = txtObs2.Text;

                ListFornecedor.Record(objFornecedor);

                MessageBox.Show("Inclusão efetuada com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O nome do material precisa ser informado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpaCampos();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma o cancelamento da inclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                LimpaCampos();
            }   
        }

        private void frmInclusãodeFornecedores_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
