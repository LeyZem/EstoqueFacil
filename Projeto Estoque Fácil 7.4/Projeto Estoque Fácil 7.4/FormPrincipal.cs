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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cdastroDeCentrosDeCustosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeKitsDeMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saídasNoPeríodoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {

        }

        private void inclusãoDeGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInclusãodeGrupo frm = new FormInclusãodeGrupo();
            frm.MdiParent = this;
            frm.Show();
           
        }

        private void alteraçãoDeGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlteraçãodeGrupo frm = new FormAlteraçãodeGrupo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void exclusãoDeGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExclusãodeGrupo frm = new FormExclusãodeGrupo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void inclusãoDeMateriaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInclusãodeMateriais frm = new FormInclusãodeMateriais();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sairDoProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void alteraçãoDeMateriaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlteraçãodeMateriais frm = new FormAlteraçãodeMateriais();
            frm.MdiParent = this;
            frm.Show();
        }

        private void exclusãoDeMateriaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExclusãodeMaterias frm = new FormExclusãodeMaterias();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.WindowState = FormWindowState.Maximized;

            frmVocêSabia frm = new frmVocêSabia();
            frm.MdiParent = this;
            frm.Show();

            lblPath.Text = "Pasta: " + Application.StartupPath;
            lblProgram.Text = Application.ProductName + ".exe";
            lblDate.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void inclusãoDeKitsDeMateriaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInclusãodeKitsdeMaterias frm = new FormInclusãodeKitsdeMaterias();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cadastroDeGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void alteraçãoDeKitsDeMateriaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlteraçãodeKitsdeMateriais frm = new FormAlteraçãodeKitsdeMateriais();
            frm.MdiParent = this;
            frm.Show();
        }

        private void exclusãoDeKitsDeMateriaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExclusãodeKitsdeMateriais frm = new FormExclusãodeKitsdeMateriais();
            frm.MdiParent = this;
            frm.Show();
        }

        private void inclusãoDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInclusãodeFornecedores frm = new frmInclusãodeFornecedores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void alteraçãoDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlteraçãodeFornecedores frm = new frmAlteraçãodeFornecedores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void exclusãoDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExclusãodeFornecedores frm = new frmExclusãodeFornecedores();
            frm.MdiParent = this;
            frm.Show();
        }

        public void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void inclusãoDeCentroDeCustoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInclusãodoCentrodeCusto frm = new frmInclusãodoCentrodeCusto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void alteraçãoDeCentroDeCustoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlteraçãodoCentrodeCusto frm = new frmAlteraçãodoCentrodeCusto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void exclusãoDeCentroDeCustoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExclusãodoCentrodeCusto frm = new frmExclusãodoCentrodeCusto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmChavedeRegistro frm = new frmChavedeRegistro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmAtualizaPrograma frm = new frmAtualizaPrograma();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frm = new frmSobre();
            frm.MdiParent = this;
            frm.Show();
        }

        private void configuraçãoDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguraçãodoSistema frm = new frmConfiguraçãodoSistema();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aparênciaDoProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAparênciadoPrograma frm = new frmAparênciadoPrograma();
            frm.MdiParent = this;
            frm.Show();
        }

        private void históricoDeCorreõesEModificaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistóricodasCorreçõesceModificações frm = new frmHistóricodasCorreçõesceModificações();
            frm.MdiParent = this;
            frm.Show();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
