﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicServiceCenter
{
    public partial class FrmRegistroDeUsuario : Form
    {
        public FrmRegistroDeUsuario()
        {
            InitializeComponent();
        }
        MySqlDataReader rdr = null;
        DataTable dt = new DataTable();

        MySqlConnection con = null;
        MySqlCommand cmd = null;
        String cs = ("Server=localhost; database=TicServiceCenter; user=root; password=1234");

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Por favor introduzca el nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    return;
                }
                con = new MySqlConnection(cs);
                con.Open();
                string ct = "select Usuario from RegistroUsuario where Usuario='" + txtUsuario.Text + "'";

                cmd = new MySqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Usuario no disponible", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!rdr.Read())
                {
                    MessageBox.Show("Usuario disponible", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Focus();

                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            TXTID.Text = "";
            txtNombre.Text = "";
            txtContrasena.Text = "";
            txtEmail.Text = "";
            txtNumeroDeContacto.Text = "";
            txtUsuario.Text = "";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO registrousuario (Nombre, Role, Usuario, Contrasena, NDeContacto, Email) values (@Nombre, @Role, @Usuario, @Contrasena, @NDeContacto, @Email)";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@Role", comboRoles.Text);
            comando.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
            comando.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);
            comando.Parameters.AddWithValue("@NDeContacto", txtNumeroDeContacto.Text);
            comando.Parameters.AddWithValue("@Email", txtEmail.Text);
            comando.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Usuario Agregado exitosamente");
         
            clear();
        
        }

        private void FrmRegistroDeUsuario_Load(object sender, EventArgs e)
        {
            CargarDgvUsuariosRegistrados();
        }

        public void CargarDgvUsuariosRegistrados()
        {
            con = new MySqlConnection(cs);
           

            MySqlCommand cmd = new MySqlCommand("Select * from registrousuario", con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvUsuariosRegistrados.DataSource = tabla;
            
        }

        private void dgvUsuariosRegistrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTID.Text = dgvUsuariosRegistrados.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvUsuariosRegistrados.CurrentRow.Cells[1].Value.ToString();
            comboRoles.Text = dgvUsuariosRegistrados.CurrentRow.Cells[2].Value.ToString();
            txtUsuario.Text = dgvUsuariosRegistrados.CurrentRow.Cells[3].Value.ToString();
            txtContrasena.Text = dgvUsuariosRegistrados.CurrentRow.Cells[4].Value.ToString();
            txtNumeroDeContacto.Text = dgvUsuariosRegistrados.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = dgvUsuariosRegistrados.CurrentRow.Cells[6].Value.ToString();
            lblfecha.Text = dgvUsuariosRegistrados.CurrentRow.Cells[7].Value.ToString();

        }
    }
}
