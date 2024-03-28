using sistemaVentas.Vista.PNuevo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaVentas.Vista.PSesion
{
    public partial class InSesion : Form
    {
        public InSesion()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de destino
            UserNuevo form2 = new UserNuevo();

            // Mostrar el formulario de destino de manera modal
            form2.ShowDialog();
        }
    }
}
