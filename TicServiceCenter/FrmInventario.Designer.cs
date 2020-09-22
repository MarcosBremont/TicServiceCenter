namespace TicServiceCenter
{
    partial class FrmInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GBBuscarPorNombre = new System.Windows.Forms.GroupBox();
            this.GBBuscarPorCategoria = new System.Windows.Forms.GroupBox();
            this.GBBuscarPorCodigo = new System.Windows.Forms.GroupBox();
            this.txtbuscarpornombredelproducto = new System.Windows.Forms.TextBox();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.txtbuscarporcategoria = new System.Windows.Forms.TextBox();
            this.txtbuscarporcodigo = new System.Windows.Forms.TextBox();
            this.IDInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBBuscarPorNombre.SuspendLayout();
            this.GBBuscarPorCategoria.SuspendLayout();
            this.GBBuscarPorCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // GBBuscarPorNombre
            // 
            this.GBBuscarPorNombre.Controls.Add(this.txtbuscarpornombredelproducto);
            this.GBBuscarPorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBBuscarPorNombre.Location = new System.Drawing.Point(59, 28);
            this.GBBuscarPorNombre.Name = "GBBuscarPorNombre";
            this.GBBuscarPorNombre.Size = new System.Drawing.Size(200, 80);
            this.GBBuscarPorNombre.TabIndex = 0;
            this.GBBuscarPorNombre.TabStop = false;
            this.GBBuscarPorNombre.Text = "Buscar Por Nombre del Producto";
            // 
            // GBBuscarPorCategoria
            // 
            this.GBBuscarPorCategoria.Controls.Add(this.txtbuscarporcategoria);
            this.GBBuscarPorCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GBBuscarPorCategoria.Location = new System.Drawing.Point(354, 28);
            this.GBBuscarPorCategoria.Name = "GBBuscarPorCategoria";
            this.GBBuscarPorCategoria.Size = new System.Drawing.Size(200, 80);
            this.GBBuscarPorCategoria.TabIndex = 1;
            this.GBBuscarPorCategoria.TabStop = false;
            this.GBBuscarPorCategoria.Text = "Buscar Por Categoria";
            // 
            // GBBuscarPorCodigo
            // 
            this.GBBuscarPorCodigo.Controls.Add(this.txtbuscarporcodigo);
            this.GBBuscarPorCodigo.Location = new System.Drawing.Point(649, 28);
            this.GBBuscarPorCodigo.Name = "GBBuscarPorCodigo";
            this.GBBuscarPorCodigo.Size = new System.Drawing.Size(200, 80);
            this.GBBuscarPorCodigo.TabIndex = 2;
            this.GBBuscarPorCodigo.TabStop = false;
            this.GBBuscarPorCodigo.Text = "Buscar Por Codigo";
            // 
            // txtbuscarpornombredelproducto
            // 
            this.txtbuscarpornombredelproducto.Location = new System.Drawing.Point(8, 36);
            this.txtbuscarpornombredelproducto.Name = "txtbuscarpornombredelproducto";
            this.txtbuscarpornombredelproducto.Size = new System.Drawing.Size(184, 20);
            this.txtbuscarpornombredelproducto.TabIndex = 0;
            this.txtbuscarpornombredelproducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscarpornombredelproducto_KeyUp);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AllowUserToOrderColumns = true;
            this.dgvInventario.AllowUserToResizeColumns = false;
            this.dgvInventario.AllowUserToResizeRows = false;
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDInventario,
            this.NombreProducto,
            this.CategoriaProducto,
            this.Precio});
            this.dgvInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvInventario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.GridColor = System.Drawing.Color.White;
            this.dgvInventario.Location = new System.Drawing.Point(0, 165);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(173)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowHeadersWidth = 10;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInventario.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvInventario.RowTemplate.Height = 30;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(908, 330);
            this.dgvInventario.TabIndex = 78;
            // 
            // txtbuscarporcategoria
            // 
            this.txtbuscarporcategoria.Location = new System.Drawing.Point(10, 36);
            this.txtbuscarporcategoria.Name = "txtbuscarporcategoria";
            this.txtbuscarporcategoria.Size = new System.Drawing.Size(184, 20);
            this.txtbuscarporcategoria.TabIndex = 1;
            this.txtbuscarporcategoria.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscarporcategoria_KeyUp);
            // 
            // txtbuscarporcodigo
            // 
            this.txtbuscarporcodigo.Location = new System.Drawing.Point(6, 36);
            this.txtbuscarporcodigo.Name = "txtbuscarporcodigo";
            this.txtbuscarporcodigo.Size = new System.Drawing.Size(184, 20);
            this.txtbuscarporcodigo.TabIndex = 2;
            this.txtbuscarporcodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscarporcodigo_KeyUp);
            // 
            // IDInventario
            // 
            this.IDInventario.DataPropertyName = "IDInventario";
            this.IDInventario.FillWeight = 76.14214F;
            this.IDInventario.HeaderText = "Codigo";
            this.IDInventario.Name = "IDInventario";
            this.IDInventario.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.DataPropertyName = "NombreProducto";
            this.NombreProducto.FillWeight = 111.9289F;
            this.NombreProducto.HeaderText = "Nombre del Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // CategoriaProducto
            // 
            this.CategoriaProducto.DataPropertyName = "CategoriaProducto";
            this.CategoriaProducto.HeaderText = "Categoria del Producto";
            this.CategoriaProducto.Name = "CategoriaProducto";
            this.CategoriaProducto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 495);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.GBBuscarPorCodigo);
            this.Controls.Add(this.GBBuscarPorCategoria);
            this.Controls.Add(this.GBBuscarPorNombre);
            this.Name = "FrmInventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            this.GBBuscarPorNombre.ResumeLayout(false);
            this.GBBuscarPorNombre.PerformLayout();
            this.GBBuscarPorCategoria.ResumeLayout(false);
            this.GBBuscarPorCategoria.PerformLayout();
            this.GBBuscarPorCodigo.ResumeLayout(false);
            this.GBBuscarPorCodigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBBuscarPorNombre;
        private System.Windows.Forms.TextBox txtbuscarpornombredelproducto;
        private System.Windows.Forms.GroupBox GBBuscarPorCategoria;
        private System.Windows.Forms.GroupBox GBBuscarPorCodigo;
        private System.Windows.Forms.TextBox txtbuscarporcategoria;
        private System.Windows.Forms.TextBox txtbuscarporcodigo;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}