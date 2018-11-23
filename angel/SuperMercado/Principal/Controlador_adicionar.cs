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
    public class Controlador_adicionar
    {

        public static List<Adicionar> CargarDatosProductos()
        {
            List<Adicionar> losProductos = new List<Adicionar>();
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=ANGEL\MSSQLSERVER01;Database=Supermercado;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"SELECT id_venta,id_producto,id_cliente,id_empleado,Cantidad,Valor,Fecha FROM  Venta";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta


                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader 
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int idventa = reader.GetInt32(0);
                    int idproducto = reader.GetInt32(1);
                    int idcliente = reader.GetInt32(2);
                    int idempleado = reader.GetInt32(3);
                    int cantidad = reader.GetInt32(4);
                    int valor = reader.GetInt32(5);
                    DateTime fecha = reader.GetDateTime(6);

                    Adicionar venta = new Adicionar
                    {
                        Id_venta = idventa,
                        Id_cliente = idcliente,
                        Id_producto = idproducto,
                        Cantidad = cantidad,
                        Valor = valor,
                        Id_empleado = idempleado,
                        Fecha = fecha

                    };
                    losProductos.Add(venta);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error cargando ventas {ex}");
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
