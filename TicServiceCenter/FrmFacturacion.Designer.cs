namespace TicServiceCenter
{
    partial class FrmFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturacion));
            this.lblnombreproducto = new System.Windows.Forms.Label();
            this.txtbuscarproducto = new System.Windows.Forms.TextBox();
            this.GPDetallesdeStock = new System.Windows.Forms.GroupBox();
            this.txtFacturadoPor = new System.Windows.Forms.TextBox();
            this.BtnAgregarCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtSeleccionarCLiente = new System.Windows.Forms.TextBox();
            this.txtclienteTemporal = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.BtnNueva = new System.Windows.Forms.Button();
            this.dgvFacturacion = new System.Windows.Forms.DataGridView();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBBuscarPorNombre = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtcantidaddeproductos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verYEditarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnBuscarProductos = new System.Windows.Forms.Button();
            this.txtPrecioC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoPro = new System.Windows.Forms.TextBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.BtnColocar = new System.Windows.Forms.Button();
            this.GPDetallesdeStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).BeginInit();
            this.GBBuscarPorNombre.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombreproducto
            // 
            this.lblnombreproducto.AutoSize = true;
            this.lblnombreproducto.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreproducto.Location = new System.Drawing.Point(9, 25);
            this.lblnombreproducto.Name = "lblnombreproducto";
            this.lblnombreproducto.Size = new System.Drawing.Size(104, 16);
            this.lblnombreproducto.TabIndex = 14;
            this.lblnombreproducto.Text = "Buscar Producto";
            // 
            // txtbuscarproducto
            // 
            this.txtbuscarproducto.Location = new System.Drawing.Point(130, 24);
            this.txtbuscarproducto.Name = "txtbuscarproducto";
            this.txtbuscarproducto.Size = new System.Drawing.Size(151, 20);
            this.txtbuscarproducto.TabIndex = 13;
            // 
            // GPDetallesdeStock
            // 
            this.GPDetallesdeStock.Controls.Add(this.txtFacturadoPor);
            this.GPDetallesdeStock.Controls.Add(this.BtnAgregarCliente);
            this.GPDetallesdeStock.Controls.Add(this.label5);
            this.GPDetallesdeStock.Controls.Add(this.lblprecio);
            this.GPDetallesdeStock.Controls.Add(this.lblcantidad);
            this.GPDetallesdeStock.Controls.Add(this.txtSeleccionarCLiente);
            this.GPDetallesdeStock.Controls.Add(this.txtclienteTemporal);
            this.GPDetallesdeStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GPDetallesdeStock.Location = new System.Drawing.Point(12, 401);
            this.GPDetallesdeStock.Name = "GPDetallesdeStock";
            this.GPDetallesdeStock.Size = new System.Drawing.Size(362, 168);
            this.GPDetallesdeStock.TabIndex = 22;
            this.GPDetallesdeStock.TabStop = false;
            // 
            // txtFacturadoPor
            // 
            this.txtFacturadoPor.Location = new System.Drawing.Point(150, 35);
            this.txtFacturadoPor.Name = "txtFacturadoPor";
            this.txtFacturadoPor.ReadOnly = true;
            this.txtFacturadoPor.Size = new System.Drawing.Size(130, 20);
            this.txtFacturadoPor.TabIndex = 14;
            // 
            // BtnAgregarCliente
            // 
            this.BtnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.BtnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarCliente.Image = global::TicServiceCenter.Properties.Resources.anadir;
            this.BtnAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAgregarCliente.Location = new System.Drawing.Point(284, 65);
            this.BtnAgregarCliente.Name = "BtnAgregarCliente";
            this.BtnAgregarCliente.Size = new System.Drawing.Size(28, 30);
            this.BtnAgregarCliente.TabIndex = 16;
            this.BtnAgregarCliente.UseVisualStyleBackColor = true;
            this.BtnAgregarCliente.Click += new System.EventHandler(this.BtnAgregarCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Facturado Por";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(23, 73);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(119, 16);
            this.lblprecio.TabIndex = 10;
            this.lblprecio.Text = "Seleccionar Cliente";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.Location = new System.Drawing.Point(23, 110);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(105, 16);
            this.lblcantidad.TabIndex = 9;
            this.lblcantidad.Text = "Cliente Temporal";
            // 
            // txtSeleccionarCLiente
            // 
            this.txtSeleccionarCLiente.Location = new System.Drawing.Point(150, 70);
            this.txtSeleccionarCLiente.Name = "txtSeleccionarCLiente";
            this.txtSeleccionarCLiente.Size = new System.Drawing.Size(130, 20);
            this.txtSeleccionarCLiente.TabIndex = 5;
            // 
            // txtclienteTemporal
            // 
            this.txtclienteTemporal.Location = new System.Drawing.Point(150, 106);
            this.txtclienteTemporal.Name = "txtclienteTemporal";
            this.txtclienteTemporal.Size = new System.Drawing.Size(130, 20);
            this.txtclienteTemporal.TabIndex = 1;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnsalir.Location = new System.Drawing.Point(757, 401);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(132, 33);
            this.btnsalir.TabIndex = 18;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnImprimir.Location = new System.Drawing.Point(757, 349);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(132, 33);
            this.btnImprimir.TabIndex = 17;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnguardar.Location = new System.Drawing.Point(757, 297);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(132, 33);
            this.btnguardar.TabIndex = 16;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnEliminar.Location = new System.Drawing.Point(757, 245);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 33);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // BtnNueva
            // 
            this.BtnNueva.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.BtnNueva.Location = new System.Drawing.Point(757, 192);
            this.BtnNueva.Name = "BtnNueva";
            this.BtnNueva.Size = new System.Drawing.Size(132, 33);
            this.BtnNueva.TabIndex = 23;
            this.BtnNueva.Text = "Nueva";
            this.BtnNueva.UseVisualStyleBackColor = true;
            this.BtnNueva.Click += new System.EventHandler(this.BtnNueva_Click);
            // 
            // dgvFacturacion
            // 
            this.dgvFacturacion.AllowUserToAddRows = false;
            this.dgvFacturacion.AllowUserToDeleteRows = false;
            this.dgvFacturacion.AllowUserToOrderColumns = true;
            this.dgvFacturacion.AllowUserToResizeColumns = false;
            this.dgvFacturacion.AllowUserToResizeRows = false;
            this.dgvFacturacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturacion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFacturacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFacturacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFacturacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(120)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFacturacion.ColumnHeadersHeight = 40;
            this.dgvFacturacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto,
            this.NombrePro,
            this.Precio,
            this.Cantidad,
            this.importe});
            this.dgvFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFacturacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFacturacion.EnableHeadersVisualStyles = false;
            this.dgvFacturacion.GridColor = System.Drawing.SystemColors.Control;
            this.dgvFacturacion.Location = new System.Drawing.Point(12, 135);
            this.dgvFacturacion.MultiSelect = false;
            this.dgvFacturacion.Name = "dgvFacturacion";
            this.dgvFacturacion.ReadOnly = true;
            this.dgvFacturacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFacturacion.RowHeadersVisible = false;
            this.dgvFacturacion.RowHeadersWidth = 10;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(22)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFacturacion.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFacturacion.RowTemplate.Height = 30;
            this.dgvFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturacion.Size = new System.Drawing.Size(735, 248);
            this.dgvFacturacion.TabIndex = 80;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.DataPropertyName = "CodigoProducto";
            this.CodigoProducto.FillWeight = 49.55036F;
            this.CodigoProducto.HeaderText = "Codigo";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            // 
            // NombrePro
            // 
            this.NombrePro.DataPropertyName = "NombrePro";
            this.NombrePro.FillWeight = 106.4554F;
            this.NombrePro.HeaderText = "Nombre";
            this.NombrePro.Name = "NombrePro";
            this.NombrePro.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.FillWeight = 106.4554F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.FillWeight = 119.1544F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // importe
            // 
            this.importe.DataPropertyName = "importe";
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            // 
            // GBBuscarPorNombre
            // 
            this.GBBuscarPorNombre.Controls.Add(this.checkBox2);
            this.GBBuscarPorNombre.Controls.Add(this.checkBox1);
            this.GBBuscarPorNombre.Controls.Add(this.label1);
            this.GBBuscarPorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBBuscarPorNombre.Location = new System.Drawing.Point(442, 29);
            this.GBBuscarPorNombre.Name = "GBBuscarPorNombre";
            this.GBBuscarPorNombre.Size = new System.Drawing.Size(242, 63);
            this.GBBuscarPorNombre.TabIndex = 81;
            this.GBBuscarPorNombre.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(175, 26);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(59, 17);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Credito";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(94, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Contado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Facturar a:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtcantidaddeproductos);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(462, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 168);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(133, 59);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(130, 20);
            this.txtTotal.TabIndex = 17;
            // 
            // txtcantidaddeproductos
            // 
            this.txtcantidaddeproductos.Location = new System.Drawing.Point(155, 24);
            this.txtcantidaddeproductos.Name = "txtcantidaddeproductos";
            this.txtcantidaddeproductos.ReadOnly = true;
            this.txtcantidaddeproductos.Size = new System.Drawing.Size(108, 20);
            this.txtcantidaddeproductos.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Productos Facturados";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Total";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 85;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarCategoriasToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // editarCategoriasToolStripMenuItem
            // 
            this.editarCategoriasToolStripMenuItem.Name = "editarCategoriasToolStripMenuItem";
            this.editarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.editarCategoriasToolStripMenuItem.Text = "Editar Categorias";
            this.editarCategoriasToolStripMenuItem.Click += new System.EventHandler(this.editarCategoriasToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verYEditarProductosToolStripMenuItem,
            this.editarInventarioToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // verYEditarProductosToolStripMenuItem
            // 
            this.verYEditarProductosToolStripMenuItem.Name = "verYEditarProductosToolStripMenuItem";
            this.verYEditarProductosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.verYEditarProductosToolStripMenuItem.Text = "Ver Inventario";
            this.verYEditarProductosToolStripMenuItem.Click += new System.EventHandler(this.verYEditarProductosToolStripMenuItem_Click);
            // 
            // editarInventarioToolStripMenuItem
            // 
            this.editarInventarioToolStripMenuItem.Name = "editarInventarioToolStripMenuItem";
            this.editarInventarioToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.editarInventarioToolStripMenuItem.Text = "Editar Inventario";
            this.editarInventarioToolStripMenuItem.Click += new System.EventHandler(this.editarInventarioToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnBuscarProductos);
            this.groupBox2.Controls.Add(this.txtbuscarproducto);
            this.groupBox2.Controls.Add(this.lblnombreproducto);
            this.groupBox2.Location = new System.Drawing.Point(11, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 63);
            this.groupBox2.TabIndex = 87;
            this.groupBox2.TabStop = false;
            // 
            // BtnBuscarProductos
            // 
            this.BtnBuscarProductos.FlatAppearance.BorderSize = 0;
            this.BtnBuscarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarProductos.Image = global::TicServiceCenter.Properties.Resources.lupa__2_;
            this.BtnBuscarProductos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscarProductos.Location = new System.Drawing.Point(290, 12);
            this.BtnBuscarProductos.Name = "BtnBuscarProductos";
            this.BtnBuscarProductos.Size = new System.Drawing.Size(73, 43);
            this.BtnBuscarProductos.TabIndex = 15;
            this.BtnBuscarProductos.UseVisualStyleBackColor = true;
            this.BtnBuscarProductos.Click += new System.EventHandler(this.BtnBuscarProductos_Click);
            // 
            // txtPrecioC
            // 
            this.txtPrecioC.Location = new System.Drawing.Point(767, 54);
            this.txtPrecioC.Name = "txtPrecioC";
            this.txtPrecioC.Size = new System.Drawing.Size(122, 20);
            this.txtPrecioC.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(702, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Precio C:";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(114, 575);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(68, 16);
            this.lbluser.TabIndex = 17;
            this.lbluser.Text = "__________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicServiceCenter.Properties.Resources.Logo_Transparente;
            this.pictureBox1.Location = new System.Drawing.Point(764, 514);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 89;
            this.label2.Text = "Conectado como:";
            // 
            // txtCodigoPro
            // 
            this.txtCodigoPro.Location = new System.Drawing.Point(12, 112);
            this.txtCodigoPro.Name = "txtCodigoPro";
            this.txtCodigoPro.Size = new System.Drawing.Size(73, 20);
            this.txtCodigoPro.TabIndex = 16;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(87, 112);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(160, 20);
            this.txtDescrip.TabIndex = 90;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(412, 112);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(182, 20);
            this.txtCantidad.TabIndex = 92;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(249, 112);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(162, 20);
            this.txtPrecio.TabIndex = 91;
            // 
            // BtnColocar
            // 
            this.BtnColocar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.BtnColocar.Location = new System.Drawing.Point(595, 111);
            this.BtnColocar.Name = "BtnColocar";
            this.BtnColocar.Size = new System.Drawing.Size(153, 22);
            this.BtnColocar.TabIndex = 93;
            this.BtnColocar.Text = "Colocar";
            this.BtnColocar.UseVisualStyleBackColor = true;
            this.BtnColocar.Click += new System.EventHandler(this.BtnColocar_Click);
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 598);
            this.Controls.Add(this.BtnColocar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtCodigoPro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPrecioC);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBBuscarPorNombre);
            this.Controls.Add(this.dgvFacturacion);
            this.Controls.Add(this.GPDetallesdeStock);
            this.Controls.Add(this.BtnNueva);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            this.GPDetallesdeStock.ResumeLayout(false);
            this.GPDetallesdeStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).EndInit();
            this.GBBuscarPorNombre.ResumeLayout(false);
            this.GBBuscarPorNombre.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombreproducto;
        private System.Windows.Forms.TextBox txtbuscarproducto;
        private System.Windows.Forms.GroupBox GPDetallesdeStock;
        private System.Windows.Forms.Button BtnNueva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtSeleccionarCLiente;
        private System.Windows.Forms.TextBox txtclienteTemporal;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvFacturacion;
        private System.Windows.Forms.GroupBox GBBuscarPorNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verYEditarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnBuscarProductos;
        private System.Windows.Forms.Button BtnAgregarCliente;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbluser;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCodigoPro;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button BtnColocar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.TextBox txtcantidaddeproductos;
        private System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtFacturadoPor;
    }
}