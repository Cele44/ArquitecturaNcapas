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

namespace sistemaVentas.Vista.ProveedorVistas
{
    public partial class ProveedorInsertarVista : Form
    {
        public ProveedorInsertarVista()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Proveedor pr = new Proveedor();
            pr.Nombre = textBox1.Text;
            pr.Telefono = textBox2.Text;
            pr.Direccion = textBox3.Text;
            bss.InsertarProveedorBss(pr);

            MessageBox.Show("Se guardo correctamente el proveedor");
        }
    }
}