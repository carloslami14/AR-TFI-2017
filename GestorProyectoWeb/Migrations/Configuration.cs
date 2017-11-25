namespace GestorProyectoWeb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using GestorProyectoWeb.Models;
    using GestorProyectoWeb.Servicios;

    internal sealed class Configuration : DbMigrationsConfiguration<GestorProyectoWeb.Models.GestorProyectoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GestorProyectoWeb.Models.GestorProyectoDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            Usuario u = new Usuario();
            u.NombreUsuario = "carlos";
            u.Contraseña = "1234";
            u.Correo = "carloslami14@gmail.com";

            //using (var bd = Repositorio)
            //{

            //}
        }
    }
}
