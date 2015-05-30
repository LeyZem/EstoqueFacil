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
    public partial class FormAlteraçãodeGrupo : Form
    {
        public FormAlteraçãodeGrupo()
        {
            InitializeComponent();
        }

        private void gpbNovoGrupoDeMateriais_Enter(object sender, EventArgs e)
        {

        }

        private void FormAlteraçãodeGrupo_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgGrupo.Visible = true;
            dtgGrupo.DataSource = null;
            dtgGrupo.DataSource = ListGrupo._list;
            dtgGrupo.Refresh();
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void dtgGrupo_Click(object sender, EventArgs e)
        {

        }

        private void dtgGrupo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgGrupo.SelectedRows.Count > 0)
            {

                Grupo objGrupo = dtgGrupo.SelectedRows[0].DataBoundItem as Grupo;

                ListGrupo.GravaAlteracao(objGrupo);
                AlteracaodeGrupoPopUp frm = new AlteracaodeGrupoPopUp();
                //frm.MdiParent = frmPrincipal;
                frm.Show();
            }
        }

    }
}
