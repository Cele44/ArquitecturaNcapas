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

namespace sistemaVentas.Vista.Examen2MarcaVistas
{
    public partial class ExaMarcaVista : Form
    {
        public ExaMarcaVista()
        {
            InitializeComponent();
        }
        MarcaBss bss=new MarcaBss();
        private void ExaMarcaVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.MarcaExamenBss();
        }
    }
}
