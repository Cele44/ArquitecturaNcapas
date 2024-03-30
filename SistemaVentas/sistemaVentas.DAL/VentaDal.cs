using sistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaVentas.DAL
{
    public class VentaDal
    {
        public DataTable ListarVentaDal()
        {
            string consulta = " select * from venta";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarVentaDal(Venta venta) 
        {
            string consulta = "insert into venta values(" + venta.IdCliente + " ," +
                                                           "" + venta.IdVendedor + "," +
                                                            "'" + venta.Fecha + "'," +
                                                           "" + venta.Total + "," +
                                                          "'Exitoso')";

            conexion.Ejecutar(consulta);
        }
        public DataTable VentaDatosDal()
        {
            string consulta = "SELECT CLIENTE.IDCLIENTE, (PERSONA.NOMBRE+' '+PERSONA.APELLIDO)AS NOMBRE_COMPLETO, VENTA.IDVENDEDOR, VENTA.TOTAL, VENTA.ESTADO " +
                "FROM VENTA " +
                "INNER JOIN CLIENTE ON VENTA.IDCLIENTE = CLIENTE.IDCLIENTE " +
                "INNER JOIN PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA";
            return conexion.EjecutarDataTabla(consulta, "ffff");
        }
    }
        
}

