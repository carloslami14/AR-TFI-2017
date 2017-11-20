using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace GestorProyectoWeb.Models
{
    public class GestorProyectoDbContext: DbContext
    {
        public GestorProyectoDbContext()
            :base("Conexion")
        {
        }

        public DbSet<Proyecto> Proyecto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Tarea> Tarea { get; set; }
        public DbSet<Recurso> Recurso { get; set; }
        public DbSet<Nota> Nota { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


            // Relacion Muchos a Muchos, Tarea-Recurso 
            modelBuilder.Entity<Tarea>().HasMany(x => x.Recursos).WithMany(x => x.Tareas)
                .Map(m =>
                {
                    m.ToTable("Tarea_Recurso");
                    m.MapLeftKey("IdTarea");
                    m.MapRightKey("IdRecurso");
                });

            // Relacion Muchos a Muchos, Tarea-Usuario
            modelBuilder.Entity<Tarea>().HasMany(x => x.Usuarios).WithMany(x => x.Tareas)
                .Map(m =>
                {
                    m.ToTable("Tarea_Usuario");
                    m.MapLeftKey("IdTarea");
                    m.MapRightKey("IdUsuario");
                });

            // Relacion Uno a Muchos, Proyecto-Usuario
            modelBuilder.Entity<Proyecto>().HasMany(x => x.Usuarios);
        }
    }
}