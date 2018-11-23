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
    public partial class EliminarForm : Form
    {
        public EliminarForm()
        {
            InitializeComponent();
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
                string sql = @" 
                                 DELETE  FROM Venta WHERE id_venta = @eliminar


                                       ";
                            
                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta

                comando.Parameters.AddWithValue("@eliminar", Convert.ToInt32(eliminar_txt.Text));
               


                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader
                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("La Venta se Elimino");
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
    }
}
