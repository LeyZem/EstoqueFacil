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
    public partial class frmAlteraçãodeFornecedores : Form
    {
        public frmAlteraçãodeFornecedores()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgFornecedor.Visible = true;
            dtgFornecedor.DataSource = null;
            dtgFornecedor.DataSource = ListFornecedor._list;
            dtgFornecedor.Refresh();
        }

        private void frmAlteraçãodeFornecedores_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void dtgFornecedor_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgFornecedor.SelectedRows.Count > 0)
            {
                Fornecedor objFornecedor = dtgFornecedor.SelectedRows[0].DataBoundItem as Fornecedor;

                ListFornecedor.GravaAlteracao(objFornecedor);
                AlteracaodeFornecedorPopUp frm = new AlteracaodeFornecedorPopUp();
                //frm.MdiParent = frmPrincipal;
                frm.Show();
            }
        }
    }
}
