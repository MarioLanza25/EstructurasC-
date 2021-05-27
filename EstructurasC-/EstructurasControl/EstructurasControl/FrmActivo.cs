using EstructurasControl.Poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasControl
{
    public partial class FrmActivo : Form
    {
        List<ActivoFijo> activoFijo;
        public FrmActivo()
        {
            InitializeComponent();
            activoFijo = new List<ActivoFijo>();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtValorActivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

        }

        private ActivoFijo ReadActivoFijo()
        {
            String codigo = txtCodigo.Text;
            String nombre = txtNombre.Text;
            int index = cmbTipo.SelectedIndex;
            TipoActivo tipo = index == 0 ? TipoActivo.Edificio :
                              index == 0 ? TipoActivo.Vehiculo :
                              index == 0 ? TipoActivo.Mobiliario :
                              index == 0 ? TipoActivo.Equipo_Oficina :
                              TipoActivo.Maquinaria;

            decimal.TryParse(txtValorActivo.Text, out decimal valor);
            decimal.TryParse(txtValorActivo.Text, out decimal valorR);

            return null;
        }

        private void DgvDepre_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TxtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                txtCodigo.BackColor = Color.DarkRed;
                e.Cancel = true;

            }
            else
            {
                txtCodigo.BackColor = Color.White;
            }
        }
    }
}
