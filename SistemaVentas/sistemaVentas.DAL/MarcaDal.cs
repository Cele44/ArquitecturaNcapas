using sistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaVentas.DAL
{
    public class MarcaDal
    {
        public DataTable ListarMarcaDal()
        {
            string consulta = " select * from marca";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarMarcaDal(Marca marca)
        {
            string consulta = "insert into marca values('" + marca.Nombre + "' ," +
                                                         "'" + marca.Estado + "')";
            conexion.Ejecutar(consulta);
        }
        public Marca ObtenerMarcaId(int id)
        {
            string consulta = "select * from marca where idmarca=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Marca m = new Marca();
            if (tabla.Rows.Count > 0)
            {
                m.IdMarca = Convert.ToInt32(tabla.Rows[0]["idmarca"]);
                m.Nombre = tabla.Rows[0]["nombre"].ToString();
                m.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return m;

        }
        public void EditarMarcaDal(Marca m)
        {
            string consulta = "update marca set nombre='" + m.Nombre + "'," +
                                                 "estado='" + m.Estado + "' " +
                               "where idmarca=" + m.IdMarca;
            conexion.Ejecutar(consulta);
        }
        public void EliminarMarcaDal(int id)
        {
            string consulta = "delete from marca where idmarca=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
