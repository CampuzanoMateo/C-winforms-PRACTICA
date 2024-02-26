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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe esta ventana pedazo de gato");
                    return;
                }
            }

            Form1 Perfil = new Form1();
            Perfil.MdiParent = this;
            Perfil.Show();
        }

        private void tsbPerfil_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.ShowDialog();
        }
    }
}
