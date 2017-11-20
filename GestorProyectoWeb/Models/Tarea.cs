using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestorProyectoWeb.Models
{
    [Table("Tarea")]
    public class Tarea
    {
        [Key]
        public int IdTarea { get; set; }

        [Required(ErrorMessage = "No ingreso el nombre")]
        [Display(Name = "Nombre Tarea")]
        [StringLength(30, MinimumLength = 5)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "No ingreso la descripcion")]
        [StringLength(300, MinimumLength = 10)]
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage = "No ingreso la fecha de fin")]
        [Display(Name = "Fecha de Fin")]
        [DataType(DataType.DateTime)]
        public DateTime FechaFin { get; set; }

        public int Avance { get; set; }

        public Proyecto Proyecto { get; set; }

        public virtual List<Usuario> Usuarios { get; set; }

        public virtual List<Recurso> Recursos { get; set; }

        public virtual List<Tarea> TareasDependientes { get; set; }

        public virtual List<Nota> Notas { get; set; }
    }
}