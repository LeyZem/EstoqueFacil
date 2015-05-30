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
    public partial class AlteracaodeFornecedorPopUp : Form
    {
        public AlteracaodeFornecedorPopUp()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListFornecedor.Alteracao.Count(); i++)
            {
                if (ListFornecedor.Alteracao[i].NomeFornecedor == ListFornecedor._list[i].NomeFornecedor)
                {
                    ListFornecedor.Alteracao[i].NomeFornecedor = txtFornecedor.Text;
                    ListFornecedor.Alteracao[i].RazaoSocial = txtRazaoSocial.Text;
                    ListFornecedor.Alteracao[i].NomeContato = txtNomeContato.Text;
                    ListFornecedor.Alteracao[i].InscEstadual = txtInscEstadual.Text;
                    ListFornecedor.Alteracao[i].Cnpj = txtCnpj.Text;
                    ListFornecedor.Alteracao[i].Tel1 = txtTel1.Text;
                    ListFornecedor.Alteracao[i].Tel2 = txtTel2.Text;
                    ListFornecedor.Alteracao[i].Fax = txtFax.Text;
                    ListFornecedor.Alteracao[i].Endereco = txtEndereco.Text;
                    ListFornecedor.Alteracao[i].Bairro = txtBairro.Text;
                    ListFornecedor.Alteracao[i].Cep = txtCep.Text;
                    ListFornecedor.Alteracao[i].Cidade = txtCidade.Text;
                    ListFornecedor.Alteracao[i].Uf = cmbUf.Text;
                    ListFornecedor.Alteracao[i].PontoReferencia = txtPontoReferencia.Text;
                    ListFornecedor.Alteracao[i].Email = txtEmail.Text;
                    ListFornecedor.Alteracao[i].Site = txtSite.Text;
                    ListFornecedor.Alteracao[i].Obs1 = txtObs1.Text;
                    ListFornecedor.Alteracao[i].Obs2 = txtObs2.Text;
                }
            }
            if (MessageBox.Show("Alteração efetuada com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
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
        private void btnCancela_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma o cancelamento da inclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                LimpaCampos();
            }   
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlteracaodeFornecedorPopUp_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.WindowState = FormWindowState.Maximized;

            for (int i = 0; i < ListFornecedor.Alteracao.Count(); i++)
            {
                if (ListFornecedor._list[i].NomeFornecedor == ListFornecedor.Alteracao[i].NomeFornecedor)
                {
                    txtFornecedor.Text = ListFornecedor.Alteracao[i].NomeFornecedor;
                    txtRazaoSocial.Text = ListFornecedor.Alteracao[i].RazaoSocial;
                    txtNomeContato.Text = ListFornecedor.Alteracao[i].NomeContato;
                    txtInscEstadual.Text = ListFornecedor.Alteracao[i].InscEstadual;
                    txtCnpj.Text = ListFornecedor.Alteracao[i].Cnpj;
                    txtTel1.Text = ListFornecedor.Alteracao[i].Tel1;
                    txtTel2.Text = ListFornecedor.Alteracao[i].Tel2;
                    txtFax.Text = ListFornecedor.Alteracao[i].Fax;
                    txtEndereco.Text = ListFornecedor.Alteracao[i].Endereco;
                    txtBairro.Text = ListFornecedor.Alteracao[i].Bairro;
                    txtCep.Text = ListFornecedor.Alteracao[i].Cep;
                    txtCidade.Text = ListFornecedor.Alteracao[i].Cidade;
                    cmbUf.SelectedItem = ListFornecedor.Alteracao[i].Uf;
                    txtPontoReferencia.Text = ListFornecedor.Alteracao[i].PontoReferencia;
                    txtEmail.Text = ListFornecedor.Alteracao[i].Email;
                    txtSite.Text = ListFornecedor.Alteracao[i].Site;
                    txtObs1.Text = ListFornecedor.Alteracao[i].Obs1;
                    txtObs2.Text = ListFornecedor.Alteracao[i].Obs2; 
                }
            }
        }
    }
}
