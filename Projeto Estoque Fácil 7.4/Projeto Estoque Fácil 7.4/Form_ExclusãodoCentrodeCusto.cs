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
    public partial class frmExclusãodoCentrodeCusto : Form
    {
        public frmExclusãodoCentrodeCusto()
        {
            InitializeComponent();
        }

        private void Form_ExclusãodoCentrodeCusto_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                for (int i = 0; i < ListCusto._list.Count; i++)
                {
                    if (ListCusto._list[i].Nome == (dtgCusto.SelectedRows[0].DataBoundItem as Custo).Nome)
                    {
                        ListCusto._list.RemoveAt(i);
                        i = ListCusto._list.Count;
                    }
                }

                dtgCusto.DataSource = null;
                dtgCusto.DataSource = ListMaterial._list;
                dtgCusto.Refresh();
            }
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
    }
}
