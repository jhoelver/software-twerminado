﻿using System;
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
    public partial class productosEingredientes : Form
    {
        public productosEingredientes()
        {
            InitializeComponent();
        }

        private void productosEingredientes_Load(object sender, EventArgs e)
        {
            llenarGrigIngredientes();
            llenarGridIngredintesSelecionados();
            controlProducto _Pro = new controlProducto();
            cbPRODUCTOS.DataSource = _Pro.seleccionarProductoComb();
            cbPRODUCTOS.DisplayMember = "NombreProducto";
            cbPRODUCTOS.ValueMember = "Id";
        }

        public void llenarGridIngredintesSelecionados()
        {

            dgwProducto.ColumnCount = 3;
            dgwProducto.Columns[0].Name = "ID";
            dgwProducto.Columns[1].Name = "Ingrediente";
            dgwProducto.Columns[2].Name = "Stock";
        
        }

        public void llenarGrigIngredientes()
        {

            C_Registrar_Ingre _ingredientes = new C_Registrar_Ingre();

            dgwIngredientes.DataSource = _ingredientes.SelectAllIngredientes().Tables[0];
            dgwIngredientes.Visible = true;
        }

        private void dgwIngredientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //aqui


            string idIngredinete = Convert.ToString(dgwIngredientes.CurrentRow.Cells[0].Value);
            string ingrediente = Convert.ToString(dgwIngredientes.CurrentRow.Cells[1].Value);
            string stock = Convert.ToString(dgwIngredientes.CurrentRow.Cells[2].Value);


            string[] row = new string[] { idIngredinete, ingrediente, stock};
            dgwProducto.Rows.Add(row);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            controlProducto _produ = new controlProducto();

            productos _pro = new productos();
            M_Registrar_Ingre _ingre = new M_Registrar_Ingre();






            foreach (DataGridViewRow rowss in dgwProducto.Rows)
            {
                string c = Convert.ToString(rowss.Cells[1].Value);

                if (c != "")
                {
                    _pro.Id = int.Parse(cbPRODUCTOS.SelectedValue.ToString());
                    _ingre.Id = Convert.ToInt32(rowss.Cells[0].Value);
                    _produ.altaDetalleProductoIngredientes(_pro, _ingre);
                }

                lblm.Text = "Ingredientes Agregados";
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new V_Registrar_Platillo().Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new eliminarProducto().Show();
        }

        private void detalleProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new detalleProductoIngredientes().Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new V_Registrar_Platillo().Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            new eliminarProducto().Show();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            new detalleProductoIngredientes().Show();
        }

        private void lblProducto_Click(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
