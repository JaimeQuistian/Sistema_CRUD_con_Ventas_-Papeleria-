using System;
using System.Data.SqlClient;
using DotNetEnv;

namespace papeleriaPractica.Models
{
    public class DBConnection
    {
        private readonly string connectionString;

        public DBConnection()
        {
            Env.Load(); // Cargar las variables de entorno desde el archivo .env

            connectionString = Env.GetString("DB_CONNECTION_STRING"); // Leer la cadena de conexión desde las variables de entorno

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("La cadena de conexión no está configurada en las variables de entorno.");
            }
        }
        public SqlConnection GetConection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
