namespace TicServiceCenter
{
    partial class FrmCambiarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambiarContraseña));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.txtViejaContraseña = new System.Windows.Forms.TextBox();
            this.panelLogoTic = new System.Windows.Forms.Panel();
            this.pictureBoxLogoTic = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panelContrasena = new System.Windows.Forms.Panel();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCambiarContrasena = new System.Windows.Forms.Button();
            this.panelLogoTic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoTic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(372, 95);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(276, 16);
            this.txtUsuario.TabIndex = 18;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.txtConfirmarContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmarContraseña.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.txtConfirmarContraseña.ForeColor = System.Drawing.Color.White;
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(372, 250);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(276, 16);
            this.txtConfirmarContraseña.TabIndex = 23;
            this.txtConfirmarContraseña.Text = "Confirmar Contraseña";
            this.txtConfirmarContraseña.Enter += new System.EventHandler(this.txtConfirmarContraseña_Enter);
            this.txtConfirmarContraseña.Leave += new System.EventHandler(this.txtConfirmarContraseña_Leave);
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.txtNuevaContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNuevaContraseña.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.txtNuevaContraseña.ForeColor = System.Drawing.Color.White;
            this.txtNuevaContraseña.Location = new System.Drawing.Point(372, 197);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(276, 16);
            this.txtNuevaContraseña.TabIndex = 22;
            this.txtNuevaContraseña.Text = "Nueva Contraseña";
            this.txtNuevaContraseña.Enter += new System.EventHandler(this.txtNuevaContraseña_Enter);
            this.txtNuevaContraseña.Leave += new System.EventHandler(this.txtNuevaContraseña_Leave);
            // 
            // txtViejaContraseña
            // 
            this.txtViejaContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.txtViejaContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtViejaContraseña.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.txtViejaContraseña.ForeColor = System.Drawing.Color.White;
            this.txtViejaContraseña.Location = new System.Drawing.Point(372, 145);
            this.txtViejaContraseña.Name = "txtViejaContraseña";
            this.txtViejaContraseña.Size = new System.Drawing.Size(276, 16);
            this.txtViejaContraseña.TabIndex = 20;
            this.txtViejaContraseña.Text = "Contraseña Actual";
            this.txtViejaContraseña.Enter += new System.EventHandler(this.txtViejaContraseña_Enter);
            this.txtViejaContraseña.Leave += new System.EventHandler(this.txtViejaContraseña_Leave);
            // 
            // panelLogoTic
            // 
            this.panelLogoTic.BackColor = System.Drawing.Color.White;
            this.panelLogoTic.Controls.Add(this.pictureBoxLogoTic);
            this.panelLogoTic.Location = new System.Drawing.Point(-3, -7);
            this.panelLogoTic.Name = "panelLogoTic";
            this.panelLogoTic.Size = new System.Drawing.Size(249, 422);
            this.panelLogoTic.TabIndex = 27;
            // 
            // pictureBoxLogoTic
            // 
            this.pictureBoxLogoTic.Image = global::TicServiceCenter.Properties.Resources.Logo_Transparente;
            this.pictureBoxLogoTic.Location = new System.Drawing.Point(3, 109);
            this.pictureBoxLogoTic.Name = "pictureBoxLogoTic";
            this.pictureBoxLogoTic.Size = new System.Drawing.Size(237, 130);
            this.pictureBoxLogoTic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogoTic.TabIndex = 1;
            this.pictureBoxLogoTic.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(390, 23);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(204, 25);
            this.lblLogin.TabIndex = 28;
            this.lblLogin.Text = "Cambiar Contraseña";
            // 
            // panelContrasena
            // 
            this.panelContrasena.BackColor = System.Drawing.Color.White;
            this.panelContrasena.Location = new System.Drawing.Point(372, 163);
            this.panelContrasena.Name = "panelContrasena";
            this.panelContrasena.Size = new System.Drawing.Size(287, 4);
            this.panelContrasena.TabIndex = 30;
            // 
            // panelUsuario
            // 
            this.panelUsuario.BackColor = System.Drawing.Color.White;
            this.panelUsuario.Location = new System.Drawing.Point(372, 112);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(287, 4);
            this.panelUsuario.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(372, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 4);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(372, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 4);
            this.panel2.TabIndex = 32;
            // 
            // btnCambiarContrasena
            // 
            this.btnCambiarContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btnCambiarContrasena.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCambiarContrasena.FlatAppearance.BorderSize = 2;
            this.btnCambiarContrasena.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.btnCambiarContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarContrasena.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnCambiarContrasena.ForeColor = System.Drawing.Color.White;
            this.btnCambiarContrasena.Location = new System.Drawing.Point(372, 316);
            this.btnCambiarContrasena.Name = "btnCambiarContrasena";
            this.btnCambiarContrasena.Size = new System.Drawing.Size(287, 42);
            this.btnCambiarContrasena.TabIndex = 9;
            this.btnCambiarContrasena.Text = "Cambiar Contraseña";
            this.btnCambiarContrasena.UseVisualStyleBackColor = false;
            this.btnCambiarContrasena.Click += new System.EventHandler(this.btnCambiarContrasena_Click);
            // 
            // FrmCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(728, 404);
            this.Controls.Add(this.btnCambiarContrasena);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContrasena);
            this.Controls.Add(this.panelUsuario);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panelLogoTic);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtConfirmarContraseña);
            this.Controls.Add(this.txtNuevaContraseña);
            this.Controls.Add(this.txtViejaContraseña);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCambiarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.FrmCambiarContraseña_Load);
            this.panelLogoTic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoTic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtUsuario;
        internal System.Windows.Forms.TextBox txtConfirmarContraseña;
        internal System.Windows.Forms.TextBox txtNuevaContraseña;
        internal System.Windows.Forms.TextBox txtViejaContraseña;
        private System.Windows.Forms.Panel panelLogoTic;
        private System.Windows.Forms.PictureBox pictureBoxLogoTic;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel panelContrasena;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCambiarContrasena;
    }
}