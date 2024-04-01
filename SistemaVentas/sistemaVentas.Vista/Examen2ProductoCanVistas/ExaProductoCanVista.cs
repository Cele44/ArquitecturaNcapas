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

namespace sistemaVentas.Vista.Examen2ProductoCanVistas
{
    public partial class ExaProductoCanVista : Form
    {
        public ExaProductoCanVista()
        {
            InitializeComponent();
        }
        ProductoBss bss=new ProductoBss();
        private void ExaProductoCanVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ProductoCanExamenBss();
        }
    }
}
