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
    public partial class FormExclusãodeGrupo : Form
    {
        public FormExclusãodeGrupo()
        {
            InitializeComponent();
        }

        private void FrmExclusãodeGrupo_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                for (int i = 0; i < ListGrupo._list.Count; i++)
                {
                    if (ListGrupo._list[i].Nome == (dtgGrupo.SelectedRows[0].DataBoundItem as Grupo).Nome)
                    {
                        ListGrupo._list.RemoveAt(i);
                        i = ListGrupo._list.Count;
                    }
                }

                dtgGrupo.DataSource = null;
                dtgGrupo.DataSource = ListGrupo._list;
                dtgGrupo.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgGrupo.Visible = true;
            dtgGrupo.DataSource = null;
            dtgGrupo.DataSource = ListGrupo._list;
            dtgGrupo.Refresh();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
