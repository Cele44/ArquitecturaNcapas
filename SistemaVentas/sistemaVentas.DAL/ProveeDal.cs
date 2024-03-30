using sistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaVentas.DAL
{
    public class ProveeDal
    {
        public DataTable ListarProveeDal()
        {
            string consulta = " select * from provee";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProveeDal(Provee provee)
        {
            string consulta = "insert into provee values(" + provee.IdProducto + " ," +
                                                           "" + provee.IdProveedor + "," +
                                                            "'" + provee.Fecha + "'," +
                                                           "" + provee.Precio + ")";


            conexion.Ejecutar(consulta);
        }

        public DataTable ProveeDatosDal()
        {
            string consulta = "SELECT PRODUCTO.IDPRODUCTO, PRODUCTO.NOMBRE AS NOMBREPRODUCTO, PROVEEDOR.NOMBRE AS NOMBREPROVEEDOR, PROVEE.FECHA, PROVEE.PRECIO " +
                "FROM PROVEE INNER JOIN " +
                "PRODUCTO ON PROVEE.IDPRODUCTO = PRODUCTO.IDPRODUCTO " +
                "INNER JOIN PROVEEDOR ON PROVEE.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR";
            return conexion.EjecutarDataTabla(consulta, "ffff");
        }

    }
}
