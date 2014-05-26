using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPI.Clientes
{
    public partial class VisualizarCliente : Form
    {
        public VisualizarCliente()
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
            ModificarCliente pantalla = new ModificarCliente();
            pantalla.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Quiere Eliminar el cliente seleccionado?");
            this.Close();
        }
    }
}
