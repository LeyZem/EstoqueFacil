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
    public partial class AlteracaoKitsdeMateriaisPopUp : Form
    {
        public AlteracaoKitsdeMateriaisPopUp()
        {
            InitializeComponent();
        }

        private void LimpaCampos()
        {
            txtNomeKit.Text = "";
            txtItem.Text = "";
            txtQtd.Text = "";

            dtgKits.DataSource = null;
        }
        private void AlteracaoKitsdeMateriaisPopUp_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.WindowState = FormWindowState.Maximized;
            ListItemKit.Alteracao = ListItemKit._list;
            
            for (int i = 0; i < ListItemKit.Alter.Count(); i++)
            {
                if (ListItemKit._lista[i].NomeKit == ListItemKit.Alter[i].NomeKit)
                {
                    txtNomeKit.Text = ListItemKit.Alter[i].NomeKit;
                }
            }
            for (int x = 0; x < ListItemKit.Alteracao.Count(); x++)
            {
                if (ListItemKit._list[x].NomeMat == ListItemKit.Alteracao[x].NomeMat)
                {
                    txtItem.Text = ListItemKit.Alteracao[x].NomeMat;
                    txtQtd.Text = ListItemKit.Alteracao[x].Quant;
                }
            }

            dtgKits.Refresh();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma o cancelamento da alteração?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                LimpaCampos();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListItemKit.Alter.Count(); i++)
            {
                if (ListItemKit._lista[i].NomeKit == ListItemKit.Alter[i].NomeKit)
                {
                    ListItemKit.Alter[i].NomeKit = txtNomeKit.Text;
                }
            }
            for (int x = 0; x < ListItemKit.Alteracao.Count(); x++)
            {
                if (ListItemKit._list[x].NomeMat == ListItemKit.Alteracao[x].NomeMat)
                {
                    ListItemKit.Alteracao[x].NomeMat = txtItem.Text;
                    ListItemKit.Alteracao[x].NomeMat = txtQtd.Text;
                }
            }
            if (MessageBox.Show("Alteração efetuada com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            ConsultaMateriaisPopUp2 frm = new ConsultaMateriaisPopUp2(this);
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
    }
}
