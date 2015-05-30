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
    public partial class ConsultaMateriaisPopUp : Form
    {
        FormInclusãodeKitsdeMaterias formInclusãodeKitsdeMaterias;
        
        public ConsultaMateriaisPopUp(FormInclusãodeKitsdeMaterias frm1)
        {
            InitializeComponent();
            formInclusãodeKitsdeMaterias = frm1;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            dtgMaterial.Visible = true;
            lblDica.Visible = true;
            dtgMaterial.DataSource = null;
            dtgMaterial.DataSource = ListMaterial._list;
            dtgMaterial.Refresh();
        }

        private void dtgMaterial_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgMaterial.SelectedRows.Count > 0)
            {
                Material objMaterial = dtgMaterial.SelectedRows[0].DataBoundItem as Material;

                ListConsultaMat.Record(objMaterial);
            }
            this.Close();
        }

        private void ConsultaMateriaisPopUp_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void ConsultaMateriaisPopUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < ListConsultaMat.Consulta.Count(); i++)
            {
                if (ListMaterial._list[i].Nome == ListConsultaMat.Consulta[i].Nome)
                {
                    formInclusãodeKitsdeMaterias.txtItem.Text = ListConsultaMat.Consulta[i].Nome;
                }
            }
        }
    }
}
