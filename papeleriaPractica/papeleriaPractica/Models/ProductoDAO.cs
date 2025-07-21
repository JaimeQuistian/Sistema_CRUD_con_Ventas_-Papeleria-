using System;
using System.Data.SqlClient;
using System.Data;

namespace papeleriaPractica.Models
{
    // DAO significa Data Access Object, es un patrón de diseño que se utiliza para separar la lógica de acceso a datos de la lógica de negocio.
    public class ProductoDAO
    {
        // Creamos una instancia de la clase DBConnection (DBConnection es la clase que maneja la conexión a la base de datos y db es el nombre de la variable que contiene la conexión).
        private DBConnection db = new DBConnection();

        public DataTable MostrarProductos()
        {
            using (SqlConnection connection = db.GetConection())
            {
                // command es el objeto que ejecuta las consultas a la base de datos.
                SqlCommand command = new SqlCommand("MostrarProductos", connection);
                // CommandType.StoredProcedure indica que la consulta es un procedimiento almacenado.
                command.CommandType = CommandType.StoredProcedure;

                // SqlDataAdapter es el objeto que se encarga de llenar el DataTable con los datos obtenidos de la base de datos.
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                // DataTable es el objeto que almacena los datos obtenidos de la base de datos.
                DataTable dataTable = new DataTable();

                // Abrimos la conexión a la base de datos.
                connection.Open();
                // Llenamos el DataTable con los datos obtenidos de la base de datos.
                adapter.Fill(dataTable);

                // return dataTable devuelve el DataTable con los datos obtenidos de la base de datos y cierra la conexión a la base de datos.
                return dataTable;
            }
        }


        public int AgregarProducto(string nombre, string marca, string detalle, decimal precio, out string mensaje)
        {
            int resultado = -1;
            mensaje = "";

            using (SqlConnection connection = db.GetConection())
            {
                SqlCommand command = new SqlCommand("AgregarProducto", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregamos los parámetros necesarios para el procedimiento almacenado.
                command.Parameters.AddWithValue("@nombreProducto", nombre);
                command.Parameters.AddWithValue("@marcaProducto", marca);
                command.Parameters.AddWithValue("@detalleProducto", detalle);
                command.Parameters.AddWithValue("@precioProducto", precio);

                //Parametro de salida 
                SqlParameter outputMensaje = new SqlParameter("@mensajeDeRespuesta", SqlDbType.VarChar, 100)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputMensaje);

                try
                {
                    // Abrimos la conexión a la base de datos.
                    connection.Open();
                    // ExecuteNonQuery se utiliza para ejecutar comandos que no devuelven filas, como INSERT, UPDATE o DELETE.
                    resultado = command.ExecuteNonQuery();
                    // Obtenemos el mensaje de respuesta del procedimiento almacenado.
                    mensaje = outputMensaje.Value.ToString();
                }
                catch (Exception ex)
                {
                    mensaje = "Error: " + ex.Message;
                }
            }
            // Si el resultado es mayor o igual a 0, significa que se ha agregado el producto correctamente.
            return resultado;
        }

        public DataTable BuscarProducto(string busqueda)
        {
            using (SqlConnection connection = db.GetConection())
            {
                SqlCommand command = new SqlCommand("BuscarProductos", connection);
                command.CommandType = CommandType.StoredProcedure;
                
                command.Parameters.AddWithValue("@busqueda", busqueda);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                
                connection.Open();
                
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
