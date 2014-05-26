using GPI.Articulos;
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
    public partial class PrincipalArticulos : Form
    {
        public PrincipalArticulos()
        {
            InitializeComponent();
            inicializarArticulos();
        }

        private void inicializarArticulos()
        {
            dataGridView1.Rows.Add("1", "nombre", "5", "descripcion", "coste", "venta", "iva", true);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaArticulos pantalla = new AltaArticulos();
            pantalla.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VisualizarArticulo pantalla = new VisualizarArticulo();
            pantalla.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModificarArticulo pantalla = new ModificarArticulo();
            pantalla.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Quiere Eliminar el articulo seleccionado?");
        }

        private void PrincipalArticulos_Load(object sender, EventArgs e)
        {

        }
    }
}
