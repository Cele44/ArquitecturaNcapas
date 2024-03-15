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

namespace sistemaVentas.Vista.ProductoVistas
{
    public partial class ProductoInsertarVista : Form
    {
        public ProductoInsertarVista()
        {
            InitializeComponent();
        }

        ProductoBss bss = new ProductoBss();

        private void button1_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.IdTipoProd = Convert.ToInt32(textBox1.Text);
            p.IdMarca = Convert.ToInt32(textBox2.Text);
            p.Nombre = textBox3.Text;
            p.CodigoBarra = textBox4.Text;
            p.Unidad = Convert.ToInt32(textBox5.Text);
            p.Descripcion = textBox6.Text;
            bss.InsertarProductoBss(p);

            MessageBox.Show("Se guardo correctamente el producto");
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

