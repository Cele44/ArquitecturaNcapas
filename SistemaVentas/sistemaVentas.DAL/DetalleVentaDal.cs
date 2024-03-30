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
        public DataTable VentaDetalleDatosDal()
        {
            string consulta = "SELECT DV.IDVENTA,C.NOMBRE AS NOMBRE_CLIENTE,P.NOMBRE AS NOMBREPRODUCTO,DV.CANTIDAD,DV.PRECIOVENTA,DV.SUBTOTAL,V.ESTADO " +
           "FROM DETALLEVENTA DV " +
           "INNER JOIN VENTA V ON DV.IDVENTA = V.IDVENTA " +
           "INNER JOIN CLIENTE CL ON V.IDCLIENTE = CL.IDCLIENTE " +
           "INNER JOIN PRODUCTO P ON DV.IDPRODUCTO = P.IDPRODUCTO " +
           "INNER JOIN PERSONA C ON CL.IDPERSONA = C.IDPERSONA";
            return conexion.EjecutarDataTabla(consulta, "ffff");
        }
       

    }
}
