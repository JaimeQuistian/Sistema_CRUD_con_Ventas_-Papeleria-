namespace papeleriaPractica
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.gbInventario = new System.Windows.Forms.GroupBox();
            this.dgvInventarioDeProductos = new System.Windows.Forms.DataGridView();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.btnRegistrarProducto = new System.Windows.Forms.Button();
            this.gbOpciones.SuspendLayout();
            this.gbInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioDeProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.gbInventario);
            this.gbOpciones.Controls.Add(this.btnRealizarVenta);
            this.gbOpciones.Controls.Add(this.btnRegistrarProducto);
            this.gbOpciones.Location = new System.Drawing.Point(20, 20);
            this.gbOpciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOpciones.Size = new System.Drawing.Size(1162, 654);
            this.gbOpciones.TabIndex = 0;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // gbInventario
            // 
            this.gbInventario.Controls.Add(this.dgvInventarioDeProductos);
            this.gbInventario.Location = new System.Drawing.Point(221, 27);
            this.gbInventario.Name = "gbInventario";
            this.gbInventario.Size = new System.Drawing.Size(934, 619);
            this.gbInventario.TabIndex = 2;
            this.gbInventario.TabStop = false;
            this.gbInventario.Text = "Inventario de Productos";
            // 
            // dgvInventarioDeProductos
            // 
            this.dgvInventarioDeProductos.AllowUserToDeleteRows = false;
            this.dgvInventarioDeProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarioDeProductos.Location = new System.Drawing.Point(6, 25);
            this.dgvInventarioDeProductos.Name = "dgvInventarioDeProductos";
            this.dgvInventarioDeProductos.ReadOnly = true;
            this.dgvInventarioDeProductos.Size = new System.Drawing.Size(922, 588);
            this.dgvInventarioDeProductos.TabIndex = 0;
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.Location = new System.Drawing.Point(29, 115);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(158, 31);
            this.btnRealizarVenta.TabIndex = 1;
            this.btnRealizarVenta.Text = "Realizar venta";
            this.btnRealizarVenta.UseVisualStyleBackColor = true;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // btnRegistrarProducto
            // 
            this.btnRegistrarProducto.Location = new System.Drawing.Point(29, 55);
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.Size = new System.Drawing.Size(158, 31);
            this.btnRegistrarProducto.TabIndex = 0;
            this.btnRegistrarProducto.Text = "Registrar Poducto";
            this.btnRegistrarProducto.UseVisualStyleBackColor = true;
            this.btnRegistrarProducto.Click += new System.EventHandler(this.btnRegistrarProducto_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.gbOpciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Papelería";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbOpciones.ResumeLayout(false);
            this.gbInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioDeProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button btnRealizarVenta;
        private System.Windows.Forms.Button btnRegistrarProducto;
        private System.Windows.Forms.GroupBox gbInventario;
        private System.Windows.Forms.DataGridView dgvInventarioDeProductos;
    }
}

