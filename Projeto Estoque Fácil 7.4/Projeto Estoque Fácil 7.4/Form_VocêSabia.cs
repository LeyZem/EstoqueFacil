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
    public partial class frmVocêSabia : Form
    {
        public frmVocêSabia()
        {
            InitializeComponent();
        }

        public int i = 0;

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if( i < 1 )
            {
                pictureBox3.Visible = true;
                i++;
            } else if (i == 1)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                i++;
            }
            else if (i==2)
            {
                this.Close();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }
