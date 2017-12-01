using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestorProyectoWeb.Models
{
    public class RecursoSoftware: Recurso
    {
        public RecursoSoftware() { }

        public EnumTipoRecurso TipoRecurso { get; set; }
        public int Cantidad { get; set; }

        public RecursoSoftware(int id, string nom, float pre, string desc, List<Tarea> tar, int cant)
            :base(id,nom,pre,desc,tar)
        {
            this.TipoRecurso = EnumTipoRecurso.Software;
            this.Cantidad = cant;
        }
    }
}