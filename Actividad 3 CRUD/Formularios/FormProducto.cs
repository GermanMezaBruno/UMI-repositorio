using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Actividad_3_CRUD.Formularios
{
    public partial class FormRegistroProducto : Form
    {
        public FormRegistroProducto()
        {
            InitializeComponent();
        }

        private void dataGridViewRegistroProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=BRUNOGERMAN\\SQLEXPRESS;Initial Catalog=CRUDUMI;Integrated Security=True;Encrypt=False"))
            {
                //Aqui creas el comando que insertara la información al dataGridView
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PRODUCTOS", cn);
                da.SelectCommand.CommandType = CommandType.Text; //Le dices a visual  que abra el comando donde esta la instrución y le dices a visual que hacer
                cn.Open();
                da.Fill(dt); //Lo que esta en da se llenara con dt
                dataGridViewRegistroProductos.DataSource = dt;
            }
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
            this.Hide();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            //Conexión local y puntual, no siempre estará abierta.
            using (SqlConnection cn = new SqlConnection("Data Source=BRUNOGERMAN\\SQLEXPRESS;Initial Catalog=CRUDUMI;Integrated Security=True;Encrypt=False"))  //Conexión local a la base de datos, cada que se haga click hara ingreso a esta
            {
                //Aqui creas el comando que insertara la información
                SqlCommand cmd = new SqlCommand("INSERT INTO PRODUCTOS(codigo,nombre,precio,nifProveedor)VALUES('" + textBoxcodigo.Text + "', '" + textBoxnombreP.Text + "','"+textBoxprecio.Text+"','" + textBoxnifProveedor.Text + "');", cn); //Concatenas cuadros de texto con el dato a ingresar
                cmd.CommandType = CommandType.Text; //Le dices a visual  que abra el comando donde esta la instrución y le dices a visual que hacer
                cn.Open();//Abre la conexión
                cmd.ExecuteNonQuery();

                MessageBox.Show("Contacto AGREGADO exitosamente.");
                textBoxcodigo.Clear();
                textBoxnombreP.Clear();
                textBoxnifProveedor.Clear();
                textBoxprecio.Clear();

            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=BRUNOGERMAN\\SQLEXPRESS;Initial Catalog=CRUDUMI;Integrated Security=True;Encrypt=False"))  //Conexión local a la base de datos, cada que se haga click hara ingreso a esta
            {
                //Aqui creas el comando que insertara la información al dataGridView
                SqlCommand cmd = new SqlCommand("DELETE FROM PRODUCTOS where codigo= '" + textBoxcodigo.Text+"'", cn);
                cmd.CommandType = CommandType.Text; //Le dices a visual  que abra el comando donde esta la instrución y le dices a visual que hacer
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Contacto ELIMINADO exitosamente.");
                textBoxcodigo.Clear();
                textBoxnombreP.Clear();
                textBoxprecio.Clear();
                textBoxnifProveedor.Clear();

            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=BRUNOGERMAN\\SQLEXPRESS;Initial Catalog=CRUDUMI;Integrated Security=True;Encrypt=False"))  //Conexión local a la base de datos, cada que se haga click hara ingreso a esta
            {
                //Aqui creas el comando que insertara la información al dataGridView
                SqlCommand cmd = new SqlCommand("Update PRODUCTOS set nombre= '" + textBoxnombreP.Text + "',precio= '" + textBoxprecio.Text + "',nifProveedor= '"+textBoxnifProveedor.Text+"' where codigo= '" + textBoxcodigo.Text + "'", cn);
                cmd.CommandType = CommandType.Text; //Le dices a visual  que abra el comando donde esta la instrución y le dices a visual que hacer
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Contacto MODIFICADO exitosamente.");
                textBoxcodigo.Clear();
                textBoxnifProveedor.Clear();
                textBoxnombreP.Clear();
                textBoxprecio.Clear();
            }
        }

        private void FormRegistroProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
