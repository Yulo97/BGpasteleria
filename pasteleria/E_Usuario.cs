using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasteleria
{
    public class E_Usuario
    {
        private static string _usuarioID;
        private static string _usuarioName;
        private static string _usuarioPass;
        private static string _usuarioNomApe;
        private static string _usuarioTelefono;

        public static string UsuarioID { get => _usuarioID; set => _usuarioID = value; }
        public static string UsuarioName { get => _usuarioName; set => _usuarioName = value; }
        public static string UsuarioPass { get => _usuarioPass; set => _usuarioPass = value; }
        public static string UsuarioNomApe { get => _usuarioNomApe; set => _usuarioNomApe = value; }
        public static string UsuarioTelefono { get => _usuarioTelefono; set => _usuarioTelefono = value; }
    }
}
