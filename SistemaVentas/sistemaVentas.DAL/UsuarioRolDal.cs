using sistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaVentas.DAL
{
    public class UsuarioRolDal
    {
        public DataTable ListarUsuarioRolDal()
        {
            string consulta = " select * from usuariorol";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioRolDal(UsuarioRol usuariorol)
        {
            string consulta = "insert into usuariorol values(" + usuariorol.IdUsuario + " ," +
                                                           "" + usuariorol.IdRol + "," +
                                                           "'" + usuariorol.FechaAsigna+ "'," +
                                                          "'Activo')";

            conexion.Ejecutar(consulta);
        }
        public DataTable UsuarioDatosDal()
        {
            string consulta = "SELECT USUARIO.IDUSUARIO, (PERSONA.NOMBRE+' '+PERSONA.APELLIDO) NOMBRECOMPLETO, USUARIO.NOMBREUSER, " +
                              "ROL.NOMBRE AS NOMBREROL, USUARIOROL.FECHAASIGNA " +
                              "FROM  PERSONA INNER JOIN " +
                         "USUARIO ON PERSONA.IDPERSONA = USUARIO.IDPERSONA INNER JOIN " +
                         "USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO INNER JOIN " +
                         "ROL ON USUARIOROL.IDROL = ROL.IDROL";
            return conexion.EjecutarDataTabla(consulta, "ffff");
        }
            
    }
}
