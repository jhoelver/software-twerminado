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
    public partial class eliminarClienteFrecu : Form
    {
        public eliminarClienteFrecu()
        {
            InitializeComponent();
        }

        private void btneleiminar_Click(object sender, EventArgs e)
        {
            string respuestas = "";

            M_Registrar_Cliente objCF = new M_Registrar_Cliente();
         C_Registrar_Cliente _cf = new C_Registrar_Cliente();
      
            

            
            objCF.Nombe = txtNombre.Text;





            objCF.Respuesta = _cf.eliminarClienteFre(objCF);

            if (objCF.Respuesta == true)
            {
                respuestas = "Eliminacion Completa";
                label2.Text = respuestas;



            }
            else
            {
                respuestas = "Eliminacion Completa";
                label2.Text = respuestas;
            }


            txtNombre.Text = "";
        }
    }
}
