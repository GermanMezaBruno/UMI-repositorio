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
    public partial class FormAccesoProducto : Form
    {
        public FormAccesoProducto()
        {
            InitializeComponent();
        }

        private void buttonAccederProductos_Click(object sender, EventArgs e)
        {
            if (textBoxContraseña.Text == "")
            {
                MessageBox.Show("Debe ingresar contraseña");
                textBoxContraseña.Clear();
            }

            else if (textBoxContraseña.Text == "UMI")
            {

                FormRegistroProducto AccesPro = new FormRegistroProducto();
                AccesPro.Show();


                this.Hide(); //Sirve para oculpar la ventana que estaba antes de cambiar al otro formulario Close/Hide


            }
            else if (textBoxContraseña.Text != "UMI")
            {
                MessageBox.Show("Contraseña Incorrecta");
                textBoxContraseña.Clear();

            }
        }

        private void FormAccesoProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
