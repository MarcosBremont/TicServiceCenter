namespace TicServiceCenter
{
    partial class FrmStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStock));
            this.GPDetallesdeStock = new System.Windows.Forms.GroupBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.dtpfechastock = new System.Windows.Forms.DateTimePicker();
            this.lblfechastock = new System.Windows.Forms.Label();
            this.lblnombreproducto = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblidproducto = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.GBBuscarPorNombre = new System.Windows.Forms.GroupBox();
            this.txtbuscarpornombredelproducto = new System.Windows.Forms.TextBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.IDInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcantidaddeproductos = new System.Windows.Forms.TextBox();
            this.GPDetallesdeStock.SuspendLayout();
            this.GBBuscarPorNombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // GPDetallesdeStock
            // 
            this.GPDetallesdeStock.Controls.Add(this.lblCategoria);
            this.GPDetallesdeStock.Controls.Add(this.txtCategoria);
            this.GPDetallesdeStock.Controls.Add(this.btneditar);
            this.GPDetallesdeStock.Controls.Add(this.btneliminar);
            this.GPDetallesdeStock.Controls.Add(this.btnguardar);
            this.GPDetallesdeStock.Controls.Add(this.btnnuevo);
            this.GPDetallesdeStock.Controls.Add(this.dtpfechastock);
            this.GPDetallesdeStock.Controls.Add(this.lblfechastock);
            this.GPDetallesdeStock.Controls.Add(this.lblnombreproducto);
            this.GPDetallesdeStock.Controls.Add(this.lbldescripcion);
            this.GPDetallesdeStock.Controls.Add(this.lblprecio);
            this.GPDetallesdeStock.Controls.Add(this.lblcantidad);
            this.GPDetallesdeStock.Controls.Add(this.lblidproducto);
            this.GPDetallesdeStock.Controls.Add(this.txtprecio);
            this.GPDetallesdeStock.Controls.Add(this.txtnombreproducto);
            this.GPDetallesdeStock.Controls.Add(this.txtdescripcion);
            this.GPDetallesdeStock.Controls.Add(this.txtcantidad);
            this.GPDetallesdeStock.Controls.Add(this.txtidproducto);
            this.GPDetallesdeStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GPDetallesdeStock.Location = new System.Drawing.Point(12, 12);
            this.GPDetallesdeStock.Name = "GPDetallesdeStock";
            this.GPDetallesdeStock.Size = new System.Drawing.Size(448, 509);
            this.GPDetallesdeStock.TabIndex = 0;
            this.GPDetallesdeStock.TabStop = false;
            this.GPDetallesdeStock.Text = "Detalles de Stock";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(30, 110);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(64, 16);
            this.lblCategoria.TabIndex = 20;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(147, 106);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(240, 20);
            this.txtCategoria.TabIndex = 1;
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btneditar.Location = new System.Drawing.Point(342, 433);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(90, 33);
            this.btneditar.TabIndex = 9;
            this.btneditar.Text = "Actualizar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btneliminar.Location = new System.Drawing.Point(231, 433);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(90, 33);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnguardar.Location = new System.Drawing.Point(120, 433);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(90, 33);
            this.btnguardar.TabIndex = 7;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnnuevo.Location = new System.Drawing.Point(9, 433);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(90, 33);
            this.btnnuevo.TabIndex = 6;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // dtpfechastock
            // 
            this.dtpfechastock.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechastock.Location = new System.Drawing.Point(147, 350);
            this.dtpfechastock.Name = "dtpfechastock";
            this.dtpfechastock.Size = new System.Drawing.Size(98, 20);
            this.dtpfechastock.TabIndex = 5;
            // 
            // lblfechastock
            // 
            this.lblfechastock.AutoSize = true;
            this.lblfechastock.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechastock.Location = new System.Drawing.Point(31, 354);
            this.lblfechastock.Name = "lblfechastock";
            this.lblfechastock.Size = new System.Drawing.Size(94, 16);
            this.lblfechastock.TabIndex = 13;
            this.lblfechastock.Text = "Fecha de Stock";
            // 
            // lblnombreproducto
            // 
            this.lblnombreproducto.AutoSize = true;
            this.lblnombreproducto.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreproducto.Location = new System.Drawing.Point(30, 72);
            this.lblnombreproducto.Name = "lblnombreproducto";
            this.lblnombreproducto.Size = new System.Drawing.Size(110, 16);
            this.lblnombreproducto.TabIndex = 12;
            this.lblnombreproducto.Text = "Nombre Producto";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescripcion.Location = new System.Drawing.Point(30, 147);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(76, 16);
            this.lbldescripcion.TabIndex = 11;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(30, 278);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(45, 16);
            this.lblprecio.TabIndex = 10;
            this.lblprecio.Text = "Precio";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.Location = new System.Drawing.Point(31, 316);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(58, 16);
            this.lblcantidad.TabIndex = 9;
            this.lblcantidad.Text = "Cantidad";
            // 
            // lblidproducto
            // 
            this.lblidproducto.AutoSize = true;
            this.lblidproducto.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidproducto.Location = new System.Drawing.Point(30, 34);
            this.lblidproducto.Name = "lblidproducto";
            this.lblidproducto.Size = new System.Drawing.Size(76, 16);
            this.lblidproducto.TabIndex = 6;
            this.lblidproducto.Text = "ID Producto";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(147, 274);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(240, 20);
            this.txtprecio.TabIndex = 3;
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Location = new System.Drawing.Point(147, 68);
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.Size = new System.Drawing.Size(240, 20);
            this.txtnombreproducto.TabIndex = 0;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(147, 143);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(240, 107);
            this.txtdescripcion.TabIndex = 2;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(147, 312);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(240, 20);
            this.txtcantidad.TabIndex = 4;
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(147, 30);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(28, 20);
            this.txtidproducto.TabIndex = 0;
            // 
            // GBBuscarPorNombre
            // 
            this.GBBuscarPorNombre.Controls.Add(this.txtbuscarpornombredelproducto);
            this.GBBuscarPorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBBuscarPorNombre.Location = new System.Drawing.Point(478, 20);
            this.GBBuscarPorNombre.Name = "GBBuscarPorNombre";
            this.GBBuscarPorNombre.Size = new System.Drawing.Size(200, 80);
            this.GBBuscarPorNombre.TabIndex = 1;
            this.GBBuscarPorNombre.TabStop = false;
            this.GBBuscarPorNombre.Text = "Buscar Por Nombre del Producto";
            // 
            // txtbuscarpornombredelproducto
            // 
            this.txtbuscarpornombredelproducto.Location = new System.Drawing.Point(8, 36);
            this.txtbuscarpornombredelproducto.Name = "txtbuscarpornombredelproducto";
            this.txtbuscarpornombredelproducto.Size = new System.Drawing.Size(184, 20);
            this.txtbuscarpornombredelproducto.TabIndex = 0;
            this.txtbuscarpornombredelproducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscarpornombredelproducto_KeyUp);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToOrderColumns = true;
            this.dgvStock.AllowUserToResizeColumns = false;
            this.dgvStock.AllowUserToResizeRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(120)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.ColumnHeadersHeight = 40;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDInventario,
            this.NombreProducto,
            this.CategoriaProducto,
            this.Descripcion,
            this.Precio});
            this.dgvStock.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStock.EnableHeadersVisualStyles = false;
            this.dgvStock.GridColor = System.Drawing.SystemColors.Control;
            this.dgvStock.Location = new System.Drawing.Point(478, 118);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 10;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStock.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStock.RowTemplate.Height = 30;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(699, 373);
            this.dgvStock.TabIndex = 79;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
            // 
            // IDInventario
            // 
            this.IDInventario.DataPropertyName = "IDInventario";
            this.IDInventario.FillWeight = 49.55036F;
            this.IDInventario.HeaderText = "Codigo";
            this.IDInventario.Name = "IDInventario";
            this.IDInventario.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.DataPropertyName = "NombreProducto";
            this.NombreProducto.FillWeight = 119.1544F;
            this.NombreProducto.HeaderText = "Nombre del Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // CategoriaProducto
            // 
            this.CategoriaProducto.DataPropertyName = "CategoriaProducto";
            this.CategoriaProducto.FillWeight = 106.4554F;
            this.CategoriaProducto.HeaderText = "Categoria del Producto";
            this.CategoriaProducto.Name = "CategoriaProducto";
            this.CategoriaProducto.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.FillWeight = 106.4554F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.FillWeight = 106.4554F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // txtcantidaddeproductos
            // 
            this.txtcantidaddeproductos.Location = new System.Drawing.Point(478, 501);
            this.txtcantidaddeproductos.Name = "txtcantidaddeproductos";
            this.txtcantidaddeproductos.ReadOnly = true;
            this.txtcantidaddeproductos.Size = new System.Drawing.Size(75, 20);
            this.txtcantidaddeproductos.TabIndex = 1;
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 533);
            this.Controls.Add(this.txtcantidaddeproductos);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.GBBuscarPorNombre);
            this.Controls.Add(this.GPDetallesdeStock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.FrmStock_Load);
            this.GPDetallesdeStock.ResumeLayout(false);
            this.GPDetallesdeStock.PerformLayout();
            this.GBBuscarPorNombre.ResumeLayout(false);
            this.GBBuscarPorNombre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GPDetallesdeStock;
        private System.Windows.Forms.Label lblnombreproducto;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblidproducto;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.DateTimePicker dtpfechastock;
        private System.Windows.Forms.Label lblfechastock;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.GroupBox GBBuscarPorNombre;
        private System.Windows.Forms.TextBox txtbuscarpornombredelproducto;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtcantidaddeproductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}