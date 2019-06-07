using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using sistemaRestaurante.baseDatos;
using sistemaRestaurante.modelo;
using System.Windows.Forms;

namespace sistemaRestaurante.controlador
{
    class controlIngredientes
    {
        conexion conexion = new conexion();
        public DataSet SelectAllIngredientes()
        {
            DataSet productDataSet = new DataSet();




            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();



            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_C_Table_AllIngrediente";
           
            try
            {

                SqlDataAdapter myAdapter = new SqlDataAdapter(Comando);
                productDataSet = new DataSet();
                myAdapter.Fill(productDataSet);

            }
            catch (Exception ex)
            {
                string m = ex.Message;
                Comando.Dispose();
            }

            finally
            {
                conexion.closeDatabase();
            }

            return productDataSet;
        }



      
        public Boolean altaIngrediente(ingredientes _ingrediente)
        {

            int insertar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_A_Table_Ingrediente", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", _ingrediente.Ingrediente);
            comando.Parameters.AddWithValue("@stock", _ingrediente.Stock);
   
            try
            {
                insertar = comando.ExecuteNonQuery();
                if (insertar < 0)
                {
                    respuesta = true;
                }
                conexion.closeDatabase();
            }
            catch (Exception)
            {
                conexion.closeDatabase();
                throw;

            }

            return respuesta;



        }



        public Boolean eliminarIngrediente(ingredientes _ingrediente)
        {

            int elininar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_E_Table_Ingrediente", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", _ingrediente.Ingrediente);


            try
            {
                elininar = comando.ExecuteNonQuery();
                if (elininar < 0)
                {
                    respuesta = true;
                }
                conexion.closeDatabase();
            }
            catch (Exception)
            {
                conexion.closeDatabase();
                throw;

            }

            return respuesta;



        }

        public Boolean actualizarIngrediente(ingredientes _ingrediente)
        {

            int actualizar = 0;
            bool respuesta = true;
          
     
            SqlCommand comando = new SqlCommand("sp_M_table_Ingrediente", conexion.openDataBase());
            comando.Parameters.AddWithValue("@nombre", _ingrediente.Ingrediente);
            comando.Parameters.AddWithValue("@stock", _ingrediente.Ingrediente);
            string cadena = "update dbo.Ingredientes set  (@nombreIngrediente,@stockIngrediente)";
            MessageBox.Show("ingrediente Actualzado");

            try
            {
                actualizar = comando.ExecuteNonQuery();
                if (actualizar < 0)
                {
                    respuesta = true;
                }
                conexion.closeDatabase();
            }
            catch (Exception)
            {
                conexion.closeDatabase();
                throw;

            }

            
              finally
            {
                conexion.closeDatabase();
            }
            return respuesta;

        }




        public DataSet SelectIngredintesDeProducto(ingredientes _ingrediente)
        {
            DataSet productDataSet = new DataSet();




            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();



            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_A_Table_DetalleIngredienteProducto";
            Comando.Parameters.AddWithValue("@idProducto", _ingrediente.Id);
            try
            {

                SqlDataAdapter myAdapter = new SqlDataAdapter(Comando);
                productDataSet = new DataSet();
                myAdapter.Fill(productDataSet);

            }
            catch (Exception ex)
            {
                string m = ex.Message;
                Comando.Dispose();
            }

            finally
            {
                conexion.closeDatabase();
            }

            return productDataSet;
        }




    }
}
