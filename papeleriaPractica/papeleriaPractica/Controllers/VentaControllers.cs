using papeleriaPractica.Models;

namespace papeleriaPractica.Controllers
{
    public class VentaControllers
    {
        private VentaDAO ventaDAO = new VentaDAO();

        public int RegistrarVenta(out string mensaje)
        {
            return ventaDAO.RegistrarVenta(out mensaje);
        }

        public void AgregarDetalleVenta(int idVenta, int idProducto, int cantidad, decimal precioUnitario, out string mensaje)
        {
            ventaDAO.AgregarDetalleVenta(idVenta, idProducto, cantidad, precioUnitario, out mensaje);
        }
    }
}
