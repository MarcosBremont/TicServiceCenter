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
    }
}
