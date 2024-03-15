using sistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaVentas.DAL
{
    public class DetalleingDal
    {
        public DataTable ListarDetalleingDal()
        {
            string consulta = " select * from detalleing";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleingDal(Detalleing detalleing)
        {
            string consulta = "insert into detalleing values(" + detalleing.IdIngreso + " ," +
                                                           "" + detalleing.IdProducto + "," +
                                                           "'" + detalleing.FechaVenc + "'," +
                                                           "" + detalleing.Cantidad + "," +
                                                           "" + detalleing.PrecioCosto + "," +
                                                           "" + detalleing.PrecioVenta + "," +
                                                           "" + detalleing.Subtotal + "," +
                                                          "'Exitoso')";

            conexion.Ejecutar(consulta);
        }
    }
}
