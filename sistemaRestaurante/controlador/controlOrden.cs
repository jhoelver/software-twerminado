using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using sistemaRestaurante.baseDatos;
using sistemaRestaurante.modelo;


namespace sistemaRestaurante.controlador
{
    class controlOrden
    {

        conexion conexion = new conexion();
        public Boolean altaOrden(int monto)
        {

            int insertar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_A_Table_Orden", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@MontoTotal",monto);
            
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



        public Boolean altaDetelleOrden(string nombreProducto)
        {

            int insertar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_A_Table_OrdenProductos", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreProducto", nombreProducto);
         




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



        public Boolean altaOrdenTipoMesaLocal(mesa _mesa,clienteFrecuent _cliente,usuario _Personal)
        {

            int insertar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_A_Table_OrdenMesaLocal", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idMesa ", _mesa.Id);
            comando.Parameters.AddWithValue("@idcliente ", _cliente.Id);
            comando.Parameters.AddWithValue("@idPersonal ", _Personal.Id);

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



        public Boolean altaOrdenParaLlevar(string observacion, clienteFrecuent _cliente, usuario _Personal)
        {

            int insertar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_A_Table_OrdenLLevar", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idcliente ", _cliente.Id);
            comando.Parameters.AddWithValue("@observacion", observacion);
            comando.Parameters.AddWithValue("@idPersonal ", _Personal.Id);

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

        public DataSet SelectAllOrden()
        {
            DataSet ordenDataSet = new DataSet();




            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();



            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_selectOrden";

            try
            {

                SqlDataAdapter myAdapter = new SqlDataAdapter(Comando);
                ordenDataSet = new DataSet();
                myAdapter.Fill(ordenDataSet);

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

            return ordenDataSet;
        }


    }
}
