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
        public DataTable DetallingDatosDal()
        {
            string consulta = "SELECT P.NOMBRE AS NombreProducto,DI.FECHAVENC,DI.CANTIDAD,DI.PRECIOCOSTO,DI.PRECIOVENTA," +
            "DI.SUBTOTAL*CANTIDAD AS SUBTOTAL,DI.ESTADO " +
            "FROM DETALLEING DI " +
            "INNER JOIN INGRESO I ON DI.IDINGRESO = I.IDINGRESO " +
            "INNER JOIN PRODUCTO P ON DI.IDPRODUCTO = P.IDPRODUCTO " +
            "INNER JOIN PROVEEDOR PR ON I.IDPROVEEDOR = PR.IDPROVEEDOR";
            return conexion.EjecutarDataTabla(consulta, "ffff");

        }
        

    }
}
