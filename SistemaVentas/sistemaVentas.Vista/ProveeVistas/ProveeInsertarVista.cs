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

namespace sistemaVentas.Vista.ProveeVistas
{
    public partial class ProveeInsertarVista : Form
    {
        public ProveeInsertarVista()
        {
            InitializeComponent();
        }
        ProveeBss bss = new ProveeBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Provee pr = new Provee();
            pr.IdProducto = Convert.ToInt32(textBox1.Text);
            pr.IdProveedor = Convert.ToInt32(textBox2.Text);
            pr.Fecha = dateTimePicker1.Value;
            pr.Precio = Convert.ToDecimal(textBox3.Text);
            bss.InsertarProveeBss(pr);

            MessageBox.Show("Se guardo correctamente el provee");

        }
    }
}

