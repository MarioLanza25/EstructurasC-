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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int edad = 0;
            if(edad < int.MinValue)
            {
                MessageBox.Show("Su edad no coincide en la categoria");
                return;
            }
            String categoria = cmbCategoria.SelectedItem.ToString();
            String message = "";
            switch (categoria)
            {
                case "Niño":
                    if(validateEdad(edad, 0, 13))
                    {
                        message = "Usted es un niño";
                    }
                    break;
                case "Joven":
                    if (validateEdad(edad, 14, 20))
                    {
                        message = "Usted es un joven";
                    }
                    break;
                case "Adulto":
                    if (validateEdad(edad, 21, 59))
                    {
                        message = "Usted es un adulto";
                    }
                    break;
                case "Anciano":
                    if (validateEdad(edad, 60, 90))
                    {
                        message = "Usted es un anciano";
                    }
                    break;
                default:
                    break;
            }

            MessageBox.Show(message);
        }

        private int setEdad()
        {
            if (int.TryParse(txtEdad.Text, out int edad))
            {
                return edad;
            }
            else
            {
                return int.MinValue;
            }
        }

        private bool validateEdad(int edad, int min, int max)
        {
            if(edad >= min && edad < max)
            {
                return true;
            }

            return false;
        }
    }
}
