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

namespace sistemaVentas.Vista.RolVistas
{
    public partial class RolListarVista : Form
    {
        public RolListarVista()
        {
            InitializeComponent();
        }
        RolBss bss = new RolBss();
        private void RolListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarRolBss();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //UsuarioInsertarVista.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RolInsertarVista fr = new RolInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarRolBss();

                // Refrescar la vista del DataGridView OPCIONAL-----
                dataGridView1.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdRolSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            RolEditarVista fr = new RolEditarVista(IdRolSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarRolBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdRolSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar este rol", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarRolBss(IdRolSeleccionada);
                dataGridView1.DataSource = bss.ListarRolBss();
            }
        }
    }
}
