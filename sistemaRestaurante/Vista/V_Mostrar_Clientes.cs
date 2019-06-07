using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sistemaRestaurante.modelo;
using sistemaRestaurante.controlador;

namespace sistemaRestaurante.vistas
{
    public partial class MostrarCliente : Form
    {
       

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }


        public void llenarGrigClientes()
        {

            C_Registrar_Cliente _cli = new C_Registrar_Cliente();

            dgwclientes.DataSource = _cli.seleccionarCliente();
            dgwclientes.Visible = true;

    
        }



        private void dgwclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MostrarCliente_Load(object sender, EventArgs e)
        {
            llenarGrigClientes();
        }
    }
}
