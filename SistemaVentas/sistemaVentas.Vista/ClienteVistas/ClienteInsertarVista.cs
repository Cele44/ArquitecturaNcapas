using sistemaVentas.BSS;
using sistemaVentas.Modelos;
using sistemaVentas.Vista.PersonaVistas;
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

namespace sistemaVentas.Vista.ClienteVistas
{
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
        {
            InitializeComponent();
        }
        /*ClienteBss bss = new ClienteBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.IdPersona = Convert.ToInt32(textBox1.Text);
            c.TipoCliente = textBox2.Text;
            c.CodigoCliente = textBox3.Text;
            bss.InsertarClienteBss(c);

            MessageBox.Show("Se guardo correctamente el cliente");
        }*/
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bss = new PersonaBss();

        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }

        }
        ClienteBss bsscli = new ClienteBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.IdPersona = IdPersonaSeleccionada;
            cliente.TipoCliente = textBox2.Text;
            cliente.CodigoCliente = textBox3.Text;
            bsscli.InsertarClienteBss(cliente);
            MessageBox.Show("Cliente registrado");
        }
    }
}
