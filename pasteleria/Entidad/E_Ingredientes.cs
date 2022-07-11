using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasteleria
{
    class E_Ingredientes
    {
        private string _nombre;
        private string _unidadMedida;
        private double _precio;


        public string Nombre { get => _nombre; set => _nombre = value; }
        public string UnidadMedida { get => _unidadMedida; set => _unidadMedida = value; }
        public double Precio { get => _precio; set => _precio = value; }

        public E_Ingredientes(string nombre, string unidadMedida, double precio)
        {
            _nombre = nombre;
            _unidadMedida = unidadMedida;
            _precio = precio;
        }

    }
}
