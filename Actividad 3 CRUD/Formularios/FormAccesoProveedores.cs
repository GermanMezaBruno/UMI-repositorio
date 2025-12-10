using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_3_CRUD.Formularios
{
    public partial class FormAccederProveedores : Form
    {
        public FormAccederProveedores()
        {
            InitializeComponent();
        }

        private void buttonAccederClientes_Click(object sender, EventArgs e)
        {
            if (textBoxContraseña.Text == "")
            {
                MessageBox.Show("Debe ingresar contraseña");
                textBoxContraseña.Clear();
            }

            else if (textBoxContraseña.Text == "UMI")
            {

                FormRegistroProveedor AccesoPro = new FormRegistroProveedor();
                AccesoPro.Show();


                this.Hide(); //Sirve para oculpar la ventana que estaba antes de cambiar al otro formulario Close/Hide


            }
            else if (textBoxContraseña.Text != "UMI")
            {
                MessageBox.Show("Contraseña Incorrecta");
                textBoxContraseña.Clear();

            }
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAccederProveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
