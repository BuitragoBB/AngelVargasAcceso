using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Form_principall : Form
    {
        public Form_principall()
        {
            InitializeComponent();
            tabla();
        }

        public void tabla()
        {
            dataGridView1.DataSource = Controlador_producto.CargarDatosProductos();
            dataGridView2.DataSource = Controlador_adicionar.CargarDatosProductos();


        }

      



        private void button2_Click(object sender, EventArgs e)
        {
                Compra_form compra_form = new Compra_form();
                compra_form.ShowDialog();
                tabla();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto_form producto_Form = new Producto_form(this);
            producto_Form.Show();
            tabla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Adicionar_form adicionar_Form = new Adicionar_form();
            adicionar_Form.Show();
            tabla();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_principall_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cliente_Form cliente_Form = new Cliente_Form ();
            cliente_Form.Show();
            tabla();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Empleado_Form empleado_Form = new Empleado_Form();
            empleado_Form.Show();
            tabla();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            provedor_Form proveedor_Form = new provedor_Form();
            proveedor_Form.Show();
            tabla();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EliminarForm eliminarForm = new EliminarForm();
            eliminarForm.Show();
            tabla();
        }
    }
}
