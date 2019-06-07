using sistemaRestaurante.modelo;
using sistemaRestaurante.controlador;
using sistemaRestaurante.vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sistemaRestaurante
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            new mesas().Show();
          
        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            new Orden().Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            new btnEliminarClientes().Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            new productosEingredientes().Show();
        }

    

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            new vistas.V_Registrar_Ingre().Show();
        }

        private void btnGestionMesa_Click(object sender, EventArgs e)
        {
            new mesas().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            new altaUsuario().Show();
        }
    }
}
