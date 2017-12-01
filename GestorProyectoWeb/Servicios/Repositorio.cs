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
        // Proyecto

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
                var proyecto = db.Proyecto.Include("Tareas").FirstOrDefault(p => p.Id == id);

                return proyecto;
            }
        }

        public Proyecto BuscarProyectoSolo(int id)
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
                var p = new Proyecto { Id = id };
                db.Entry(p).State = EntityState.Deleted;
                db.Proyecto.Remove(p);
                db.SaveChanges();
            }
        }

        public void ModificarProyecto(Proyecto p)
        {
            using (var db = new GestorProyectoDbContext())
            {
                db.Entry(p).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        // Tarea

        public IEnumerable<Tarea> ObtenerTareas()
        {
            using (var db = new GestorProyectoDbContext())
            {
                return db.Tarea.ToList();
            }
        }

        public void GuardarTarea(Tarea tarea, int id)
        {
            using (var db = new GestorProyectoDbContext())
            {
                tarea.ProyectoId = id;
                db.Tarea.Add(tarea);
                db.SaveChanges();
            }
        }

        public IEnumerable<Tarea> Obtenertareas(int IdProyecto)
        {
            using (var db = new GestorProyectoDbContext())
            {
                var tareas = (from pp in db.Tarea
                             where pp.Proyecto.Id == IdProyecto
                             select pp);
                return tareas.ToList();
            }
        }

        public Tarea BuscarTarea(int idTarea)
        {
            using (var db = new GestorProyectoDbContext())
            {
                var tarea = db.Tarea.Include("Proyecto").FirstOrDefault(p => p.IdTarea == idTarea);
                return db.Tarea.Find(idTarea);
            }
        }

        // Nota

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

        //Recurso

        public IEnumerable<Recurso> ObtenerRecursosSoftware()
        {
            using (var db = new GestorProyectoDbContext())
            {
                IQueryable<Recurso> recursos = db.Recurso;
                var recursosSoftware = recursos.OfType<RecursoSoftware>().ToList();
                return recursosSoftware;
            }
        }

        public IEnumerable<Recurso> ObtenerRecursoHardware()
        {
            using (var db = new GestorProyectoDbContext())
            {
                IQueryable<Recurso> recursos = db.Recurso;
                var recursosHardware = recursos.OfType<RecursoHardware>().ToList();
                return recursosHardware;
            }
        }

        public IEnumerable<Recurso> ObtenerRecursosHumano()
        {
            using (var db = new GestorProyectoDbContext())
            {
                IQueryable<Recurso> recursos = db.Recurso;
                var recursosHumano = recursos.OfType<RecursoHumano>().ToList();
                return recursosHumano;
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

        // Usuario

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