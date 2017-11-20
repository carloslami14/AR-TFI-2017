using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace GestorProyectoWeb.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [StringLength(30)]
        public string NombreUsuario { get; set; }

        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(25)]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int Telefono { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public EnumTipoUsuario TipoUsuario { get; set; }

        public virtual List<Tarea> Tareas { get; set; }
    }
}