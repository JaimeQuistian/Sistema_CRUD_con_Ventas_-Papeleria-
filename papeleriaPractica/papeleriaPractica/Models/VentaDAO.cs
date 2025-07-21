using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace papeleriaPractica.Models
{
    public class VentaDAO
    {
        private DBConnection dbConnection = new DBConnection();

        public int RegistrarVenta(out string mensaje) // Método para registrar una venta y obtener un mensaje de respuesta
        {
            int idVenta = 0;
            mensaje = "";

            try
            {
                using (SqlConnection connection = dbConnection.GetConection())
                {
                    SqlCommand command = new SqlCommand("RegistrarVenta", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter outputId = new SqlParameter("@IdVenta", SqlDbType.Int) // Parámetro de salida para el ID de la venta
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputId);

                    SqlParameter outputMensaje = new SqlParameter("@mensajeDeRespuesta", SqlDbType.NVarChar, 100) // Parámetro de salida para el mensaje de respuesta
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputMensaje);

                    connection.Open();
                    command.ExecuteNonQuery();

                    idVenta = (int)outputId.Value; // Obtener el ID de la venta generado por la base de datos
                    mensaje = outputMensaje.Value.ToString(); // Obtener el mensaje de respuesta
                }
                return idVenta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public void AgregarDetalleVenta(int idVenta, int idProducto, int cantidad, decimal precioUnitario, out string mensaje)
        {
            mensaje = "";

            try
            {
                using (SqlConnection connection = dbConnection.GetConection())
                {
                    SqlCommand command = new SqlCommand("AgregarDetalleVenta", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idVenta", idVenta);
                    command.Parameters.AddWithValue("@idProducto", idProducto);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@precioUnitario", precioUnitario);

                    SqlParameter outputMensaje = new SqlParameter("@mensajeDeRespuesta", SqlDbType.NVarChar, 100)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputMensaje);

                    connection.Open();
                    command.ExecuteNonQuery();

                    mensaje = outputMensaje.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al detallar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
