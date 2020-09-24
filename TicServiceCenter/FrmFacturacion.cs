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
    public partial class FrmFacturacion : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=TicServiceCenter; user=root; password=1234");

        public FrmFacturacion()
        {
            InitializeComponent();
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            this.txtcantidaddeproductos.Text = this.dgvFacturacion.Rows.Count.ToString("N0");

        }

        public void CargarDgvFacturacion()
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter("Select * from Facturacion", con);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvFacturacion.DataSource = tabla;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void verYEditarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInventario FrmI = new FrmInventario();
            FrmI.Show();
        }

        private void editarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStock FrmS = new FrmStock();
            FrmS.Show();
        }

        private void editarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria FrmC = new FrmCategoria();
            FrmC.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe FrmAc = new FrmAcercaDe();
            FrmAc.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente FrmC = new FrmCliente();
            FrmC.Show();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin Frml = new FrmLogin();
            Frml.Show();
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroDeUsuario FrmR = new FrmRegistroDeUsuario();
            FrmR.Show();

        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistorial FrmH = new FrmHistorial();
            FrmH.Show();

        }

        private void BtnBuscarProductos_Click(object sender, EventArgs e)
        {
            FrmInventario FrmI = new FrmInventario();
            FrmI.ShowDialog();

            if (FrmI.DialogResult == DialogResult.OK)
            {
                txtCodigoPro.Text = FrmI.dgvInventario.Rows[FrmI.dgvInventario.CurrentRow.Index].Cells[0].Value.ToString();
                txtDescrip.Text = FrmI.dgvInventario.Rows[FrmI.dgvInventario.CurrentRow.Index].Cells[1].Value.ToString();
                txtPrecio.Text = FrmI.dgvInventario.Rows[FrmI.dgvInventario.CurrentRow.Index].Cells[4].Value.ToString();
                txtCantidad.Focus();
            }
            this.txtcantidaddeproductos.Text = this.dgvFacturacion.Rows.Count.ToString("N0");

        }

        public static int cont_fila = 0;
        public static double total;
        private void BtnColocar_Click(object sender, EventArgs e)
        {

            bool existe = false;
            int num_fila = 0;

            if (cont_fila == 0)
            {
                dgvFacturacion.Rows.Add(txtCodigoPro.Text, txtDescrip.Text, txtPrecio.Text, txtCantidad.Text);
                double importe = Convert.ToDouble(dgvFacturacion.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dgvFacturacion.Rows[cont_fila].Cells[3].Value);
                dgvFacturacion.Rows[cont_fila].Cells[4].Value = importe;
                cont_fila++;
            }
            else
            {
                foreach (DataGridViewRow Fila in dgvFacturacion.Rows)
                {
                    if (Fila.Cells[0].Value.ToString() == txtCodigoPro.Text)
                    {
                        existe = true;
                        num_fila = Fila.Index;
                    }
                }
                if (existe == true)
                {
                    dgvFacturacion.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dgvFacturacion.Rows[num_fila].Cells[3].Value)).ToString();
                    double importe = Convert.ToDouble(dgvFacturacion.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dgvFacturacion.Rows[num_fila].Cells[3].Value);
                    dgvFacturacion.Rows[num_fila].Cells[4].Value = importe;
                }
                else
                {
                    dgvFacturacion.Rows.Add(txtCodigoPro.Text, txtDescrip.Text, txtPrecio.Text, txtCantidad.Text);
                    double importe = Convert.ToDouble(dgvFacturacion.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dgvFacturacion.Rows[cont_fila].Cells[3].Value);
                    dgvFacturacion.Rows[cont_fila].Cells[4].Value = importe;
                    cont_fila++;
                }
            }
            total = 0;
            foreach (DataGridViewRow Fila in dgvFacturacion.Rows)
            {
                total += Convert.ToDouble(Fila.Cells[4].Value);
            }
            txtTotal.Text = "$" + total.ToString();

            this.txtcantidaddeproductos.Text = this.dgvFacturacion.Rows.Count.ToString("N0");



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmCliente FrmC = new FrmCliente();
            FrmC.ShowDialog();

            if (FrmC.DialogResult == DialogResult.OK)
            {
                txtSeleccionarCLiente.Text = FrmC.dgvCliente.Rows[FrmC.dgvCliente.CurrentRow.Index].Cells[1].Value.ToString();
              
            }

        }
    }
}
