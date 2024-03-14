using sistemaVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaVentas.BSS
{
    public class DetalleingBss
    {
        DetalleingDal dal = new DetalleingDal();
        public DataTable ListarDetalleingBss()
        {
            return dal.ListarDetalleingDal();
        }
    }
}
