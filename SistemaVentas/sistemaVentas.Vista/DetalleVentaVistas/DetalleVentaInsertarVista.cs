using sistemaVentas.BSS;
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

namespace sistemaVentas.Vista.DetalleVentaVistas
{
    public partial class DetalleVentaInsertarVista : Form
    {
        public DetalleVentaInsertarVista()
        {
            InitializeComponent();
        }
        DetalleVentaBss bss = new DetalleVentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta d = new DetalleVenta();
            d.IdVenta = Convert.ToInt32(textBox1.Text);
            d.IdProducto = Convert.ToInt32(textBox2.Text);
            d.Cantidad = Convert.ToInt32(textBox3.Text);
            d.PrecioVenta = Convert.ToDecimal(textBox4.Text);
            d.Subtotal = Convert.ToDecimal(textBox5.Text);
            bss.InsertarDetalleVentaBss(d);

            MessageBox.Show("Se guardo correctamente el detalleVenta");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
