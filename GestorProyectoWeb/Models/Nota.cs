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
        [Key]
        public int IdNota { get; set; }
        public Tarea  Tarea { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
    }
}