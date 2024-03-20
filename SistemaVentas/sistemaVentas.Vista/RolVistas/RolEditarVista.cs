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

namespace sistemaVentas.Vista.RolVistas
{
    public partial class RolEditarVista : Form
    {
        int idx = 0;
        Rol r = new Rol();
        RolBss bss = new RolBss();
        public RolEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void RolEditarVista_Load(object sender, EventArgs e)
        {
            r = bss.ObtenerIdBss(idx);
            textBox1.Text = r.Nombre;
            textBox2.Text = r.Estado;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           r.Nombre = textBox1.Text;
           r.Estado = textBox2.Text;
           

            bss.EditarRolBss(r);
            MessageBox.Show("Datos actulizados");
        }
    }
}
