namespace papeleriaPractica
{
    partial class frmRegistrarVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbContenedor = new System.Windows.Forms.GroupBox();
            this.gbCarrito = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.brnCancelarVenta = new System.Windows.Forms.Button();
            this.lblInformacionPrecio = new System.Windows.Forms.Label();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregarCarrito = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.gbContenedor.SuspendLayout();
            this.gbCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // gbContenedor
            // 
            this.gbContenedor.Controls.Add(this.gbCarrito);
            this.gbContenedor.Controls.Add(this.gbProductos);
            this.gbContenedor.Location = new System.Drawing.Point(13, 14);
            this.gbContenedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbContenedor.Name = "gbContenedor";
            this.gbContenedor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbContenedor.Size = new System.Drawing.Size(640, 604);
            this.gbContenedor.TabIndex = 1;
            this.gbContenedor.TabStop = false;
            this.gbContenedor.Text = "Realizar venta";
            // 
            // gbCarrito
            // 
            this.gbCarrito.Controls.Add(this.lblTotal);
            this.gbCarrito.Controls.Add(this.brnCancelarVenta);
            this.gbCarrito.Controls.Add(this.lblInformacionPrecio);
            this.gbCarrito.Controls.Add(this.btnConfirmarVenta);
            this.gbCarrito.Controls.Add(this.dgvCarrito);
            this.gbCarrito.Location = new System.Drawing.Point(15, 346);
            this.gbCarrito.Name = "gbCarrito";
            this.gbCarrito.Size = new System.Drawing.Size(609, 250);
            this.gbCarrito.TabIndex = 7;
            this.gbCarrito.TabStop = false;
            this.gbCarrito.Text = "Carrito";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(60, 211);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 20);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "$0.00";
            // 
            // brnCancelarVenta
            // 
            this.brnCancelarVenta.Location = new System.Drawing.Point(461, 203);
            this.brnCancelarVenta.Name = "brnCancelarVenta";
            this.brnCancelarVenta.Size = new System.Drawing.Size(132, 36);
            this.brnCancelarVenta.TabIndex = 12;
            this.brnCancelarVenta.Text = "Cancelar venta";
            this.brnCancelarVenta.UseVisualStyleBackColor = true;
            this.brnCancelarVenta.Click += new System.EventHandler(this.brnCancelarVenta_Click);
            // 
            // lblInformacionPrecio
            // 
            this.lblInformacionPrecio.AutoSize = true;
            this.lblInformacionPrecio.Location = new System.Drawing.Point(6, 211);
            this.lblInformacionPrecio.Name = "lblInformacionPrecio";
            this.lblInformacionPrecio.Size = new System.Drawing.Size(48, 20);
            this.lblInformacionPrecio.TabIndex = 9;
            this.lblInformacionPrecio.Text = "Total:";
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.Location = new System.Drawing.Point(312, 203);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(132, 36);
            this.btnConfirmarVenta.TabIndex = 11;
            this.btnConfirmarVenta.Text = "Confirmar venta";
            this.btnConfirmarVenta.UseVisualStyleBackColor = true;
            this.btnConfirmarVenta.Click += new System.EventHandler(this.btnConfirmarVenta_Click);
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AllowUserToDeleteRows = false;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Location = new System.Drawing.Point(6, 25);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.Size = new System.Drawing.Size(597, 169);
            this.dgvCarrito.TabIndex = 8;
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.txtBusqueda);
            this.gbProductos.Controls.Add(this.dgvProductos);
            this.gbProductos.Controls.Add(this.btnAgregarCarrito);
            this.gbProductos.Controls.Add(this.nudCantidad);
            this.gbProductos.Controls.Add(this.lblCantidad);
            this.gbProductos.Location = new System.Drawing.Point(15, 27);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(609, 287);
            this.gbProductos.TabIndex = 2;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Productos";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(6, 62);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(597, 169);
            this.dgvProductos.TabIndex = 3;
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.Location = new System.Drawing.Point(447, 237);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(146, 36);
            this.btnAgregarCarrito.TabIndex = 6;
            this.btnAgregarCarrito.Text = "Agregar al Carrito";
            this.btnAgregarCarrito.UseVisualStyleBackColor = true;
            this.btnAgregarCarrito.Click += new System.EventHandler(this.btnAgregarCarrito_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(89, 239);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(53, 26);
            this.nudCantidad.TabIndex = 5;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(6, 245);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(77, 20);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(10, 26);
            this.txtBusqueda.MaxLength = 50;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(201, 26);
            this.txtBusqueda.TabIndex = 7;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.Enter += new System.EventHandler(this.txtBusqueda_Enter);
            this.txtBusqueda.Leave += new System.EventHandler(this.txtBusqueda_Leave);
            // 
            // frmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 632);
            this.Controls.Add(this.gbContenedor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegistrarVenta";
            this.Text = "Registrar Venta";
            this.gbContenedor.ResumeLayout(false);
            this.gbCarrito.ResumeLayout(false);
            this.gbCarrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContenedor;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.GroupBox gbCarrito;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblInformacionPrecio;
        private System.Windows.Forms.Button brnCancelarVenta;
        private System.Windows.Forms.Button btnConfirmarVenta;
        private System.Windows.Forms.Button btnAgregarCarrito;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}