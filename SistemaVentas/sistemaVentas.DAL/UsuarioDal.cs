using sistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaVentas.DAL
{
    public class UsuarioDal
    {
        public DataTable ListarUsuarioDal()
        {
            string consulta = " select * from usuario";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioDal(Usuario usuario)
        {
            string consulta = "insert into usuario values(" + usuario.IdPersona + " ," +
                                                           "'" + usuario.NombreUser + "'," +
                                                           "'" + usuario.Contraseña + "'," +
                                                           "'" + usuario.FechaReg + "')";
                                                         
            conexion.Ejecutar(consulta);
        }
        public DataTable UsuarioExamenDal()
        {
            string consulta = "SELECT (PERSONA.NOMBRE+' '+PERSONA.APELLIDO) AS NOMBREVENDEDOR,COUNT(DETALLEVENTA.IDPRODUCTO) AS CANTIDADPRODUCTOSVENDIDOS " +
                "FROM VENTA " +
                "INNER JOIN USUARIO ON VENTA.IDVENDEDOR = USUARIO.IDUSUARIO " +
                "INNER JOIN PERSONA ON USUARIO.IDPERSONA = PERSONA.IDPERSONA " +
                "INNER JOIN DETALLEVENTA ON VENTA.IDVENTA = DETALLEVENTA.IDVENTA " +
                "GROUP BY PERSONA.NOMBRE, PERSONA.APELLIDO";

            return conexion.EjecutarDataTabla(consulta, "ffff");
        }
    }
}
