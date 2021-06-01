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
        private ActivoFijo[] activoFijo;
        public FrmActivo()
        {
            InitializeComponent();
            ReadActivoFijo();
            
        }

        private void ReadActivoFijo()
        {

            cmbTipo.Items.AddRange(Enum.GetValues(typeof(TipoActivo)).Cast<object>().ToArray());

            cmbTipo.SelectedIndex = 0;
        }
        private ActivoFijo[] AddElements(ActivoFijo[] activos, ActivoFijo af)
        {
            if(activos == null)
            {
                activos = new ActivoFijo[1];
                activos[0] = af;
                return activos;
            }
            ActivoFijo[] temp = new ActivoFijo[activos.Length + 1];
            Array.Copy(activos, temp, activos.Length);
            temp[temp.Length - 1] = af;

            return temp;
        }

        private void TxtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Debe llenar el campo de texto");
                txtCodigo.BackColor = Color.Red;
                e.Cancel = true;

            }
            else
            {
                txtCodigo.BackColor = Color.White;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            decimal.TryParse(txtValorActivo.Text, out decimal valor);
            decimal.TryParse(txtValorResidual.Text, out decimal vr);
            int index = cmbTipo.SelectedIndex;
            TipoActivo tipoActivo = (TipoActivo) Enum.GetValues(typeof(TipoActivo)).GetValue(index);

            ActivoFijo af = new ActivoFijo()
            {
                Codigo = codigo,
                Nombre = nombre,
                ValorActivo = valor,
                TipoActivo = tipoActivo,
                ValorResidual = vr
            };

            activoFijo = AddElements(activoFijo, af);
            MessageBox.Show("Activo ha sido agregado satisfactoriamente!");
            dgvDepre.DataSource = activoFijo;
        }
    }
}
