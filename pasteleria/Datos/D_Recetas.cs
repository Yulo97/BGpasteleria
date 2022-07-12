using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace pasteleria
{
    internal class D_Recetas
    {
        public DataTable TraerRecetas()
        {

            string query = "CALL SP_LISTA_RECETAS()";

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