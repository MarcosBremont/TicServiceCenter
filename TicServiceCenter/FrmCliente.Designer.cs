namespace TicServiceCenter
{
    partial class FrmCliente
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
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.cmbprovincia = new System.Windows.Forms.ComboBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtNoCelular = new System.Windows.Forms.MaskedTextBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.IDInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(148, 223);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoPostal.TabIndex = 83;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnEliminar);
            this.GroupBox2.Controls.Add(this.btnActualizar);
            this.GroupBox2.Controls.Add(this.btnGuardar);
            this.GroupBox2.Controls.Add(this.btnNuevo);
            this.GroupBox2.Location = new System.Drawing.Point(487, 31);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(119, 174);
            this.GroupBox2.TabIndex = 89;
            this.GroupBox2.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnEliminar.Location = new System.Drawing.Point(16, 124);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 29);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnActualizar.Location = new System.Drawing.Point(16, 89);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 29);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnGuardar.Location = new System.Drawing.Point(16, 54);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 29);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.btnNuevo.Location = new System.Drawing.Point(16, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(87, 29);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.LightGray;
            this.Label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(115, -28);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(128, 22);
            this.Label11.TabIndex = 90;
            this.Label11.Text = "Detalles Cliente";
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(149, 368);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotas.Size = new System.Drawing.Size(251, 67);
            this.txtNotas.TabIndex = 88;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(149, 295);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(226, 20);
            this.txtCorreoElectronico.TabIndex = 85;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.Label23.Location = new System.Drawing.Point(25, 369);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(42, 16);
            this.Label23.TabIndex = 104;
            this.Label23.Text = "Notas";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.Label21.Location = new System.Drawing.Point(25, 333);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(82, 16);
            this.Label21.TabIndex = 102;
            this.Label21.Text = "*Nro Celular";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.Label20.Location = new System.Drawing.Point(25, 296);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(117, 16);
            this.Label20.TabIndex = 101;
            this.Label20.Text = "Correo Electronico";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.Label19.Location = new System.Drawing.Point(25, 259);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(56, 16);
            this.Label19.TabIndex = 100;
            this.Label19.Text = "Teléfono";
            // 
            // cmbprovincia
            // 
            this.cmbprovincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbprovincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbprovincia.FormattingEnabled = true;
            this.cmbprovincia.Items.AddRange(new object[] {
            "Central",
            "Coast",
            "Nairobi",
            "Eastern",
            "Rift valley",
            "N. eastern",
            "Nyanza",
            "Western"});
            this.cmbprovincia.Location = new System.Drawing.Point(148, 184);
            this.cmbprovincia.Name = "cmbprovincia";
            this.cmbprovincia.Size = new System.Drawing.Size(172, 21);
            this.cmbprovincia.TabIndex = 82;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(148, 151);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(144, 20);
            this.txtCiudad.TabIndex = 81;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(148, 118);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(273, 20);
            this.txtReferencia.TabIndex = 80;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(148, 84);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(273, 20);
            this.txtDireccion.TabIndex = 79;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.Label9.Location = new System.Drawing.Point(25, 223);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(115, 16);
            this.Label9.TabIndex = 99;
            this.Label9.Text = "*Zip/Código Postal";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.Label8.Location = new System.Drawing.Point(25, 188);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(68, 16);
            this.Label8.TabIndex = 98;
            this.Label8.Text = "*Provincia";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.Label7.Location = new System.Drawing.Point(25, 119);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(70, 16);
            this.Label7.TabIndex = 97;
            this.Label7.Text = "Referencia";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.Label6.Location = new System.Drawing.Point(25, 154);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(53, 16);
            this.Label6.TabIndex = 96;
            this.Label6.Text = "*Ciudad";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.Label5.Location = new System.Drawing.Point(25, 87);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(68, 16);
            this.Label5.TabIndex = 95;
            this.Label5.Text = "*Direccion";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.Label2.Location = new System.Drawing.Point(25, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(61, 16);
            this.Label2.TabIndex = 94;
            this.Label2.Text = "*Nombre";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(148, 51);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(273, 20);
            this.txtNombreCompleto.TabIndex = 78;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(149, 17);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.ReadOnly = true;
            this.txtIDCliente.Size = new System.Drawing.Size(118, 20);
            this.txtIDCliente.TabIndex = 91;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F);
            this.Label4.Location = new System.Drawing.Point(25, 17);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 16);
            this.Label4.TabIndex = 93;
            this.Label4.Text = "ID Cliente";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(149, 259);
            this.txtTelefono.Mask = "(999)000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 105;
            // 
            // txtNoCelular
            // 
            this.txtNoCelular.Location = new System.Drawing.Point(149, 333);
            this.txtNoCelular.Mask = "000-000-0000";
            this.txtNoCelular.Name = "txtNoCelular";
            this.txtNoCelular.Size = new System.Drawing.Size(100, 20);
            this.txtNoCelular.TabIndex = 106;
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
            this.dgvStock.Location = new System.Drawing.Point(465, 211);
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
            this.dgvStock.Size = new System.Drawing.Size(735, 248);
            this.dgvStock.TabIndex = 107;
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
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 460);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.txtNoCelular);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.Label23);
            this.Controls.Add(this.Label21);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.cmbprovincia);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.Label4);
            this.Name = "FrmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtCodigoPostal;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnActualizar;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtNotas;
        internal System.Windows.Forms.TextBox txtCorreoElectronico;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.ComboBox cmbprovincia;
        internal System.Windows.Forms.TextBox txtCiudad;
        internal System.Windows.Forms.TextBox txtReferencia;
        internal System.Windows.Forms.TextBox txtDireccion;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtNombreCompleto;
        internal System.Windows.Forms.TextBox txtIDCliente;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.MaskedTextBox txtNoCelular;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}