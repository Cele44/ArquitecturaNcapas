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
    public class UsuarioRolBss
    {
        UsuarioRolDal dal = new UsuarioRolDal();
        public DataTable ListarUsuarioRolBss()
        {
            return dal.ListarUsuarioRolDal();
        }
        public void InsertarUsuarioRolBss(UsuarioRol usuariorol)
        {
            dal.InsertarUsuarioRolDal(usuariorol);
        }
        public DataTable UsuarioDatosBss()
        {
            return dal.UsuarioDatosDal();
        }
    }
}
