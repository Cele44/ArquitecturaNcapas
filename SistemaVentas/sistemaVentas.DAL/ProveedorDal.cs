using sistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaVentas.DAL
{
    public class ProveedorDal
    {
        public DataTable ListarProveedorDal()
        {
            string consulta = " select * from proveedor";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProveedorDal(Proveedor proveedor)
        {
            string consulta = "insert into proveedor values('" + proveedor.Nombre + "' ," +
                                                           "'" + proveedor.Telefono + "'," +
                                                           "'" + proveedor.Direccion + "'," +
                                                           "'" + proveedor.Estado + "')";
                                                           
            conexion.Ejecutar(consulta);
        }
        public Proveedor ObtenerProveedorId(int id)
        {
            string consulta = "select * from proveedor where idproveedor=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Proveedor pr = new Proveedor();
            if (tabla.Rows.Count > 0)
            {
                pr.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idproveedor"]);
                pr.Nombre = tabla.Rows[0]["nombre"].ToString();
                pr.Telefono = tabla.Rows[0]["telefono"].ToString();
                pr.Direccion = tabla.Rows[0]["direccion"].ToString();
                pr.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return pr;

        }
        public void EditarProveedorDal(Proveedor pr)
        {
            string consulta = "update proveedor set nombre='" + pr.Nombre + "'," +
                                                  "telefono='" + pr.Telefono + "'," +
                                                   "direccion='" + pr.Direccion + "' " +
                                "where idproveedor=" + pr.IdProveedor;
            conexion.Ejecutar(consulta);

        }
        public void EliminarProveedorDal(int id)
        {
            string consulta = "delete from proveedor where idproveedor=" + id;
            conexion.Ejecutar(consulta);
        }


        //examen
        public DataTable ProveedorExamenDal()
        {
            string consulta = "SELECT PROVEEDOR.NOMBRE, SUM(INGRESO.TOTAL) AS TOTALINGRESOS " +
                "FROM INGRESO INGRESO " +
                "INNER JOIN PROVEEDOR ON INGRESO.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR " +
                "GROUP BY PROVEEDOR.NOMBRE";
            return conexion.EjecutarDataTabla(consulta, "ffff");
        }
    }
}
