﻿using sistemaVentas.BSS;
using sistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sistemaVentas.Vista.MarcaVistas
{
    public partial class MarcaInsertarVista : Form
    {
        public MarcaInsertarVista()
        {
            InitializeComponent();
        }

        MarcaBss bss = new MarcaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Marca m = new Marca();
            m.Nombre = textBox1.Text;
            m.Estado = textBox2.Text;
            bss.InsertarMarcaBss(m);
            MessageBox.Show("Se guardo correctamente la marca");

        }

        private void MarcaInsertarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
