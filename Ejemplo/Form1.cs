using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = txtNombre.Text;
            lvTexto.Items.Add(texto);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbodondeVive.Items.Add("Argentina");
            cbodondeVive.Items.Add("Colombia");
            cbodondeVive.Items.Add("Peru");
            cbodondeVive.Items.Add("Mexico");

        }

        private void btnVerperfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpfechaNacimiento.Value;
            string numeroFavorito = nudnumeroFavorito.Value.ToString();
            string dondeVivis = cbodondeVive.SelectedItem.ToString();

            MessageBox.Show("Nombre: " + nombre + " Fecha: " + fecha + " Numero favorito: " + numeroFavorito + " Donde vivis: " + dondeVivis);
        }
    }
}
