﻿using System;
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
    public partial class PaginaPrincipal : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=TicServiceCenter; user=root; password=1234");

        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }

    }
}
