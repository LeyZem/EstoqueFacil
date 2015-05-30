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
    public partial class FormInclusãodeKitsdeMaterias : Form
    {
        public FormInclusãodeKitsdeMaterias()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpaCampos()
        {
            txtNomeKit.Text = "";
            txtItem.Text = "";
            txtQtd.Text = "";

            dtgKits.DataSource = null;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtNomeKit.Text != "" && dtgKits.DataSource != null)
            {
                Kit objKit = new Kit();

                objKit.NomeKit = txtNomeKit.Text;
                ListItemKit.Grava(objKit);

                MessageBox.Show("Inclusão efetuada com sucesso." + "\n" + "Este kit recebeu o número: " + maskedTextBox1.Text, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O nome do kit precisa ser informado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpaCampos();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma o cancelamento da inclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                LimpaCampos();
            }     
        }

        private void FormInclusãodeKitsdeMaterias_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.WindowState = FormWindowState.Maximized;

            
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            ConsultaMateriaisPopUp frm = new ConsultaMateriaisPopUp(this);
            frm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ItemKit objItemKit = new ItemKit();

            objItemKit.NomeMat = txtItem.Text;
            objItemKit.Quant = txtQtd.Text;

            ListItemKit.Record(objItemKit);

            dtgKits.DataSource = null;
            dtgKits.DataSource = ListItemKit._list;
            dtgKits.Refresh();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do item neste kit?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                for (int i = 0; i < ListItemKit._list.Count; i++)
                {
                    if (ListItemKit._list[i].NomeMat == (dtgKits.SelectedRows[i].DataBoundItem as ItemKit).NomeMat)
                    {
                        ListItemKit._list.RemoveAt(i);
                        i = ListItemKit._list.Count;
                    }
                }

                dtgKits.DataSource = null;
                dtgKits.DataSource = ListItemKit._list;
                dtgKits.Refresh();
            }
        }
    }
}
