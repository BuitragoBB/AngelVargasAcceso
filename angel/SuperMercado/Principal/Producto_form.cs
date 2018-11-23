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
    public partial class Producto_form : Form
    {
        public Form_principall padre { get; set; }
        public Producto_form(Form_principall fg)
        {
            padre = fg;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ExisteRegistro(Convert.ToInt32(codigop_txt.Text)))
            {
                MessageBox.Show("Ya existe este Id registrado");
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
                string sql = @"INSERT INTO Producto (id_producto,Nombreproducto,cantidad,valor)
                                VALUES(@id_producto,@NombreProducto,0,@valor)";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta
               comando.Parameters.AddWithValue("@id_producto", Convert.ToInt32(codigop_txt.Text));
                comando.Parameters.AddWithValue("@Nombreproducto", nombre_txt.Text);
            //    comando.Parameters.AddWithValue("@cantidad", Convert.ToInt32 (cantidad_txt.Text));
                comando.Parameters.AddWithValue("@valor", Convert.ToInt32(valor_txt.Text));

                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader
                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("El registro se insertó");
                    this.padre.tabla();
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

        public bool ExisteRegistro(int productoId)
        {
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=ANGEL\MSSQLSERVER01;Database=Supermercado;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"SELECT id_producto FROM Producto WHERE id_producto=@id_producto";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta
                comando.Parameters.AddWithValue("@id_producto", productoId);

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




        private void Producto_form_Load(object sender, EventArgs e)
        {

        }
    }
}
