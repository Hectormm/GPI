using GPI.Clientes;
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
    public partial class PrincipalClientes : Form
    {
        public PrincipalClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaCliente ac = new AltaCliente();
            ac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VisualizarCliente vc = new VisualizarCliente();
            vc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModificarCliente mc = new ModificarCliente();
            mc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Quiere Eliminar el cliente seleccionado?");
        }
    }
}
