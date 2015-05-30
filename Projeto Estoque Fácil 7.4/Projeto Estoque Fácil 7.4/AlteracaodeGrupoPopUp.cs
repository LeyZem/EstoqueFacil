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
    public partial class AlteracaodeGrupoPopUp : Form
    {
        public AlteracaodeGrupoPopUp()
        {
            InitializeComponent();
        }

        private void AlteracaodeGrupoPopUp_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.WindowState = FormWindowState.Maximized;

            for (int i = 0; i < ListGrupo.Alteracao.Count(); i++)
            {
                if (ListGrupo._list[i].Nome == ListGrupo.Alteracao[i].Nome)
                {
                    txtNomeGrupo.Text = ListGrupo.Alteracao[i].Nome;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListGrupo.Alteracao.Count(); i++)
            {
                if (ListGrupo.Alteracao[i].Nome == ListGrupo._list[i].Nome)
                {
                    ListGrupo.Alteracao[i].Nome = txtNomeGrupo.Text;
                }
            }
            if (MessageBox.Show("Alteração efetuada com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
        private void LimpaCampos()
        {
            txtNomeGrupo.Text = "";
        }
        private void btnCancela_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma o cancelamento da alteração?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
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
