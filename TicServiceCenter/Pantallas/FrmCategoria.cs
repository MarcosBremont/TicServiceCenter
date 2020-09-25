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
    public partial class FrmCategoria : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=TicServiceCenter; user=root; password=1234");
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCategoria.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO categoria (NombreCategoria) values (@NombreCategoria)";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@NombreCategoria", txtCategoria.Text);
            comando.ExecuteNonQuery();
            CARGARCOMBOBOXCATEGORIA();
            MessageBox.Show("Categoria Agregada");
            con.Close();
            txtCategoria.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            DialogResult result = MessageBox.Show("¿Estas seguro que quiere eliminar esta Categoria?", "ATENCION", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM categoria Where IDCategoria = @IDCategoria";
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.Parameters.AddWithValue("@IDCategoria", CMBCategorias.SelectedValue);
                comando.ExecuteNonQuery();
                CARGARCOMBOBOXCATEGORIA();
                MessageBox.Show("Categoria Eliminada");
                con.Close();
                txtCategoria.Clear();
            }
            else
            {

            }
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CARGARCOMBOBOXCATEGORIA();
        }

        public void CARGARCOMBOBOXCATEGORIA()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM categoria", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CMBCategorias.ValueMember = "IDCategoria";
            CMBCategorias.DisplayMember = "NombreCategoria";
            CMBCategorias.DataSource = dt;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE categoria SET NombreCategoria = @NombreCategoria where IDCategoria=@IDCategoria";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@IDCategoria", lblidcategoria.Text);
            comando.Parameters.AddWithValue("@NombreCategoria", txtCategoria.Text);
            comando.ExecuteNonQuery();
            CARGARCOMBOBOXCATEGORIA();
            MessageBox.Show("Categoria Actualizada");
            con.Close();
            txtCategoria.Clear();
        }

        private void CMBCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblidcategoria.Text = Convert.ToString(CMBCategorias.SelectedValue);
   
        }
    }
}
