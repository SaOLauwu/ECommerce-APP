using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ProyectoFinal
{
    internal class EntidadesJSON
    {
        internal class empleado
        {
            public int ci { get; set; }
            public String nombre { get; set; }
            public String apellido { get; set; }
            public string rol { get; set; }
            public string clave { get; set; }
            public string resultado { get; set; }
            
        }

        internal class sentenciaSQL
        {
            public String sql { get; set; }
        }
        
    }
}
