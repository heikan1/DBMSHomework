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
    public partial class Passenger : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=odev1; user ID =postgres; password=1234");

        public Passenger()
        {
            InitializeComponent();
            comboBoxBoss_Guncelle();
            comboBoxBoss2_Guncelle();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBoss_Guncelle()
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand("SELECT staffno, name FROM staff inner join person on staff.personno = person.personno;", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = komut;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "staffno";
            comboBox1.DataSource = table1;
            //comboBox1.ValueMember= "table_name.id";
            komut.ExecuteNonQuery();
            conn.Close();
        }
        private void comboBoxBoss2_Guncelle()
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand("SELECT clientno, name FROM client inner join person on client.clientno = person.personno;", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = komut;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "clientno";
            comboBox2.DataSource = table1;
            //comboBox1.ValueMember= "table_name.id";
            komut.ExecuteNonQuery();
            conn.Close();
        }

        private void Passenger_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
