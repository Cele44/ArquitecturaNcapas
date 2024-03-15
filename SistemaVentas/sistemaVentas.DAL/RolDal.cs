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
                                                           "'Activo')";
            conexion.Ejecutar(consulta);
        }

    }
}
