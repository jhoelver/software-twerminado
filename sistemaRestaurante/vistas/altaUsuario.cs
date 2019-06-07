using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sistemaRestaurante.controlador;
using sistemaRestaurante.modelo;

namespace sistemaRestaurante.vistas
{
    public partial class altaUsuario : Form
    {
        public altaUsuario()
        {
            InitializeComponent();
        }

        private void altaUsuario_Load(object sender, EventArgs e)
        {
            // roles _rol = new roles(); 
            controlRol _Crol = new controlRol();
            cbRol.DataSource = _Crol.seleccionarCatProducto();
            cbRol.DisplayMember = "Roluser";
            cbRol.ValueMember = "Id";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string respuestas = "";
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtPasss.Text == "")
            {
                respuestas = "Error al insertar";
                label4.Text = respuestas;
                MessageBox.Show("No hay datos");
            }
            else
            {

                usuario _us = new usuario();
                controlUsuario cUser = new controlUsuario();
                _us.Nombe = txtNombre.Text;
                _us.Apellido = txtApellido.Text;
                _us.Idrol = int.Parse(cbRol.SelectedValue.ToString());
                _us.Pass = txtPasss.Text;



                _us.Respuesta = cUser.altaUsuario(_us);

                if (_us.Respuesta == true)
                {
                    respuestas = "Agregado Exitoso";
                    label4.Text = respuestas;
                    MessageBox.Show("Agregado Exitoso");


                }
                else
                {
                    respuestas = "Error al insertar";
                    label4.Text = respuestas;
                    MessageBox.Show("Error al insertar");
                }

            }
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtPasss.Text = "";

        }
    }
}
