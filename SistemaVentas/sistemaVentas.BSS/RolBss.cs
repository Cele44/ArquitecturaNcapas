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
    public class RolBss
    {
        RolDal dal = new RolDal();
        public DataTable ListarRolBss()
        {
            return dal.ListarRolDal();
        }
        public void InsertarRolBss(Rol rol)
        {
            dal.InsertarRolDal(rol);
        }
    }
}
