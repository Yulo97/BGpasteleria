using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace pasteleria
{
    internal class D_Usuario
    {
        public void IniciarSesion()
        {
            string name = E_Usuario.UsuarioName;
            string pass = E_Usuario.UsuarioPass;

            MySqlDataReader reader = null;
            string query = $"CALL SP_INICIAR_SESION(${name}, ${pass})";

            MySqlConnection conexion = Conexion.SqlConexion();
            MySqlCommand comandoSql = new MySqlCommand(query, conexion);

            try
            {
                conexion.Open();
                reader = comandoSql.ExecuteReader();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
