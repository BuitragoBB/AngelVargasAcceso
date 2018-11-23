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
    public class Controlador_compra
    {
        public static List<Compra> CargarDatosProductos()
        {
            List<Compra> losProductos = new List<Compra>();
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=ANGEL\MSSQLSERVER01;Database=Supermercado;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"SELECT id_compra,id_producto,id_provedor,Cantidad,Valor,Fecha FROM  Compra";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta


                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader 
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int idcompra = reader.GetInt32(0);
                    int idproducto = reader.GetInt32(1);
                    int idprovedor = reader.GetInt32(2);
                    int cantidad = reader.GetInt32(3);
                    int valor = reader.GetInt32(4);
                    DateTime fecha = reader.GetDateTime(5);
                    

                    Compra venta = new Compra
                    {
                        Id_compra = idcompra,
                        Id_producto=idproducto,
                        Id_provedor = idprovedor,
                        Cantidad = cantidad,
                        Valor = valor,
                        Fecha = fecha
                    };
                    losProductos.Add(venta);
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
