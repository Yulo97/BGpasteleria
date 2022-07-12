using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace pasteleria
{
    internal class N_Ingredientes
    {
        D_Ingredientes d_ingredientes = new D_Ingredientes();

        public DataTable ListaIngredientes()
        {
            return d_ingredientes.TraerIngredientes();
        }
    }
}
