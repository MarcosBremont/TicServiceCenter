using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TicServiceCenter
{
    public partial class FrmLogin : Form
    {
        MySqlCommand cmd;
        MySqlDataReader dr;

        MySqlConnection con = new MySqlConnection("Server=localhost; database=TicServiceCenter; user=root; password=1234");


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        public void Ingresar()
        {
            string Usuario = txtUsuario.Text;
            string Contrasena = txtContraseña.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Usuario where Usuario='" + txtUsuario.Text + "' AND Contrasena='" + txtContraseña.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmFacturacion form = new FrmFacturacion();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos");
            }
            con.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmCambiarContraseña frm = new FrmCambiarContraseña();
            frm.Show();
         
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.White;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.White;
                txtContraseña.UseSystemPasswordChar = false;

            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Ingresar();
            }
        }
    }
}
