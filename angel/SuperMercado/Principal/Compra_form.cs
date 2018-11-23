using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Compra_form : Form
    {
        public Compra_form()
        {
            InitializeComponent();
        }

        private void Compra_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //ADO.NET
            //Activex Data Object

            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=ANGEL\MSSQLSERVER01;Database=Supermercado;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"INSERT INTO Compra (id_producto,id_provedor,Cantidad,Valor,Fecha)
                                VALUES(@id_producto,@id_provedor,@Cantidad,0,@Fecha)
                               UPDATE Producto SET cantidad=(SELECT cantidad FROM Producto WHERE id_producto=@id_producto)+@Cantidad WHERE id_producto=@id_producto
                               UPDATE Compra SET Valor=(SELECT valor FROM Producto WHERE id_producto=@id_producto)*@Cantidad WHERE id_producto=@id_producto";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta
             
                comando.Parameters.AddWithValue("@id_producto", Convert.ToInt32( producto_txt.Text));
                comando.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(cantidad2_txt.Text));
                comando.Parameters.AddWithValue("@id_provedor", Convert.ToInt32(provedor_txt.Text));
                comando.Parameters.AddWithValue("@Fecha", fecha.Value);


                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader
                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("El registro se insertó");
                }
                else
                {
                    MessageBox.Show("Encontramos un error :(");
                }
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

        }

        private void cantidad_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
