using System;
using System.Data;
using System.Windows.Forms;
using papeleriaPractica.Controllers;

namespace papeleriaPractica
{
    public partial class frmRegistrarVenta : Form
    {
        // Instancia del controlador de productos
        ProductoControllers productoControllers = new ProductoControllers();
        VentaControllers ventaControllers = new VentaControllers();

        // Variables para manejar el carrito de compras y el total de la venta
        private DataTable carrito = new DataTable();
        private decimal totalVenta = 0;

        public frmRegistrarVenta() // Constructor
        {
            InitializeComponent();
            ConfigurarCarrito();

            SetPlaceHolder();
        }

        // Funciones
        private void ConfigurarCarrito()
        {
            carrito.Columns.Add("ID", typeof(int));
            carrito.Columns.Add("Nombre", typeof(string));
            carrito.Columns.Add("Marca", typeof(string));
            carrito.Columns.Add("Cantidad", typeof(int));
            carrito.Columns.Add("Precio Unitario", typeof(decimal));
            carrito.Columns.Add("Subtotal", typeof(decimal));

            dgvCarrito.DataSource = carrito;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCarrito.Columns["ID"].Visible = false; // Ocultar la columna ID en el carrito
        }

        private void SetPlaceHolder() // Crear un placeholder para el textBox
        {
            if(string.IsNullOrEmpty(txtBusqueda.Text))
            {
                txtBusqueda.Text = "Buscar producto";
                txtBusqueda.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void RemovePlaceHolder() // Eliminar el placeholder cuando se hace clic en el textBox
        {
            if (txtBusqueda.Text == "Buscar producto")
            {
                txtBusqueda.Text = string.Empty;
                txtBusqueda.ForeColor = System.Drawing.Color.Black;
            }
        }

        //Eventos
        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila de producto (Primer casilla izquierda)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudCantidad.Value = 0;
                return;
            }

            DataGridViewRow filaSeleccionada = dgvProductos.SelectedRows[0];
            int idProducto = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value);
            string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
            string marca = filaSeleccionada.Cells["Marca"].Value.ToString();
            decimal precioUnitario = Convert.ToDecimal(filaSeleccionada.Cells["Precio"].Value.ToString().Replace("$", "").Trim());
            int cantidad = (int)nudCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal subtotal = precioUnitario * cantidad;
            carrito.Rows.Add(idProducto, nombre, marca, cantidad, precioUnitario, subtotal);

            totalVenta += subtotal;
            lblTotal.Text = $"${totalVenta.ToString("F2")}";
            nudCantidad.Value = 0;
            txtBusqueda.Text = string.Empty;
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (carrito.Rows.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensajeVenta;
            int idVenta = ventaControllers.RegistrarVenta(out mensajeVenta);

            if (idVenta > 0)
            {
                foreach (DataRow fila in carrito.Rows)
                {
                    int idPrducto = (int)fila["ID"];
                    int cantidad = (int)fila["Cantidad"];
                    decimal precioUnitario = (decimal)fila["Precio Unitario"];

                    string mensajeDetalle;
                    ventaControllers.AgregarDetalleVenta(idVenta, idPrducto, cantidad, precioUnitario, out mensajeDetalle);
                }

                MessageBox.Show($"Venta registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                carrito.Clear();
                totalVenta = 0;
                lblTotal.Text = "$0.00";
            }
            else
            {
                MessageBox.Show($"Error al registrar la venta: {mensajeVenta}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void brnCancelarVenta_Click(object sender, EventArgs e)
        {
            carrito.Clear();
            totalVenta = 0;
            lblTotal.Text = "$0.00";
            nudCantidad.Value = 0;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBusqueda.Text.Trim();

            DataTable productosFiltrados = productoControllers.BuscarProducto(textoBusqueda);

            dgvProductos.DataSource = productosFiltrados;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvProductos.Columns.Contains("ID"))
            {
                dgvProductos.Columns["ID"].Visible = false;
            }

        }

        private void txtBusqueda_Enter(object sender, EventArgs e)
        {
            SetPlaceHolder();
            txtBusqueda.Text = "";
        }

        private void txtBusqueda_Leave(object sender, EventArgs e)
        {
            RemovePlaceHolder();
        }
    }
}
