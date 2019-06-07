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
    public partial class VerOrden : Form
    {
        public VerOrden()
        {
            InitializeComponent();
        }
        private void ingredientes_Load(object sender, EventArgs e)
        {
            llenarOrden();
        }
        public void llenarOrden()
        {

            controlOrden _ingredientes = new controlOrden();

            dgwIngredientes.DataSource = _ingredientes.SelectAllOrden().Tables[0];
            dgwIngredientes.Visible = true;
        }

        private void VerOrden_Load(object sender, EventArgs e)
        {

        }
    }
}
