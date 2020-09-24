using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicServiceCenter
{
    public class Utilidades
    {

        public static DataSet Ejecutar(string cmd)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost; database=TicServiceCenter; user=root; password=1234");
            con.Open();

            DataSet DS = new DataSet();
            MySqlDataAdapter DP = new MySqlDataAdapter(cmd, con);

            DP.Fill(DS);

            con.Close();

            return DS;
        }

        
    }
}
