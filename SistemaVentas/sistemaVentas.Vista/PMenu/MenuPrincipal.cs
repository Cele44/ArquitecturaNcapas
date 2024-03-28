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

namespace sistemaVentas.Vista.PMenu
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           PUser.UserGeneral u = new PUser.UserGeneral();

            // Mostrar el formulario de destino de manera modal
            u.ShowDialog();
        }
    }
}

