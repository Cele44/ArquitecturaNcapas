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

namespace sistemaVentas.Vista.ProveeVistas
{
    public partial class ProveeDatosVista : Form
    {
        public ProveeDatosVista()
        {
            InitializeComponent();
        }
        ProveeBss bss = new ProveeBss();
        private void ProveeDatosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ProveeDatosBss();
          
        }
    }
}
