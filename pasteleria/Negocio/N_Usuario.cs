using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasteleria
{
    internal class N_Usuario
    {
        D_Usuario d_usuario = new D_Usuario();


        public bool VerificacionDeUsuario()
        {
            return d_usuario.IniciarSesion();
        }
    }
}
