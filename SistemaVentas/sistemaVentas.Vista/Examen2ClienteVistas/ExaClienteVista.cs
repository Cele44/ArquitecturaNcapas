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

namespace sistemaVentas.Vista.Examen2ClienteVistas
{
    public partial class ExaClienteVista : Form
    {
        public ExaClienteVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void ExaClienteVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ClienteExamenBss();
        }
    }
}
