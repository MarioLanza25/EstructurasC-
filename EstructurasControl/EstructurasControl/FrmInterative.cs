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
    public partial class FrmInterative : Form
    {

        private List<int> numeros;
        public FrmInterative()
        {
            InitializeComponent();
            numeros = new List<int>();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private int? getValue(string value)
        {
            if (int.TryParse(value, out int v))
            {

                return v;
            }
            return null;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int? value = null;
            if (e.KeyCode == Keys.Enter)
            {
                if ((value = getValue(txtNumeros.Text))==null)
                {
                    return;
                }
                if ((value = getValue(txtNumeros.Text)) == null)
                {
                    return;
                }
                numeros.Add(value ?? 0);
            }

        }

        private void Calcular()
        {
            long resultado = 0;
            //for (int i = 1; i < numeros.Count; i++)
            //{
            //    resultado = (long)Math.Pow(numeros.ElementAt(i), 2);
            //    txtResultado.AppendText("{numeros.ElementAt(i)} ^2 = { Math.Pow(numeros.ElementAt(i), 2)}\n" };

            foreach (int i in numeros)
            {
                resultado += (long)Math.Pow(i, 2);
                txtResultado.AppendText($"{i}^2 = {Math.Pow(i , 2)} " +Environment.NewLine);
            }
        }

    }
}
