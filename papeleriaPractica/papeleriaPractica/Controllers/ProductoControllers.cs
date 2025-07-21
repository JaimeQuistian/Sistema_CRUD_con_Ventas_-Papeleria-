using System.Data;
using papeleriaPractica.Models;

namespace papeleriaPractica.Controllers
{
    // Controllers son clases que se encargan de manejar la lógica de negocio de la aplicación.
    public class ProductoControllers
    {
        // Creamos una instancia de la clase ProductoDAO, que es la clase que maneja el acceso a los datos de los productos.
        private ProductoDAO productoDAO = new ProductoDAO();

        // Método que obtiene los productos de la base de datos y los devuelve en un DataTable.
        public DataTable ObtenerProductos()
        {
            // Llamamos al método MostrarProductos de la clase ProductoDAO, que es el encargado de obtener los productos de la base de datos.
            return productoDAO.MostrarProductos();
        }


        // Método que agrega un producto a la base de datos.
        public string AgregarProducto(string nombre, string marca, string detalle, decimal precio)
        {
            // Declaramos una variable para almacenar el mensaje de respuesta del método AgregarProducto de la clase ProductoDAO.
            string mensaje;
            // Llamamos al método AgregarProducto de la clase ProductoDAO, que es el encargado de agregar un producto a la base de datos.
            productoDAO.AgregarProducto(nombre, marca, detalle, precio, out mensaje);
            // Retornamos el mensaje de respuesta.
            return mensaje;
        }

        public DataTable BuscarProducto(string busqueda)
        {
            return productoDAO.BuscarProducto(busqueda);
        }
    }
}
