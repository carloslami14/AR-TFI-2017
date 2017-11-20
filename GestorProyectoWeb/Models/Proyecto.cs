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

        [Required(ErrorMessage = "No ingreso el nombre")]
        [Display(Name = "Nombre del Proyecto")]
        [StringLength(30)]
        public string Nombre { get; set; }

        [StringLength(300)]
        public string Descripcion { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        public virtual List<Usuario> Usuarios { get; set; }

        public virtual List<Tarea> Tareas { get; set; }
    }
}