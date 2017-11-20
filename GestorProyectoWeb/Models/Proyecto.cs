using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestorProyectoWeb.Models
{
    [Table("Proyecto")]
    public class Proyecto
    {
        [Key]
        public int Id { get; set; }

        public virtual List<Usuario> Usuarios { get; set; }

        [Display(Name = "Nombre del Proyecto")]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        [Display(Name = "Fecha")]
        public DateTime FechaInicio { get; set; }

        public virtual List<Tarea> Tareas { get; set; }
    }
}