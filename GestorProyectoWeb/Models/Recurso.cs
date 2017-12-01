using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestorProyectoWeb.Models
{
    [Table("Recurso")]
    public abstract class Recurso
    {
        public Recurso() { } 
        [Key]
        public int IdRecurso { get; set; }

        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }

        [Required]
        public float Precio { get; set; }

        [StringLength(300)]
        public string Descripcion { get; set; }

        public virtual List<Tarea> Tareas { get; set; }

        public Recurso(int id, string nom, float pre, string desc, List<Tarea> tar)
        {
            this.IdRecurso = id;
            this.Nombre = nom;
            this.Precio = pre;
            this.Descripcion = desc;
            this.Tareas = tar;
        }
    }
}