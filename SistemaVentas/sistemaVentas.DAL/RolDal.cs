using sistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaVentas.DAL
{
    public class RolDal
    {
        public DataTable ListarRolDal()
        {
            string consulta = " select * from rol";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarRolDal(Rol rol)
        {
            string consulta = "insert into rol values('" + rol.Nombre + "' ," +
                                                      "'" + rol.Estado + "')";
            conexion.Ejecutar(consulta);
        }
        public Rol ObtenerRolId(int id)
        {
            string consulta = "select * from rol where idrol=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Rol r = new Rol();
            if (tabla.Rows.Count > 0)
            {
                r.IdRol = Convert.ToInt32(tabla.Rows[0]["idrol"]);
                r.Nombre = tabla.Rows[0]["nombre"].ToString();
                r.Estado= tabla.Rows[0]["estado"].ToString();
            }
            return r;

        }
        public void EditarRolDal(Rol r)
        {
            string consulta = "update rol set nombre='" + r.Nombre + "'," +
                                                 "estado='" + r.Estado + "' " +
                               "where idrol=" + r.IdRol;
            conexion.Ejecutar(consulta);
        }
        public void EliminarRolDal(int id)
        {
            string consulta = "delete from rol where idrol=" + id;
            conexion.Ejecutar(consulta);
        }

    }
}
