using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sistemaRestaurante.baseDatos;
using sistemaRestaurante.modelo;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace sistemaRestaurante.controlador
{
    class C_Registrar_Cliente
    {
        conexion conexion = new conexion();
        public Boolean altaClienteFrecuente(M_Registrar_Cliente _clientFrecu)
        {

            int insertar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("SP_A_TABLA_tblCliente", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", _clientFrecu.Nombe);
            comando.Parameters.AddWithValue("@apellido", _clientFrecu.Apellido);
            comando.Parameters.AddWithValue("@telefono", _clientFrecu.Telefono);
            comando.Parameters.AddWithValue("@email", _clientFrecu.Email);
            comando.Parameters.AddWithValue("@idCatCliente", _clientFrecu.IdtCliente);

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


        public Boolean eliminarClienteFre(M_Registrar_Cliente _cF)
        {

            int elininar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("SP_E_TABLA_tblCliente", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombrecliente", _cF.Nombe);


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



        public AutoCompleteStringCollection autocompleteCliente()
        {


            {

                SqlCommand cmd = new SqlCommand("SELECT Nombre FROM clienteFrecuente where status=1", conexion.openDataBase());

                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();

                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                    Console.WriteLine(reader.GetString(0));
                }
                //  txt1.AutoCompleteCustomSource = MyCollection;
                conexion.closeDatabase();
                return MyCollection;
            }
        }



        public List<M_Registrar_Cliente> seleccionarCliente()
        {
            List<M_Registrar_Cliente> listClienteFrecente = new List<M_Registrar_Cliente>();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();

            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "SP_C_TABLA_tblCliente";
            M_Registrar_Cliente _clifcnt = new M_Registrar_Cliente();
          _clifcnt.Nombe = "Cliente";

          listClienteFrecente.Add(_clifcnt);

            try
            {
                IDataReader lector = Comando.ExecuteReader();
                while (lector.Read())
                {
                    M_Registrar_Cliente _clienteFr = new M_Registrar_Cliente();
                    _clienteFr.Id = int.Parse(lector[0].ToString());
                    _clienteFr.Nombe = lector[1].ToString();
                    listClienteFrecente.Add(_clienteFr);
                }
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

            return listClienteFrecente;
        }


    }
}
