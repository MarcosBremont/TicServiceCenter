using MySql.Data.MySqlClient;
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
    public partial class FrmCliente : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=TicServiceCenter; user=root; password=1234");
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtNombreCompleto.Clear();
            txtCiudad.Clear();
            txtCodigoPostal.Clear();
            txtCorreoElectronico.Clear();
            txtDireccion.Clear();
            txtIDCliente.Clear();
            txtNoCelular.Clear();
            txtNotas.Clear();
            txtReferencia.Clear();
            txtTelefono.Clear();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO Cliente (NombreCompleto, Direccion, Referencia, Ciudad, Provincia, CodigoPostal, TELEFONO, CorreoElectronico, NCelular, Notas) values (@NombreCompleto, @Direccion, @Referencia, @Ciudad, @Provincia, @CodigoPostal, @TELEFONO, @CorreoElectronico, @NCelular, @Notas)";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@NombreCompleto", txtNombreCompleto.Text);
            comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
            comando.Parameters.AddWithValue("@Referencia", txtReferencia.Text);
            comando.Parameters.AddWithValue("@Ciudad", txtCiudad.Text);
            comando.Parameters.AddWithValue("@Provincia", cmbprovincia.Text);
            comando.Parameters.AddWithValue("@CodigoPostal", txtCodigoPostal.Text);
            comando.Parameters.AddWithValue("@TELEFONO", txtTelefono.Text);
            comando.Parameters.AddWithValue("@CorreoElectronico", txtCorreoElectronico.Text);
            comando.Parameters.AddWithValue("@NCelular", txtNoCelular.Text);
            comando.Parameters.AddWithValue("@Notas", txtNotas.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Cliente Agregado");
            con.Close();
            Clear();
          
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CARGARCOMBOBOXPROVINCIA();
        }

        public void CARGARCOMBOBOXPROVINCIA()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM provincias", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbprovincia.ValueMember = "IDProvincias";
            cmbprovincia.DisplayMember = "NombreProvincias";
            cmbprovincia.DataSource = dt;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE cliente SET NombreCompleto = @NombreCompleto, Direccion = @Direccion, Referencia = @Referencia, Ciudad = @Ciudad, Provincia = @Provincia, CodigoPostal = @CodigoPostal,  TELEFONO = @TELEFONO, CorreoElectronico = @CorreoElectronico, NCelular = @NCelular, Notas = @Notas  where IDCliente=@IDCliente";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@IDCliente", txtIDCliente.Text);
            comando.Parameters.AddWithValue("@NombreCompleto", txtNombreCompleto.Text);
            comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
            comando.Parameters.AddWithValue("@Referencia", txtReferencia.Text);
            comando.Parameters.AddWithValue("@Ciudad", txtCiudad.Text);
            comando.Parameters.AddWithValue("@Provincia", cmbprovincia.Text);
            comando.Parameters.AddWithValue("@CodigoPostal", txtCodigoPostal.Text);
            comando.Parameters.AddWithValue("@TELEFONO", txtTelefono.Text);
            comando.Parameters.AddWithValue("@CorreoElectronico", txtCorreoElectronico.Text);
            comando.Parameters.AddWithValue("@NCelular", txtNoCelular.Text);
            comando.Parameters.AddWithValue("@Notas", txtNotas.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Cliente Actualizado");
            con.Close();
            Clear();
        }
    }
}
