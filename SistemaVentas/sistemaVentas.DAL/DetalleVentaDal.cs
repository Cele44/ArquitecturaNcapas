using sistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaVentas.DAL
{
   public class DetalleVentaDal
   {
        public DataTable ListarDetalleVentaDal()
        {
            string consulta = " select * from detalleventa";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleVentaDal(DetalleVenta detalleventa)
        {
            string consulta = "insert into detalleventa values(" + detalleventa.IdVenta + " ," +
                                                           "" + detalleventa.IdProducto+ "," +
                                                            "" + detalleventa.Cantidad + "," +
                                                            "" + detalleventa.PrecioVenta + "," +
                                                            "" + detalleventa.Subtotal + "," +
                                                          "'Exitoso')";


            conexion.Ejecutar(consulta);
        }


    }
}
