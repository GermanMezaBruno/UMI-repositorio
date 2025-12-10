using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //necesaria para la conexión

namespace Actividad_3_CRUD.Formularios
{
    public partial class FormRegistroCliente : Form
    {
        public FormRegistroCliente()
        {
            InitializeComponent();
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            //Conexión local y puntual, no siempre estará abierta.
            using (SqlConnection cn = new SqlConnection("Data Source=BRUNOGERMAN\\SQLEXPRESS;Initial Catalog=CRUDUMI;Integrated Security=True;Encrypt=False"))  //Conexión local a la base de datos, cada que se haga click hara ingreso a esta
            {
                //Aqui creas el comando que insertara la información
                SqlCommand cmd = new SqlCommand("INSERT INTO CLIENTES(dni,nombre,apellidos,fechaNac,telefono,email)VALUES('" + textBoxdni.Text + "', '" + textBoxnombre.Text + "', '" + textBoxapellidos.Text + "', '" + textBoxfechaNac.Text + "', '" + textBoxtelefono.Text + "','" + textBoxemail.Text + "');", cn); //Concatenas cuadros de texto con el dato a ingresar
                cmd.CommandType = CommandType.Text; //Le dices a visual  que abra el comando donde esta la instrución y le dices a visual que hacer
                cn.Open();//Abre la conexión
                cmd.ExecuteNonQuery();

                MessageBox.Show("Contacto AGREGADO exitosamente.");
                textBoxdni.Clear();
                textBoxnombre.Clear();
                textBoxapellidos.Clear();
                textBoxfechaNac.Clear();
                textBoxtelefono.Clear();
                textBoxemail.Clear();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //Conexión local y puntual, no siempre estará abierta.
            using (SqlConnection cn = new SqlConnection("Data Source=BRUNOGERMAN\\SQLEXPRESS;Initial Catalog=CRUDUMI;Integrated Security=True;Encrypt=False"))  //Conexión local a la base de datos, cada que se haga click hara ingreso a esta
            {
                //Aqui creas el comando que insertara la información
                SqlCommand cmd = new SqlCommand("Delete from CLIENTES where dni = '" + textBoxdni.Text + "'", cn); //Concatenas cuadros de texto con el dato a ingresar
                cmd.CommandType = CommandType.Text; //Le dices a visual  que abra el comando donde esta la instrución y le dices a visual que hacer
                cn.Open();//Abre la conexión
                cmd.ExecuteNonQuery();


                MessageBox.Show("Contacto BORRADO exitosamente.");
                textBoxdni.Clear();
                textBoxnombre.Clear();
                textBoxapellidos.Clear();
                textBoxfechaNac.Clear();
                textBoxtelefono.Clear();
                textBoxemail.Clear();

            }
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=BRUNOGERMAN\\SQLEXPRESS;Initial Catalog=CRUDUMI;Integrated Security=True;Encrypt=False"))  //Conexión local a la base de datos, cada que se haga click hara ingreso a esta
            {
                //Aqui creas el comando que insertara la información al dataGridView
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CLIENTES", cn);
                da.SelectCommand.CommandType = CommandType.Text; //Le dices a visual  que abra el comando donde esta la instrución y le dices a visual que hacer
                cn.Open();
                da.Fill(dt);  //Lo que esta en da se llenara con dt

                dataGridViewClientes.DataSource = dt;
            }
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            FormPrincipal Menu = new FormPrincipal();
            Menu.Show();
            this.Hide();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

            using (SqlConnection cn = new SqlConnection("Data Source=BRUNOGERMAN\\SQLEXPRESS;Initial Catalog=CRUDUMI;Integrated Security=True;Encrypt=False"))  //Conexión local a la base de datos, cada que se haga click hara ingreso a esta
            {
                //Aqui creas el comando que insertara la información al dataGridView
                SqlCommand cmd = new SqlCommand("Update CLIENTES set nombre= '" + textBoxnombre.Text + "',apellidos= '" + textBoxapellidos.Text + "',fechaNac= '" + textBoxfechaNac.Text + "',telefono= '" + textBoxtelefono.Text + "',email='" + textBoxemail.Text + "' where dni= '" + textBoxdni.Text + "'", cn);
                cmd.CommandType = CommandType.Text; //Le dices a visual  que abra el comando donde esta la instrución y le dices a visual que hacer
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Contacto MODIFICADO exitosamente.");
                textBoxdni.Clear();
                textBoxapellidos.Clear();
                textBoxemail.Clear();
                textBoxfechaNac.Clear();
                textBoxnombre.Clear();
                textBoxtelefono.Clear();
            }
            }

        private void FormRegistroCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    }
    


