﻿using System;
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
            PrincipalClientes cliente = new PrincipalClientes();
            cliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proveedores prove = new Proveedores();
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
            Proveedores prove = new Proveedores();
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
    }
}
