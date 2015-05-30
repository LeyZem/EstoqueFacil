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
    public partial class frmConfiguraçãodoSistema : Form
    {
        public frmConfiguraçãodoSistema()
        {
            InitializeComponent();
        }

        private void Form_ConfiguraçãodoSistema_Load(object sender, EventArgs e)
        {
        
        }
            
        private void numericUpDown1_CursorChanged_1(object sender, EventArgs e)
        {
            numericUpDown1.BackColor = System.Drawing.Color.LightYellow;
            numericUpDown1.ForeColor = System.Drawing.Color.Blue;
        }

        private void numericUpDown2_CursorChanged_1(object sender, EventArgs e)
        {
            numericUpDown2.BackColor = System.Drawing.Color.LightYellow;
            numericUpDown2.ForeColor = System.Drawing.Color.Blue;
        }

        private void numericUpDown3_CursorChanged_1(object sender, EventArgs e)
        {
            numericUpDown3.BackColor = System.Drawing.Color.LightYellow;
            numericUpDown3.ForeColor = System.Drawing.Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                foreach (String arquivo in open.FileNames)
                {
                    textBox1.Text = arquivo;
                    PictureBox pb = new PictureBox();
                    Image imagem = Image.FromFile(arquivo);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = imagem;
                   
                }
                
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = System.Drawing.Color.White;
            textBox1.ForeColor = System.Drawing.Color.Black;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = System.Drawing.Color.LightYellow;
            textBox1.ForeColor = System.Drawing.Color.Blue;
        }

        private void numericUpDown3_Leave(object sender, EventArgs e)
        {
            numericUpDown3.BackColor = System.Drawing.Color.White;
            numericUpDown3.ForeColor = System.Drawing.Color.Black;
        }

        private void numericUpDown2_Leave(object sender, EventArgs e)
        {
            numericUpDown2.BackColor = System.Drawing.Color.White;
            numericUpDown2.ForeColor = System.Drawing.Color.Black;
        }

        private void numericUpDown1_Leave(object sender, EventArgs e)
        {
            numericUpDown1.BackColor = System.Drawing.Color.White;
            numericUpDown1.ForeColor = System.Drawing.Color.Black;
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            textBox7.BackColor = System.Drawing.Color.LightYellow;
            textBox1.ForeColor = System.Drawing.Color.Blue;
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            textBox7.BackColor = System.Drawing.Color.White;
            textBox1.ForeColor = System.Drawing.Color.Black;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
