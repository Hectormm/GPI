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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proveedores prove = new Proveedores();
            prove.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Articulos artic = new Articulos();
            artic.Show();
        }
    }
}
