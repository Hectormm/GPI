using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPI.Ayuda
{
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
            textBoxDatos.Text = "Componentes del Proyecto: \r\n ·Pedro Gomez Valdés \r\n ·Alberto Martínez López \r\n ·Héctor Martínez Matías \r\n ·Pablo Varela Gandia  \r\n ·Victor Vives Boix ";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
