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

namespace sistemaVentas.Vista.Examen2VendedorVistas
{
    public partial class ExaUsuarioVista : Form
    {
        public ExaUsuarioVista()
        {
            InitializeComponent();
        }
        UsuarioBss bss = new UsuarioBss();
        private void ExaUsuarioVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.UsuarioExamenBss();
        }
    }
}
