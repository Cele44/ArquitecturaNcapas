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

namespace sistemaVentas.Vista.UsuarioRolVistas
{
    public partial class UsuarioDatosVista : Form
    {
        public UsuarioDatosVista()
        {
            InitializeComponent();
        }
        UsuarioRolBss bss = new UsuarioRolBss();
        private void UsuarioDatosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.UsuarioDatosBss();
        }
    }
}
