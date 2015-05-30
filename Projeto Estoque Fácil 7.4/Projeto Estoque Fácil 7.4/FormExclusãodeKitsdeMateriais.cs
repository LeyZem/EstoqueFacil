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
    public partial class FormExclusãodeKitsdeMateriais : Form
    {
        public FormExclusãodeKitsdeMateriais()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormExclusãodeKitsdeMateriais_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgKits.Visible = true;
            dtgKits.DataSource = null;
            dtgKits.DataSource = ListItemKit._lista;
            dtgKits.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                for (int i = 0; i < ListItemKit._lista.Count; i++)
                {
                    if (ListItemKit._lista[i].NomeKit == (dtgKits.SelectedRows[0].DataBoundItem as Kit).NomeKit)
                    {
                        ListItemKit._lista.RemoveAt(i);
                        i = ListItemKit._lista.Count;
                    }
                }

                dtgKits.DataSource = null;
                dtgKits.DataSource = ListItemKit._lista;
                dtgKits.Refresh();
            }
        }
    }
}
