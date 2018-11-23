using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Principal
{
   public class Controlador_producto
    {

        public static List<Producto> CargarDatosProductos()
        {
            List<Producto> losProductos = new List<Producto>();
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=ANGEL\MSSQLSERVER01;Database=Supermercado;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"SELECT id_producto,Nombreproducto,cantidad,valor FROM  Producto";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta


                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader 
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int Idproducto = reader.GetInt32(0);
                    string nombreProducto = reader.GetString(1);
                    int cantidadProducto = reader.GetInt32(2);
                    int valorProducto = reader.GetInt32(3);
                    

                    Producto venta = new Producto
                    {
                        
                        Codigo = Idproducto,
                        Nombre = nombreProducto,
                        Cantidad = cantidadProducto,
                        Valor = valorProducto


                    };
                    losProductos.Add(venta);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando productos inventario{ex}");
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
