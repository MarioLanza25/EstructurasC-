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
    public partial class FrmMdi : Form
    {
        public FrmMdi()
        {
            InitializeComponent();
        }

        private void ActivoFijoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActivo frm = new FrmActivo();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
