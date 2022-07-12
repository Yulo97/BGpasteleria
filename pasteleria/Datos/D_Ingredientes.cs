using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace pasteleria
{
    public class D_Ingredientes
    {
        public DataTable TraerIngredientes()
        {

            string query = "CALL SP_LISTA_INGREDIENTES()";

            MySqlConnection conexion = Conexion.SqlConexion();
            MySqlCommand comandoSql = new MySqlCommand(query, conexion);
            DataTable tabla = new DataTable();

            try
            {
                MySqlDataAdapter datos = new MySqlDataAdapter(comandoSql);
                conexion.Open();
                datos.Fill(tabla);
                conexion.Close();
            
            }
            catch (Exception)
            {

                throw;
            }

            return tabla;

        }
    }
}
