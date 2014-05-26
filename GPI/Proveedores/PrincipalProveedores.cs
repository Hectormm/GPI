using GPI.Proveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPI
{
    public partial class PrincipalProveedores : Form
    {
        public PrincipalProveedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaProveedor pantalla = new AltaProveedor();
            pantalla.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VisualizarProveedor pantalla = new VisualizarProveedor();
            pantalla.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModificarProveedor pantalla = new ModificarProveedor();
            pantalla.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Quiere Eliminar el proveedor seleccionado?");
        }
    }
}
