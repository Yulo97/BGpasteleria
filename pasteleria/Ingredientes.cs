using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasteleria
{
    class Ingredientes
    {
        private static string _nombre;
        private static string _unidadMedida;
        private static double _precio;

        public static string Nombre { get => _nombre; set => _nombre = value; }
        public static string UnidadMedida { get => _unidadMedida; set => _unidadMedida = value; }
        public static double Precio { get => _precio; set => _precio = value; }


    }
}
