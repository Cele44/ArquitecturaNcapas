﻿using sistemaVentas.Modelos;
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
        public DataTable ProductoDatosDal()
        {
            string consulta = "SELECT PRODUCTO.IDPRODUCTO, PRODUCTO.NOMBRE, TIPOPROD.NOMBRE AS TIPO, MARCA.NOMBRE AS MARCAPRODUCTO, PRODUCTO.CODIGOBARRA, PRODUCTO.UNIDAD," +
                " PRODUCTO.DESCRIPCION, PRODUCTO.ESTADO " +
                "FROM PRODUCTO " +
                "INNER JOIN TIPOPROD ON PRODUCTO.IDTIPOPROD = TIPOPROD.IDTIPOPROD " +
                "INNER JOIN MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA";

            
            return conexion.EjecutarDataTabla(consulta, "ffff");
        }

        public DataTable ProductoExamenDal()
        {
            string consulta = "SELECT PRODUCTO.NOMBRE AS NOMBREPRODUCTO, PRODUCTO.CODIGOBARRA , DETALLEING .FECHAVENC " +
                "FROM DETALLEING " +
                "INNER JOIN PRODUCTO ON DETALLEING .IDPRODUCTO = PRODUCTO.IDPRODUCTO " +
                "WHERE DETALLEING.FECHAVENC BETWEEN GETDATE() AND DATEADD(DAY, 30, GETDATE())";

            return conexion.EjecutarDataTabla(consulta, "ffff");
        }

        public DataTable ProductoCanExamenDal()
        {
            string consulta = "SELECT SUM(UNIDAD) AS CANTIDADTOTALPRODUCTOS " +
                "FROM PRODUCTO";

            return conexion.EjecutarDataTabla(consulta, "ffff");
        }
    }
}
