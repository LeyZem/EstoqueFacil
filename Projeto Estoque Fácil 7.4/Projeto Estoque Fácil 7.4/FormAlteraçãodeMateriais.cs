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
    public partial class FormAlteraçãodeMateriais : Form
    {
        public FormAlteraçãodeMateriais()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormAlteraçãodeMateriais_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgMaterial.Visible = true;
            dtgMaterial.DataSource = null;
            dtgMaterial.DataSource = ListMaterial._list;
            dtgMaterial.Refresh();
        }

        private void dtgMaterial_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgMaterial.SelectedRows.Count > 0)
            {
                Material objMaterial = dtgMaterial.SelectedRows[0].DataBoundItem as Material;

                ListMaterial.GravaAlteracao(objMaterial);
                AlteracaodeMaterialPopUp frm = new AlteracaodeMaterialPopUp();
                //frm.MdiParent = frmPrincipal;
                frm.Show();
            }
        }
    }
}
