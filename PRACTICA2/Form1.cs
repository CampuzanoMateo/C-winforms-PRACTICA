using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA2
{
    public partial class frmPrimeraplicacion : Form
    {
        public frmPrimeraplicacion()
        {
            InitializeComponent();
        }

        private void lblLabel_MouseMove(object sender, MouseEventArgs e)
        {
            lblLabel.BackColor = Color.Cyan;
            lblLabel.Cursor = Cursors.Hand;

        }

        private void lblLabel_MouseLeave(object sender, EventArgs e)
        {
            lblLabel.BackColor = System.Drawing.SystemColors.Control;
            lblLabel.Cursor = Cursors.Arrow;
        }
    }
}
