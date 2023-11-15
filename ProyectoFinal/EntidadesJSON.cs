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
            public string rol { get; set; }
            public string clave { get; set; }
            public string resultado { get; set; }
            
        }
        internal class Almacen
        {
            public int ID_Almacen { get; set; }
            public string Ubicacion { get; set; }
            public decimal Capacidad_Maxima { get; set; }
            public int Productos_Actuales { get; set; }
            public int? Responsable { get; set; }
            public int? IDRuta { get; set; }
        }

        internal class Paquete
        {
            public int ID_Paquete { get; set; }
            public string Descripcion { get; set; }
            public decimal Peso { get; set; }
            public string Estado { get; set; }
            public int? ID_Almacen { get; set; }
            public int? ID_Lote { get; set; }
        }

        internal class Lote
        {
            public int ID_Lote { get; set; }
            public DateTime Fecha_Creacion { get; set; }
            public int ID_Almacen { get; set; }
            public string Estado { get; set; }
            public int AlmacenDestino { get; set; }
        }

        internal class InfoLote
        {
            public int ID_Almacen { get; set; }
            public List<int> IDsPaquetes { get; set; }
        }


        internal class sentenciaSQL
        {
            public String sql { get; set; }
        }

        internal class Transporte
        {
            public string Matricula { get; set; }
            public string Tipo { get; set; }
            public string Estado { get; set; }
        }

        public class Ruta
        {
            public string Destino { get; set; }
            public decimal DuracionEstimada { get; set; }
        }

        public class SesionUsuario
        {
            public static int CiChofer { get; set; }
        }


    }
}
