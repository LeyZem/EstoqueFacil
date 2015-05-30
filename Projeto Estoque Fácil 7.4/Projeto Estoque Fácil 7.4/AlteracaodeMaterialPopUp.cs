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
    public partial class AlteracaodeMaterialPopUp : Form
    {
        public AlteracaodeMaterialPopUp()
        {
            InitializeComponent();
        }

        private void AlteracaodeMaterialPopUp_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.WindowState = FormWindowState.Maximized;
            cmbNomeGrupo.DataSource = ListGrupo._list;
            cmbNomeGrupo.DisplayMember = "Nome";

            for (int i = 0; i < ListMaterial.Alteracao.Count(); i++)
            {
                if (ListMaterial._list[i].Nome == ListMaterial.Alteracao[i].Nome)
                {
                    txtCodBarra.Text = ListMaterial.Alteracao[i].Codigo_barra;
                    txtEstoqueIdeal.Text = ListMaterial.Alteracao[i].Estoque_ideal;
                    txtEstoqueMin.Text = ListMaterial.Alteracao[i].Estoque_min;
                    txtLocal.Text = ListMaterial.Alteracao[i].Local;
                    txtNcm.Text = ListMaterial.Alteracao[i].Ncm;
                    txtNomeMat.Text = ListMaterial.Alteracao[i].Nome;
                    txtNumFab.Text = ListMaterial.Alteracao[i].Num_fab;
                    txtObs.Text = ListMaterial.Alteracao[i].Observacao;
                    txtPeso.Text = ListMaterial.Alteracao[i].Peso;
                    txtPorcentLucro.Text = ListMaterial.Alteracao[i].Porcent_lucro;
                    txtSaldoInicial.Text = ListMaterial.Alteracao[i].Saldo_inicial;
                    txtUnidade.Text = ListMaterial.Alteracao[i].Unidade;
                    txtValorLucro.Text = ListMaterial.Alteracao[i].Valor_lucro;
                    txtValorSaida.Text = ListMaterial.Alteracao[i].Valor_saida;
                    cmbNomeGrupo.SelectedItem = ListMaterial.Alteracao[i].NomeGrupo;
                }
            }
        }
        private void LimpaCampos()
        {
            txtCodBarra.Text = "";
            txtEstoqueIdeal.Text = "";
            txtEstoqueMin.Text = "";
            txtLocal.Text = "";
            txtNcm.Text = "";
            txtNomeMat.Text = "";
            txtNumFab.Text = "";
            txtObs.Text = "";
            txtPeso.Text = "";
            txtPorcentLucro.Text = "";
            txtSaldoInicial.Text = "";
            txtUnidade.Text = "";
            txtValorLucro.Text = "";
            txtValorSaida.Text = "";

            cmbNomeGrupo.SelectedItem = null;
        }
        private void btnCancela_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma o cancelamento da alteração?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                LimpaCampos();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListMaterial.Alteracao.Count(); i++)
            {
                if (ListMaterial.Alteracao[i].Nome == ListMaterial._list[i].Nome)
                {
                    ListMaterial.Alteracao[i].Codigo_barra = txtCodBarra.Text;
                    ListMaterial.Alteracao[i].Estoque_ideal = txtEstoqueIdeal.Text;
                    ListMaterial.Alteracao[i].Estoque_min = txtEstoqueMin.Text;
                    ListMaterial.Alteracao[i].Local = txtLocal.Text;
                    ListMaterial.Alteracao[i].Ncm = txtNcm.Text;
                    ListMaterial.Alteracao[i].Nome = txtNomeMat.Text;
                    ListMaterial.Alteracao[i].Num_fab = txtNumFab.Text;
                    ListMaterial.Alteracao[i].Observacao = txtObs.Text;
                    ListMaterial.Alteracao[i].Peso = txtPeso.Text;
                    ListMaterial.Alteracao[i].Porcent_lucro = txtPorcentLucro.Text;
                    ListMaterial.Alteracao[i].Saldo_inicial = txtSaldoInicial.Text;
                    ListMaterial.Alteracao[i].Unidade = txtUnidade.Text;
                    ListMaterial.Alteracao[i].Valor_lucro = txtValorLucro.Text;
                    ListMaterial.Alteracao[i].Valor_saida = txtValorSaida.Text;
                    ListMaterial.Alteracao[i].NomeGrupo = cmbNomeGrupo.Text;
                }
            }
            if (MessageBox.Show("Alteração efetuada com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
