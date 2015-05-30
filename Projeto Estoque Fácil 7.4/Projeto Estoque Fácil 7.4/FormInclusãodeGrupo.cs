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
    public partial class FormInclusãodeGrupo : Form
    {
        public FormInclusãodeGrupo()
        {
            InitializeComponent();
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void LimpaCampos()
        {
            txtNomeGrupo.Text = "";
        }
        private void gpbNovoGrupoDeMateriais_Enter(object sender, EventArgs e)
        {

        }

        public void FormInclusãodeGrupo_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            if (txtNomeGrupo.Text != "")
            {
                Grupo objGrupo = new Grupo();

                objGrupo.Nome = txtNomeGrupo.Text;

                ListGrupo.Record(objGrupo);

                MessageBox.Show("Inclusão efetuada com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O nome do grupo precisa ser informado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
