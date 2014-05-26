using GPI.Ayuda;
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
            toolTipLogin.SetToolTip(textBoxUsuario, "Usuario: Admin");
            toolTipLogin.SetToolTip(textBoxPass, "Contraseña: Pass");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrincipalClientes cliente = new PrincipalClientes();
            cliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrincipalProveedores prove = new PrincipalProveedores();
            prove.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrincipalArticulos artic = new PrincipalArticulos();
            artic.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PrincipalClientes cliente = new PrincipalClientes();
            cliente.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PrincipalProveedores prove = new PrincipalProveedores();
            prove.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PrincipalArticulos artic = new PrincipalArticulos();
            artic.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "Admin" && textBoxPass.Text == "Pass")
            {
                groupBoxFunciones.Enabled = true;
                textBoxUsuario.Text = "";
                textBoxPass.Text = "";
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
                textBoxUsuario.Text = "";
                textBoxPass.Text = "";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            groupBoxFunciones.Enabled = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PrincipalClientes cs = new PrincipalClientes();
            cs.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            PrincipalClientes cs = new PrincipalClientes();
            cs.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            PrincipalProveedores pp = new PrincipalProveedores();
            pp.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PrincipalArticulos pa = new PrincipalArticulos();
            pa.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            PrincipalArticulos pa = new PrincipalArticulos();
            pa.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            PrincipalProveedores pp = new PrincipalProveedores();
            pp.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verLaAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarAyuda ay = new MostrarAyuda();
            ay.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe ad = new AcercaDe();
            ad.Show();
        }
    }
}
