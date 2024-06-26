namespace sistemaVentas.Vista
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Examen2ClienteVistas.ExaClienteVista());
            Application.Run(new ExamenProveedorVista.ExaProveedorVista());
            Application.Run(new Examen2MarcaVistas.ExaMarcaVista());
            Application.Run(new Examen2ProductoCanVistas.ExaProductoCanVista());
            Application.Run(new Examen2ProductoVistas.ExaProductoVista());
            Application.Run(new Examen2VendedorVistas.ExaUsuarioVista());
            Application.Run(new Examen2ClieIngresosVistas.ExaClieIngresoVista());

            /* Application.Run(new UsuarioRolVistas.UsuarioDatosVista());
             Application.Run(new ClienteVistas.ClienteDatosVista());
             Application.Run(new ProductoVistas.ProductoDatosVista());
             Application.Run(new ProveeVistas.ProveeDatosVista());
             Application.Run(new IngresoVistas.IngresoDatosVista());
             Application.Run(new VentaVistas.VentaDatosVista());
             Application.Run(new DetalleVentaVistas.DetalleVentaDatosVista());
             Application.Run(new DetalleingVistas.DetallingDatosVista());*/



            /*Application.Run(new PersonaVistas.PersonaInsertarVista());
            Application.Run(new ClienteVistas.ClienteInsertarVista());
            Application.Run(new RolVistas.RolInsertarVista());
            Application.Run(new TipoProdVistas.TipoProdInsertarVista());
            Application.Run(new MarcaVistas.MarcaInsertarVista());
            Application.Run(new ProveedorVistas.ProveedorInsertarVista());
            Application.Run(new UsuarioRolVistas.UsuarioRolInsertarVista());
            Application.Run(new IngresoVistas.IngresoInsertarVista());
            Application.Run(new VentaVistas.VentaInsertarVista());
            Application.Run(new ProductoVistas.ProductoInsertarVista());
            Application.Run(new ProveeVistas.ProveeInsertarVista());
            Application.Run(new DetalleVentaVistas.DetalleVentaInsertarVista());
            Application.Run(new DetalleingVistas.DetalleingInsertarVista());
            /*listar*/
            /*Application.Run(new PersonaVistas.PersonaListarVista());
            Application.Run(new ProveedorVistas.ProveedorListarVista());
            Application.Run(new RolVistas.RolListarVista());
            Application.Run(new TipoProdVistas.TipoProdListarVista());
            Application.Run(new UsuarioVistas.UsuarioInsertarVista());
            Application.Run(new UsuarioVistas.UsuarioListarVista());
            Application.Run(new MarcaVistas.MarcaListarVista());
            Application.Run(new UsuarioRolVistas.UsuarioRolListarVista());
             Application.Run(new ClienteVistas.ClienteListarVista());
             Application.Run(new IngresoVistas.IngresoListarVista());
             Application.Run(new VentaVistas.VentaListarVista());
             Application.Run(new ProductoVistas.ProductoListarVista());
             Application.Run(new ProveeVistas.ProveeListarVista());
             Application.Run(new DetalleVentaVistas.DetalleVentaListarVista());
             Application.Run(new DetalleingVistas.DetalleingListarVista());*/

        }
    }
}
