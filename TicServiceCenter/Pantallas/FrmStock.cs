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
    public partial class FrmStock : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=TicServiceCenter; user=root; password=1234");

        public FrmStock()
        {
            InitializeComponent();
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            CargarDgvStock();
        }

        public void CargarDgvStock()
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter("Select * from Inventario", con);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvStock.DataSource = tabla;
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidproducto.Text = dgvStock.CurrentRow.Cells[0].Value.ToString();
            txtnombreproducto.Text = dgvStock.CurrentRow.Cells[1].Value.ToString();
            txtCategoria.Text = dgvStock.CurrentRow.Cells[2].Value.ToString();
            txtdescripcion.Text = dgvStock.CurrentRow.Cells[3].Value.ToString();
            txtprecio.Text = dgvStock.CurrentRow.Cells[4].Value.ToString();
            txtcantidad.Text = dgvStock.CurrentRow.Cells[5].Value.ToString();
            dtpfechastock.Text = dgvStock.CurrentRow.Cells[6].Value.ToString();
           
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

            dgvStock.DataSource = dt;

            con.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            
            clear();
            this.txtcantidaddeproductos.Text = this.dgvStock.Rows.Count.ToString("N0");
        }

        public void clear()
        {
            txtidproducto.Text = "";
            txtnombreproducto.Text = "";
            txtCategoria.Text = "";
            txtdescripcion.Text = "";
            txtprecio.Text = "";
            txtcantidad.Text = "";
            dtpfechastock.Text = "";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO Inventario (NombreProducto, CategoriaProducto, Descripcion, Precio, Cantidad, FechaDeAgregado) values (@NombreProducto, @CategoriaProducto, @Descripcion, @Precio, @Cantidad, @FechaDeAgregado)";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@NombreProducto", txtnombreproducto.Text);
            comando.Parameters.AddWithValue("@CategoriaProducto", txtCategoria.Text);
            comando.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text);
            comando.Parameters.AddWithValue("@Precio", txtprecio.Text);
            comando.Parameters.AddWithValue("@Cantidad", txtcantidad.Text);
            comando.Parameters.AddWithValue("@FechaDeAgregado", dtpfechastock.Text);
            comando.ExecuteNonQuery();
            CargarDgvStock();
            MessageBox.Show("Producto Agregado al Stock");
            con.Close();
            clear();
            this.txtcantidaddeproductos.Text = this.dgvStock.Rows.Count.ToString("N0");
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            DialogResult result = MessageBox.Show("¿Estas seguro que quiere eliminar este producto?.", "ATENCION", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Inventario Where IDInventario = @IDInventario";
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.Parameters.AddWithValue("@IDInventario", txtidproducto.Text);
                comando.ExecuteNonQuery();
                CargarDgvStock();
                MessageBox.Show("Producto Eliminado");
                con.Close();
                clear();
            }
            else 
            {

            }
          

           

         
            this.txtcantidaddeproductos.Text = this.dgvStock.Rows.Count.ToString("N0");
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE Inventario SET NombreProducto = @NombreProducto, CategoriaProducto = @CategoriaProducto, Descripcion = @Descripcion, Precio = @Precio, Cantidad = @Cantidad, FechaDeAgregado = @FechaDeAgregado where IDInventario=@IDInventario";
            MySqlCommand comando = new MySqlCommand(query, con);
            comando.Parameters.AddWithValue("@IDInventario", txtidproducto.Text);
            comando.Parameters.AddWithValue("@NombreProducto", txtnombreproducto.Text);
            comando.Parameters.AddWithValue("@CategoriaProducto", txtCategoria.Text);
            comando.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text);
            comando.Parameters.AddWithValue("@Precio", txtprecio.Text);
            comando.Parameters.AddWithValue("@Cantidad", txtcantidad.Text);
            comando.Parameters.AddWithValue("@FechaDeAgregado", dtpfechastock.Text);
            comando.ExecuteNonQuery();
            CargarDgvStock();
            MessageBox.Show("Producto Actualizado");
            con.Close();
            clear();
        }
    }
}
