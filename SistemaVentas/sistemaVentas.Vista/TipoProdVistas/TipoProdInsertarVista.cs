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

namespace sistemaVentas.Vista.TipoProdVistas
{
    public partial class TipoProdInsertarVista : Form
    {
        public TipoProdInsertarVista()
        {
            InitializeComponent();
        }
        TipoProdBss bss = new TipoProdBss();
        private void button1_Click(object sender, EventArgs e)
        {
            TipoProd t = new TipoProd();
            t.Nombre = textBox1.Text;
            bss.InsertarTipoProdBss(t);
            MessageBox.Show("Se guardo correctamente el tipo de producto");
        }
    }
}
