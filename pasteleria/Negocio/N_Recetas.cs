using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace pasteleria
{
    internal class N_Recetas
    {
        D_Recetas d_recetas = new D_Recetas();

        public DataTable ListaRecetas()
        {
            return d_recetas.TraerRecetas();
        }
    }
}
