using System;
using System.Windows.Forms;
using papeleriaPractica.Controllers;
using static System.Net.Mime.MediaTypeNames;

namespace papeleriaPractica
{
    public partial class frmRegistrarProducto : Form
    {
        //Instancia del controlador de productos
        private ProductoControllers productoControllers = new ProductoControllers();

        public frmRegistrarProducto()
        {
            InitializeComponent();
            CargarProductos();
        }

        // Funciones
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtMarca.Clear();
            txtDetalle.Clear();
            nudPrecioProducto.Value = 0;
        }

        private void CargarProductos()
        { 
            dgvInventario.DataSource = productoControllers.ObtenerProductos();
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvInventario.Columns["ID"].Visible = false;
        }

        private string ToSentenceCase(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return string.Empty;

            texto = texto.ToLower(); // Poner todo en minúsculas
            return char.ToUpper(texto[0]) + texto.Substring(1); // Poner la primera letra en mayúscula
        }

        // Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Guardar los valores de los campos de texto y el valor del NumericUpDown en variables locales.
            string nombre = txtNombre.Text.Trim(); 
            string marca = txtMarca.Text.Trim();
            string detalle = txtDetalle.Text.Trim();
            decimal precio;

            nombre = ToSentenceCase(nombre);
            marca = ToSentenceCase(marca);
            detalle = ToSentenceCase(detalle);

            // Validar que los campos no estén vacíos y que el precio sea un valor válido.
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(marca) || string.IsNullOrEmpty(detalle))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validar que el precio sea un número positivo.
            if (!decimal.TryParse(nudPrecioProducto.Text.Trim(), out precio) || precio <= 0)
            {
                MessageBox.Show("Por favor, ingrese un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llamar al método AgregarProducto del controlador de productos para agregar el producto a la base de datos.
            string mensaje = productoControllers.AgregarProducto(nombre, marca, detalle, precio);
            // Mostrar un mensaje de éxito o error según el resultado de la operación.
            MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Si el mensaje contiene "exitosamente", limpiar los campos del formulario.
            if (mensaje.Contains("Producto agregado exitosamente"))
            {
                LimpiarCampos();
                CargarProductos();
            }
        }
    }
}
