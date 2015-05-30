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
    public partial class frmAlteraçãodoCentrodeCusto : Form
    {
        public frmAlteraçãodoCentrodeCusto()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form_AlteraçãodoCentrodeCusto_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgCusto.Visible = true;
            dtgCusto.DataSource = null;
            dtgCusto.DataSource = ListCusto._list;
            dtgCusto.Refresh();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgCusto_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgCusto.SelectedRows.Count > 0)
            {

                Custo objCusto = dtgCusto.SelectedRows[0].DataBoundItem as Custo;

                ListCusto.GravaAlteracao(objCusto);
                AlteracaodeCentrodeCustoPopUp frm = new AlteracaodeCentrodeCustoPopUp();
                //frm.MdiParent = frmPrincipal;
                frm.Show();
            }
        }
    }
}
