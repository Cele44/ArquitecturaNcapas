using sistemaVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaVentas.Vista.DetalleingVistas
{
    public partial class DetallingDatosVista : Form
    {
        public DetallingDatosVista()
        {
            InitializeComponent();
        }
        DetalleingBss bss = new DetalleingBss();
        private void DetallingDatosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.DetallingDatosBss();
        }
    }
}
