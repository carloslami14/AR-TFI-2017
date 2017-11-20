using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestorProyectoWeb.Models
{
    public class RecursoHumano: Recurso
    {
        public EnumTipoRecurso TipoRecurso { get; }
        
        public RecursoHumano(int id, string nom, float pre, string desc, List<Tarea> tar)
            :base(id,nom,pre,desc,tar)
        {
            this.TipoRecurso = EnumTipoRecurso.Humano;
        }
    }
}