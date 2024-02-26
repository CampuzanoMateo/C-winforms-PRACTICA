using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA3
{
    public partial class FormPerfil : Form
    {
        public FormPerfil()
        {
            InitializeComponent();
        }


        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string edad = txtEdad.Text;
            string direccion = txtDireccion.Text;
            txtResultado.Text = ("Apellido y nombre: ") + apellido + (" ") + nombre + (" ") + ("Edad: ") + edad + (" ") +("Direccion: ") + direccion;
            //txtResultado.Text = ("Edad: ") + edad;
            //txtResultado.Text = ("Direccion: ") + direccion;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NO SE PUEDE CANCELAR SALCHICHA");
        }
    }
}
