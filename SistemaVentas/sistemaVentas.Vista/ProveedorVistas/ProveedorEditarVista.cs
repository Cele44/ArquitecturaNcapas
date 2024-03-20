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
    public partial class ProveedorEditarVista : Form
    {
        int idx = 0;
        Proveedor pr = new Proveedor();
        ProveedorBss bss = new ProveedorBss();
        public ProveedorEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ProveedorEditarVista_Load(object sender, EventArgs e)
        {
            pr = bss.ObtenerIdBss(idx);
            textBox1.Text = pr.Nombre;
            textBox2.Text = pr.Telefono;
            textBox3.Text = pr.Direccion;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pr.Nombre = textBox1.Text;
            pr.Telefono = textBox2.Text;
            pr.Direccion = textBox3.Text;

            bss.EditarProveedorBss(pr);
            MessageBox.Show("Datos actulizados");
        }
    }
}
