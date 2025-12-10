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

namespace Actividad_3_CRUD.Formularios
{
    public partial class FormCompras : Form
    {
        public FormCompras()
        {
            InitializeComponent();
        }

        private void textBoxdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            //Conexión local y puntual, no siempre estará abierta.
            using (SqlConnection cn = new SqlConnection("Data Source=BRUNOGERMAN\\SQLEXPRESS;Initial Catalog=CRUDUMI;Integrated Security=True;Encrypt=False"))  //Conexión local a la base de datos, cada que se haga click hara ingreso a esta
            {
                //Aqui creas el comando que insertara la información
                SqlCommand cmd = new SqlCommand("INSERT INTO COMPRAS(dniCliente,codProducto)VALUES('" + textBoxDniCliente.Text + "', '" + textBoxCodProducto.Text + "');", cn); //Concatenas cuadros de texto con el dato a ingresar
                cmd.CommandType = CommandType.Text; //Le dices a visual  que abra el comando donde esta la instrución y le dices a visual que hacer
                cn.Open();//Abre la conexión
                cmd.ExecuteNonQuery();

                MessageBox.Show("compra AGREGADA exitosamente.");
                textBoxDniCliente.Clear();
                textBoxCodProducto.Clear();

            }
        }

        private void dataGridViewCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=BRUNOGERMAN\\SQLEXPRESS;Initial Catalog=CRUDUMI;Integrated Security=True;Encrypt=False"))
            {
                //Aqui creas el comando que insertara la información al dataGridView
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COMPRAS", cn);
                da.SelectCommand.CommandType = CommandType.Text; //Le dices a visual  que abra el comando donde esta la instrución y le dices a visual que hacer
                cn.Open();
                da.Fill(dt); //Lo que esta en da se llenara con dt
                dataGridViewCompras.DataSource = dt;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=BRUNOGERMAN\\SQLEXPRESS;Initial Catalog=CRUDUMI;Integrated Security=True;Encrypt=False"))  //Conexión local a la base de datos, cada que se haga click hara ingreso a esta
            {
                //Aqui creas el comando que insertara la información al dataGridView
                SqlCommand cmd = new SqlCommand("DELETE FROM COMPRAS where codProducto= '" + textBoxCodProducto.Text + "'", cn);
                cmd.CommandType = CommandType.Text; //Le dices a visual  que abra el comando donde esta la instrución y le dices a visual que hacer
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Compra ELIMINADA exitosamente.");
                textBoxDniCliente.Clear();
                textBoxCodProducto.Clear();
            }
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            FormPrincipal Menu = new FormPrincipal();
            Menu.Show();
            this.Hide();
        }

        private void FormCompras_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
