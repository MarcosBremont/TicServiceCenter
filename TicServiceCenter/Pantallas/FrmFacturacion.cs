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
using System.Drawing.Printing;

namespace TicServiceCenter
{
    public partial class FrmFacturacion : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=TicServiceCenter; user=root; password=1234");
        string imagen = "anadir.png";
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
            this.Close();
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
            if (string.IsNullOrEmpty(txtbuscarproducto.Text))
            {
                FrmInventario FrmI = new FrmInventario();
                FrmI.ShowDialog();

                if (FrmI.DialogResult == DialogResult.OK)
                {
                    txtCodigoPro.Text = FrmI.dgvInventario.Rows[FrmI.dgvInventario.CurrentRow.Index].Cells[0].Value.ToString();
                    txtDescrip.Text = FrmI.dgvInventario.Rows[FrmI.dgvInventario.CurrentRow.Index].Cells[1].Value.ToString();
                    txtPrecio.Text = FrmI.dgvInventario.Rows[FrmI.dgvInventario.CurrentRow.Index].Cells[4].Value.ToString();
                    txtCantidad.Focus();
                    con.Close();
                }
                this.txtcantidaddeproductos.Text = this.dgvFacturacion.Rows.Count.ToString("N0");

            }

            else
            {
                MySqlCommand cmd = new MySqlCommand(" SELECT * FROM Inventario where IDInventario = @IDInventario", con);
                cmd.Parameters.AddWithValue("IDInventario", txtbuscarproducto.Text);

                con.Open();
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    txtCodigoPro.Text = registro["IDInventario"].ToString();
                    txtDescrip.Text = registro["NombreProducto"].ToString();
                    txtPrecio.Text = registro["Precio"].ToString();
                    txtCantidad.Focus();

                }
                con.Close();

            }

        }

        public static int cont_fila = 0;
        public static double total;

        private void BtnColocar_Click(object sender, EventArgs e)
        {

            bool existe = false;
            int num_fila = 0;
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Debe introducir una cantidad del producto seleccionado");

                return;
            }
            else
            {
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
                txtTotal.Text = "RD$" + total.ToString();
                txtSeleccionarCLiente.Focus();
                this.txtcantidaddeproductos.Text = this.dgvFacturacion.Rows.Count.ToString("N0");


            }
        }



        public void NuevaFactura()
        {
            txtCodigoPro.Text = "";
            txtSeleccionarCLiente.Text = "";
            txtCodigoPro.Text = "";
            txtDescrip.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtTotal.Text = "$";
            dgvFacturacion.Rows.Clear();
            cont_fila = 0;
            total = 0;
            txtcantidaddeproductos.Text = "";
            txtCodigoPro.Focus();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSeleccionarCLiente.Text))
            {

                FrmCliente FrmC = new FrmCliente();
                FrmC.ShowDialog();

                if (FrmC.DialogResult == DialogResult.OK)
                {
                    txtSeleccionarCLiente.Text = FrmC.dgvCliente.Rows[FrmC.dgvCliente.CurrentRow.Index].Cells[1].Value.ToString();
                    con.Close();
                }
            }

            else
            {
                MySqlCommand cmd = new MySqlCommand(" SELECT * FROM cliente where IDCliente = @IDCliente", con);
                cmd.Parameters.AddWithValue("IDCliente", txtSeleccionarCLiente.Text);
                con.Open();
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    txtSeleccionarCLiente.Text = registro["NombreCompleto"].ToString();
                    txtclienteTemporal.Focus();

                }
                con.Close();
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNueva_Click(object sender, EventArgs e)
        {
            NuevaFactura();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                total = total - (Convert.ToDouble(dgvFacturacion.Rows[dgvFacturacion.CurrentRow.Index].Cells[4].Value));
                txtTotal.Text = "RD$" + total.ToString();

                dgvFacturacion.Rows.RemoveAt(dgvFacturacion.CurrentRow.Index);
                cont_fila--;
                this.txtcantidaddeproductos.Text = this.dgvFacturacion.Rows.Count.ToString("N0");

            }
        }

       
        private void btneliminar_Click(object sender, EventArgs e)
        {
            
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FrmReporte FrmR = new FrmReporte();
            FrmR.Show();
            string s = "SELECT * FROM facturacion";
            MySqlCommand cmd = new MySqlCommand(s, con);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds, "facturacion");
            Reportes.CrystalReport1 cr1 = new Reportes.CrystalReport1();
            cr1.SetDataSource(ds);
            FrmR.crystalReportViewer1.ReportSource = cr1;
            FrmR.crystalReportViewer1.Refresh();
            con.Close();
        }
          
    }
}
