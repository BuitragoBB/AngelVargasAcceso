using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public class Controlador_provedor
    {
        public static List<Provedor> CargarDatosProvedor()
        {
            List<Provedor> losProductos = new List<Provedor>();
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=ANGEL\MSSQLSERVER01;Database=Supermercado;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"SELECT id_provedor,nombre,telefono,cedula FROM  Provedor";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta


                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader 
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int id_provedor = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    string telefono = reader.GetString(2);
                    string cedula = reader.GetString(3);



                    Provedor nuevo = new Provedor
                    {
                        Idprovedor = id_provedor,                       
                        Nombre = nombre,
                        Telefono = telefono,
                        Cedula = cedula
                       
                    };
                    losProductos.Add(nuevo);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hemos encontrado un error ({ex.Message})");
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return losProductos;
        }



    }
}
