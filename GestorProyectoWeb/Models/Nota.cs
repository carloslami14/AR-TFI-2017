using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestorProyectoWeb.Models
{
    [Table("Nota")]
    public class Nota
    {
        public Nota() { }
        
        [Key]
        public int IdNota { get; set; }

        [Required]
        public Tarea Tarea { get; set; }

        [StringLength(300)]
        public string Descripcion { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }
    }
}