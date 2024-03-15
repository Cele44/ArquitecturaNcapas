using sistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaVentas.DAL
{
    public class ProductoDal
    {
        public DataTable ListarProductoDal()
        {
            string consulta = " select * from producto";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProductoDal(Producto producto)
        {
            string consulta = "insert into producto values(" + producto.IdTipoProd + " ," +
                                                           "" + producto.IdMarca + "," +
                                                           "'" + producto.Nombre+ "'," +
                                                           "'" + producto.CodigoBarra + "'," +
                                                           "" + producto.Unidad + "," +
                                                           "'" + producto.Descripcion + "'," +
                                                          "'Activo')";

            conexion.Ejecutar(consulta);
        }
    }
}
