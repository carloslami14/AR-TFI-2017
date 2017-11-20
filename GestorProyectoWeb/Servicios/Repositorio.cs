using GestorProyectoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestorProyectoWeb.Servicios
{
    public class Repositorio
    {
        public IEnumerable<Proyecto> ObtenerProyectos()
        {
            using (var db = new GestorProyectoDbContext())
            {
                return db.Proyecto.ToList();
            }
        }

        public void CrearProyecto(Proyecto proyecto)
        {
            using (var db = new GestorProyectoDbContext())
            {
                db.Proyecto.Add(proyecto);
                db.SaveChanges();
            }
        }
    }
}