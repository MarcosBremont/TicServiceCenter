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
    public partial class FrmInventario : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=TicServiceCenter; user=root; password=1234");

        public FrmInventario()
        {
            InitializeComponent();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            CargarDgvInventario();
        }

        public void CargarDgvInventario()
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter("Select * from Inventario", con);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvInventario.DataSource = tabla;
        }

        private void txtbuscarpornombredelproducto_KeyUp(object sender, KeyEventArgs e)
        {
            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Inventario where NombreProducto like ('" + txtbuscarpornombredelproducto.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            dgvInventario.DataSource = dt;

            con.Close();
        }

        private void txtbuscarporcategoria_KeyUp(object sender, KeyEventArgs e)
        {
            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Inventario where CategoriaProducto like ('" + txtbuscarporcategoria.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            dgvInventario.DataSource = dt;

            con.Close();
        }

        private void txtbuscarporcodigo_KeyUp(object sender, KeyEventArgs e)
        {
            con.Open();

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Inventario where IDInventario like ('" + txtbuscarporcodigo.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            dgvInventario.DataSource = dt;

            con.Close();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            FrmStock frms = new FrmStock();
            frms.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
            {
            if (dgvInventario.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;

                string cmd = "SELECT * FROM Inventario WHERE NombreProducto LIKE ('%" + txtbuscarpornombredelproducto.Text.Trim() + "%')";
                ds = Utilidades.Ejecutar(cmd);
                dgvInventario.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error:" + error.Message);
            }
        }
    }
    
}
