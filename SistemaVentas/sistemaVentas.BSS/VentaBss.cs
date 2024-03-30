using sistemaVentas.DAL;
using sistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaVentas.BSS
{
    public class VentaBss
    {
        VentaDal dal = new VentaDal();
        public DataTable ListarVentaBss()
        {
            return dal.ListarVentaDal();
        }
        public void InsertarVentaBss(Venta venta)
        {
            dal.InsertarVentaDal(venta);
        }
        public DataTable VentaDatosBss()
        {
            return dal.VentaDatosDal();
        }
    }
}
