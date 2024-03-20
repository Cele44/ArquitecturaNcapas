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

namespace sistemaVentas.Vista.UsuarioVistas
{
    public partial class UsuarioInsertarVista : Form
    {
        public UsuarioInsertarVista()
        {
            InitializeComponent();
        }

        /* UsuarioBss bss = new UsuarioBss();
         private void button1_Click(object sender, EventArgs e)
         {
             Usuario u = new Usuario();
             u.IdPersona = Convert.ToInt32(textBox1.Text);
             u.NombreUser = textBox2.Text;
             u.Contraseña = textBox3.Text;
             u.FechaReg = dateTimePicker1.Value;
             bss.InsertarUsuarioBss(u);

             MessageBox.Show("Se guardo correctamente el usuario");
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

        UsuarioBss bssuser = new UsuarioBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.IdPersona = IdPersonaSeleccionada;
            usuario.NombreUser = textBox2.Text;
            usuario.Contraseña = textBox3.Text;
            usuario.FechaReg = dateTimePicker1.Value;
            bssuser.InsertarUsuarioBss(usuario);
            MessageBox.Show("Usuario registrado");
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}

