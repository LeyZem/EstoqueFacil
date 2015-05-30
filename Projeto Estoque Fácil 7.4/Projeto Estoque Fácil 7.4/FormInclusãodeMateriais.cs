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
    public partial class FormInclusãodeMateriais : Form
    {
        public FormInclusãodeMateriais()
        {
            InitializeComponent();
        }
        private void FormInclusãodeMateriais_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.WindowState = FormWindowState.Maximized;
            cmbNomeGrupo.DataSource = ListGrupo._list;
            cmbNomeGrupo.DisplayMember = "Nome";
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma o cancelamento da inclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                LimpaCampos();
            }            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtNomeMat.Text != "" && txtCodBarra.Text != "" && txtEstoqueIdeal.Text != "" && txtEstoqueMin.Text != "" && txtLocal.Text != "" && txtNcm.Text != "" && 
                txtNumFab.Text != "" && txtObs.Text != "" && txtPeso.Text != "" && txtPorcentLucro.Text != "" && txtSaldoInicial.Text != "" && txtUnidade.Text != "" && 
                txtValorLucro.Text != "" && txtValorSaida.Text != "" && cmbNomeGrupo.Text != "")
            {
                Material objMaterial = new Material();

                objMaterial.Nome = txtNomeMat.Text;
                objMaterial.Codigo_barra = txtCodBarra.Text;
                objMaterial.Estoque_ideal = txtEstoqueIdeal.Text;
                objMaterial.Estoque_min = txtEstoqueMin.Text;
                objMaterial.Local = txtLocal.Text;
                objMaterial.Ncm = txtNcm.Text;
                objMaterial.Num_fab = txtNumFab.Text;
                objMaterial.Observacao = txtObs.Text;
                objMaterial.Peso = txtPeso.Text;
                objMaterial.Porcent_lucro = txtPorcentLucro.Text;
                objMaterial.Saldo_inicial = txtSaldoInicial.Text;
                objMaterial.Unidade = txtUnidade.Text;
                objMaterial.Valor_lucro = txtValorLucro.Text;
                objMaterial.Valor_saida = txtValorSaida.Text;
                objMaterial.NomeGrupo = cmbNomeGrupo.Text;

                ListMaterial.Record(objMaterial);

                MessageBox.Show("Inclusão efetuada com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O nome do material precisa ser informado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpaCampos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                foreach (String arquivo in open.FileNames)
                {
                    textBox1.Text = arquivo;
                    PictureBox pb = new PictureBox();
                    Image imagem = Image.FromFile(arquivo);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = imagem;

                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }
    }
}
