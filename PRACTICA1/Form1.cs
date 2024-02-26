using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA1
{
    public partial class frmNombre : Form
    {
        public frmNombre()
        {
            InitializeComponent();
        }

        private void frmNombre_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }
        private void frmNombre_FormClosed(object sender, EventArgs e)
        {
            MessageBox.Show("Chau Chau.....");
        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento Click" , "Atencion");
            //this.BackColor = Color.Blue;
            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
        }

        private void frmNombre_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el boton izquierdo", "Atencion");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el boton derecho", "Atencion");
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el boton del medio", "Atencion");
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtNombre.Text.Length + " Caracteres");
        }
    }
}
