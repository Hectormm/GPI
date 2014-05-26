using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPI.Articulos
{
    public partial class VisualizarArticulo : Form
    {
        public VisualizarArticulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ModificarArticulo pantalla = new ModificarArticulo();
            pantalla.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Quiere Eliminar el articulo seleccionado?");
            this.Close();
        }
    }
}
