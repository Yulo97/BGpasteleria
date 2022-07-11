using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasteleria
{
    internal class Conexion
    {
        public static MySqlConnection SqlConexion()
        {
            try
            {
                //using (MySqlConnection con = new MySqlConnection("SERVER=66.97.46.146;PORT=3306;UID=client;PASSWORD=client40366371;DATABASE=db_gestionblack"))
                using (MySqlConnection con = new MySqlConnection("server=66.97.46.146;persistsecurityinfo=True;database=db_bg_pasteleria; user id = client;" + " password = client40366371;"))
                {
                    try
                    {
                        return con;
                    }
                    catch
                    {

                        return null;
                    }
                }
            }
            catch
            {
                return null;
            }
        }

    }
}
