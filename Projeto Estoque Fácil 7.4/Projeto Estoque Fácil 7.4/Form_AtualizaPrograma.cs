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
    public partial class frmAtualizaPrograma : Form
    {
        public frmAtualizaPrograma()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAtualizaPrograma_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Não existe atualização disponível no momento.", "Estoque Fácil 7", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Não existe atualização disponível no momento.", "Estoque Fácil 7", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
