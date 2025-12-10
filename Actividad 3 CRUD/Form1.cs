using Actividad_3_CRUD.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_3_CRUD
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void mensajeBienvenidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("En Calzado German, sabemos que el camino se recorre paso a paso. Por eso, hemos dedicado nuestra pasión a seleccionar calzado que no solo es estéticamente impecable, sino también diseñado para ofrecer el máximo confort y resistencia.");
        }

        private void quiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Quiénes Somos?\nCalzado German es sinónimo de tradición y tendencia en el mundo del calzado. Somos una empresa dedicada a la selección y venta de zapatos que priorizan la calidad de los materiales, la meticulosa fabricación y el ajuste perfecto.");
        }

        private void misiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Misión:\nConvertirnos en la marca de calzado líder y de referencia, reconocida por la excelencia en diseño y la comodidad inigualable. Aspiramos a ser la elección principal para quienes valoran la inversión en un calzado que define su paso y eleva su presencia.");
        }

        private void visiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visión:\nEn Calzado German, nuestra misión es ofrecer a nuestros clientes zapatos que combinen artesanía de alta calidad con las últimas tendencias de la moda. Buscamos asegurar el confort y la durabilidad en cada par, permitiendo que nuestros clientes caminen con confianza y estilo en cada paso de su vida.");
        }

        private void damasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDamas damas = new FormDamas();
            damas.Show();
        }

        private void caballerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCaballeros caballeros = new FormCaballeros();
            caballeros.Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
             FormAcceso acceso  = new FormAcceso();
            acceso.Show();
            this.Hide();
         
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccederProveedores accesopro = new FormAccederProveedores();
            accesopro.Show();
            this.Hide();
            
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccesoProducto accesoPro = new FormAccesoProducto();
            accesoPro.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompras compras = new FormCompras();
            compras.Show();
            this.Hide();
        }
    }
}
