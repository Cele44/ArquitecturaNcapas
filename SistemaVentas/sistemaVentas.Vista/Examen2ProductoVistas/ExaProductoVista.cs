﻿using sistemaVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaVentas.Vista.Examen2ProductoVistas
{
    public partial class ExaProductoVista : Form
    {
        public ExaProductoVista()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void ExaProductoVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ProductoExamenBss();
        }
    }
}
