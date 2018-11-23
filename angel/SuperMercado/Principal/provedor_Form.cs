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
    public partial class provedor_Form : Form
    {
        public provedor_Form()
        {
            InitializeComponent();
            provedor();
        }

        public void provedor()
        {
            dataGridView1.DataSource = Controlador_provedor.CargarDatosProvedor();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (ExisteRegistro(nombre_txt.Text))
            {
                MessageBox.Show("Ya existe un proveedor con este nombre");
                return;
            }


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
                string sql = @"INSERT INTO Provedor (id_provedor,nombre,telefono,cedula)
                                VALUES(@id_provedor,@nombre,@telefono,@cedula)";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta

                comando.Parameters.AddWithValue("@id_provedor", interno_txt.Text);
                comando.Parameters.AddWithValue("@nombre", nombre_txt.Text);
                comando.Parameters.AddWithValue("@telefono", codigo_txt.Text);
                comando.Parameters.AddWithValue("@cedula", cedula_txt.Text);


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



        public bool ExisteRegistro(string provedorId)
        {
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=ANGEL\MSSQLSERVER01;Database=Supermercado;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"SELECT nombre FROM Provedor WHERE  nombre=@nombre";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta
                comando.Parameters.AddWithValue("@nombre", provedorId);


                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader
                object data = comando.ExecuteScalar();

                return data != null;
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

            return false;
        }

        private void provedor_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
