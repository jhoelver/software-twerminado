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
    public partial class btnEliminarClientes : Form
    {
        public btnEliminarClientes()
        {
            InitializeComponent();
        }

        private void clienteFrecuente_Load(object sender, EventArgs e)
        { 
            controllercatCliente _Cliente = new controllercatCliente();
            cbCategoria.DataSource = _Cliente.seleccionarCatCliente();
            cbCategoria.DisplayMember = "CatUser";
            cbCategoria.ValueMember = "Id";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          

            direccion _us = new direccion();
            controlDireccion cDirec = new controlDireccion();
            _us.Numero = txtNumer.Text;
            _us.Calle = txtCalle.Text;
            _us.Colonia= txtColonia.Text;
            cDirec.altaDireccion(_us);
            C_Registrar_Cliente _cf = new C_Registrar_Cliente();
            M_Registrar_Cliente _mcf = new M_Registrar_Cliente();
            _mcf.Nombe= txtNombre.Text;
            _mcf.Apellido = txtApellido.Text;
            _mcf.Telefono = txtTelefono.Text;
            _mcf.Email = txtEmail.Text;
            _mcf.IdtCliente = int.Parse(cbCategoria.SelectedValue.ToString());
            _cf.altaClienteFrecuente(_mcf);
            

           


          
        
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
           
        }

        private void Cerrar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new eliminarClienteFrecu().Show();
        }

        private void btnCarteraDeClientes_Click(object sender, EventArgs e)
        {
            new MostrarCliente().Show();
        }
    }
}
