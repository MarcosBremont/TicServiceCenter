using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicServiceCenter
{
    public partial class eFactura
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=TicServiceCenter; user=root; password=1234");

        public int IDFacturacion { get; set; }
        public int CodigoProducto { get; set; }
        public string NombrePro { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public double importe { get; set; }
    }
}
