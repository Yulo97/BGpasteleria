using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows; //incluido para usar MessageBox

namespace pasteleria
{
    public class D_Usuario
    {
        public bool IniciarSesion()
        {
            string name = E_Usuario.UsuarioName;
            string pass = E_Usuario.UsuarioPass;

            MySqlDataReader reader;
            string query = "CALL SP_INICIAR_SESION(@name, @pass)";

            MySqlConnection conexion = Conexion.SqlConexion();
            MySqlCommand comandoSql = new MySqlCommand(query, conexion);
            comandoSql.Parameters.AddWithValue("@name", name);
            comandoSql.Parameters.AddWithValue("@pass", pass);


            try
            {
                conexion.Open();
                reader = comandoSql.ExecuteReader();
                if (reader.HasRows)
                {
                    conexion.Close();
                    return true;
                }
                else
                {
                    conexion.Close();
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
