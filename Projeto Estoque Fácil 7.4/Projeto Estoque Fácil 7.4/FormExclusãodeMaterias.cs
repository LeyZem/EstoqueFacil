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
    public partial class FormExclusãodeMaterias : Form
    {
        public FormExclusãodeMaterias()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormExclusãodeMaterias_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtgMaterial.Visible = true;
            dtgMaterial.DataSource = null;
            dtgMaterial.DataSource = ListMaterial._list;
            dtgMaterial.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                for (int i = 0; i < ListMaterial._list.Count; i++)
                {
                    if (ListMaterial._list[i].Codigo_barra == (dtgMaterial.SelectedRows[0].DataBoundItem as Material).Codigo_barra)
                    {
                        ListMaterial._list.RemoveAt(i);
                        i = ListMaterial._list.Count;
                    }
                }

                dtgMaterial.DataSource = null;
                dtgMaterial.DataSource = ListMaterial._list;
                dtgMaterial.Refresh();
            }
        }
    }
}
