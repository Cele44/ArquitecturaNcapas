using sistemaVentas.BSS;
using sistemaVentas.Vista.PersonaVistas;
using sistemaVentas.Vista.UsuarioVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaVentas.Vista.ProveedorVistas
{
    public partial class ProveedorListarVista : Form
    {
        public ProveedorListarVista()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();
        private void ProveedorListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveedorBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UsuarioInsertarVista.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProveedorInsertarVista fr = new ProveedorInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProveedorBss();

                // Refrescar la vista del DataGridView OPCIONAL-----
                dataGridView1.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdProveedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveedorEditarVista fr = new ProveedorEditarVista(IdProveedorSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProveedorBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdProveedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar este proveedor", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarProveedorBss(IdProveedorSeleccionada);
                dataGridView1.DataSource = bss.ListarProveedorBss();
            }
        }
    }
}
