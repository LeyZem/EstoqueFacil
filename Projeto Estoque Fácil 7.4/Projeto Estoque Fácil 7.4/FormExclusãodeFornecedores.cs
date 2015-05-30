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
    public partial class frmExclusãodeFornecedores : Form
    {
        public frmExclusãodeFornecedores()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                for (int i = 0; i < ListFornecedor._list.Count; i++)
                {
                    if (ListFornecedor._list[i].Cnpj == (dtgFornecedor.SelectedRows[0].DataBoundItem as Fornecedor).Cnpj)
                    {
                        ListFornecedor._list.RemoveAt(i);
                        i = ListFornecedor._list.Count;
                    }
                }

                dtgFornecedor.DataSource = null;
                dtgFornecedor.DataSource = ListFornecedor._list;
                dtgFornecedor.Refresh();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmExclusãodeFornecedores_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgFornecedor.Visible = true;
            dtgFornecedor.DataSource = null;
            dtgFornecedor.DataSource = ListFornecedor._list;
            dtgFornecedor.Refresh();
        }
    }
}
