using sistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaVentas.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClienteDal()
        {
            string consulta = " select * from cliente";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values(" + cliente.IdPersona + " ," +
                                                           "'" + cliente.TipoCliente + "'," +
                                                           "'" + cliente.CodigoCliente + "'," +
                                                          "'Activo')";

            conexion.Ejecutar(consulta);
        }
        public DataTable ClienteDatosDal()
        {
            string consulta = "SELECT CLIENTE.IDCLIENTE, (PERSONA.NOMBRE+' '+PERSONA.APELLIDO)AS NOMBRECOMPLETO," +
                "CLIENTE.TIPOCLIENTE, CLIENTE.CODIGOCLIENTE, CLIENTE.ESTADO " +
                "FROM CLIENTE " +
                "INNER JOIN PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA";
            return conexion.EjecutarDataTabla(consulta, "ffff");
        }
        //examen
        public DataTable ClienteExamenDal()
        {
            string consulta = "SELECT CLIENTE.IDCLIENTE, PERSONA.NOMBRE, PERSONA.APELLIDO, CLIENTE.TIPOCLIENTE " +
                "FROM CLIENTE " +
                "INNER JOIN PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA";
            return conexion.EjecutarDataTabla(consulta, "ffff");
        }

        public DataTable ClienteIngExamenDal()
        {
            string consulta = "SELECT CLIENTE.IDCLIENTE,(PERSONA.NOMBRE+' '+ PERSONA.APELLIDO) AS NOMBRECOMPLETO, SUM(VENTA.TOTAL) AS TOTALINGRESOS " +
                "FROM VENTA " +
                "INNER JOIN CLIENTE ON VENTA.IDCLIENTE = CLIENTE.IDCLIENTE " +
                "INNER JOIN PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA " +
                "GROUP BY CLIENTE.IDCLIENTE,PERSONA.NOMBRE, PERSONA.APELLIDO";
            return conexion.EjecutarDataTabla(consulta, "ffff");
        }


    }
}
