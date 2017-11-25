using GestorProyectoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

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

        public void GuardarProyecto(Proyecto proyecto)
        {
            using (var db = new GestorProyectoDbContext())
            {
                db.Proyecto.Add(proyecto);
                db.SaveChanges();
            }
        }

        public Proyecto BuscarProyecto(int id)
             {
            using (var db = new GestorProyectoDbContext())
            {
                return db.Proyecto.Find(id);
               
            }
        }

        public void EliminarProyecto(int id)
        {
            using (var db = new GestorProyectoDbContext())
            {
                //Proyecto p= BuscarProyecto(id);
                //db.Proyecto.Remove();

                var p = new Proyecto { Id = id };
                db.Entry(p).State = EntityState.Deleted;
               db.Proyecto.Remove(p);
                db.SaveChanges();

            }
        }
        public IEnumerable<Tarea> ObtenerTareas()
        {
            using (var db = new GestorProyectoDbContext())
            {
                return db.Tarea.ToList();
            }
        }

        public void GuardarTarea(Tarea tarea)
        {
            using (var db = new GestorProyectoDbContext())
            {
                db.Tarea.Add(tarea);
                db.SaveChanges();
            }
        }

        public IEnumerable<Nota> ObtenerNotas()
        {
            using (var db = new GestorProyectoDbContext())
            {
                return db.Nota.ToList();
            }
        }

        public  void GuardarNota(Nota nota)
        {
            using (var db = new GestorProyectoDbContext())
            {
                db.Nota.Add(nota);
                db.SaveChanges();
            }
        }

        public IEnumerable<Recurso> ObtenerRecursos()
        {
            using (var db = new GestorProyectoDbContext())
            {
                return db.Recurso.ToList();
            }
        }

        public void GuardarRecurso(Recurso recurso)
        {
            using (var db = new GestorProyectoDbContext())
            {
                db.Recurso.Add(recurso);
                db.SaveChanges();
            }
        }

        public IEnumerable<Usuario> ObtenerUsuarios()
        {
            using (var db = new GestorProyectoDbContext())
            {
                return db.Usuario.ToList();
            }
        }

        public bool BuscarUsuario(string usuario, string cont)
        {
            using (var db = new GestorProyectoDbContext())
            {
                foreach(var u in db.Usuario)
                {
                    if ( u.NombreUsuario == usuario && u.Contraseña == cont)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        public void GuardarUsuario(Usuario usuario)
        {
            using (var db = new GestorProyectoDbContext())
            {
                db.Usuario.Add(usuario);
                db.SaveChanges();
            }
        }
    }
}