using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestorProyectoWeb.Models
{
    public class RecursoHardware: Recurso
    {
        public EnumTipoRecurso TipoRecurso { get; set; }
        public int Cantidad { get; set; }

        public RecursoHardware(int id, string nom, float pre, string desc, List<Tarea> tar, int cant)
            :base(id,nom,pre,desc, tar)
        {
            this.TipoRecurso = EnumTipoRecurso.Hardware;
            this.Cantidad = cant;
        }
    }
}