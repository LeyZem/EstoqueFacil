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
    public partial class FormAlteraçãodeKitsdeMateriais : Form
    {
        public FormAlteraçãodeKitsdeMateriais()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAlteraçãodeKitsdeMateriais_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dtgKits.Visible = true;
            dtgKits.DataSource = null;
            dtgKits.DataSource = ListItemKit._lista;
            dtgKits.Refresh();
        }

        private void dtgKits_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgKits.SelectedRows.Count > 0)
            {
                Kit objKit = dtgKits.SelectedRows[0].DataBoundItem as Kit;
                ListItemKit.GravaAlter(objKit);

                ItemKit objItemKit = dtgKits.SelectedRows[0].DataBoundItem as ItemKit;
                ListItemKit.GravaAlteracao(objItemKit);

                AlteracaoKitsdeMateriaisPopUp frm = new AlteracaoKitsdeMateriaisPopUp();
                //frm.MdiParent = frmPrincipal;
                frm.Show();
            }
        }
    }
}
