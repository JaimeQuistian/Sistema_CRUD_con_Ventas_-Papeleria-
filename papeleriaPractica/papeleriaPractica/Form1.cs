using System;

using System.Windows.Forms;
using papeleriaPractica.Controllers;

namespace papeleriaPractica
{
    public partial class frmMain : Form
    {
        //Instanciar los formularios que se van a abrir
        frmRegistrarProducto abrirFrmRegistrarProducto;
        frmRegistrarVenta abrirFrmRegistrarVenta;

        // Instanciar el controlador de productos
        private ProductoControllers productoControllers = new ProductoControllers();

        public frmMain()
        {
            InitializeComponent();
        }

        // Funciones
        private void CargarProductos()
        {
            // Cargar los productos en el DataGridView con produtoControllers que es el controlador de productos y obtenerProductos que es el método que obtiene los productos de la base de datos.
            dgvInventarioDeProductos.DataSource = productoControllers.ObtenerProductos();
            // Configurar el DataGridView para que se ajuste al tamaño de las columnas automáticamente.
            dgvInventarioDeProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvInventarioDeProductos.Columns["ID"].Visible = false;
        }

        // Eventos
        private void frmMain_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            //Abrir el formulario frmRegistrarProducto
            abrirFrmRegistrarProducto = new frmRegistrarProducto();
            this.Hide();
            DialogResult result = abrirFrmRegistrarProducto.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                abrirFrmRegistrarProducto.Close();
                CargarProductos();
                this.Show();
            }
            //Se usa dialogresult para saber si se cerró el formulario con el botón Aceptar o Cancelar y evitar abrir multiples instancias del formulario que consume recursos innecesariamente.
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            //Abrir el formulario frmRealizarVenta
            abrirFrmRegistrarVenta = new frmRegistrarVenta();
            this.Hide();
            DialogResult result = abrirFrmRegistrarVenta.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                abrirFrmRegistrarVenta.Close();
                this.Show();
            }
        }
    }
}
