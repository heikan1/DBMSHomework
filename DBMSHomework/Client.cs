using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSHomework
{
    public partial class Client : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=odev1; user ID =postgres; password=1234");

        public Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Client_Load(object sender, EventArgs e)
        {

        }
    }
}
