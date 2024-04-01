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

namespace sistemaVentas.Vista.ExamenProveedorVista
{
    public partial class ExaProveedorVista : Form
    {
        public ExaProveedorVista()
        {
            InitializeComponent();
        }
        ProveedorBss bss=new ProveedorBss();
        private void ExaProveedorVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ProveedorExamenBss();
        }
    }
}
