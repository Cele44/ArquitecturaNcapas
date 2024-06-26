﻿using sistemaVentas.DAL;
using sistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaVentas.BSS
{
    public class ProveedorBss
    {
        ProveedorDal dal = new ProveedorDal();
        public DataTable ListarProveedorBss()
        {
            return dal.ListarProveedorDal();
        }
        public void InsertarProveedorBss(Proveedor proveedor)
        {
            dal.InsertarProveedorDal(proveedor);
        }
       public Proveedor ObtenerIdBss(int id)
        {
            return dal.ObtenerProveedorId(id);
        }
        public void EditarProveedorBss(Proveedor pr)
        {
            dal.EditarProveedorDal(pr);
        }
        public void EliminarProveedorBss(int id)
        {
            dal.EliminarProveedorDal(id);
        }
        public DataTable ProveedorExamenBss()
        {
            return dal.ProveedorExamenDal();
        }
    }
}

