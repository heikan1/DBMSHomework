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
    public partial class Pilot : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=odev1; user ID =postgres; password=1234");

        public Pilot()
        {
            InitializeComponent();
            comboBoxBoss_Guncelle();
            pilottype.SelectedIndex = 0;
        }

        private void staffboss_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBoxBoss_Guncelle()
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand("SELECT staffno,name FROM staff inner join person on staff.personno = person.personno;", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = komut;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            staffboss.DisplayMember = "name";
            staffboss.ValueMember = "staffno";
            staffboss.DataSource = table1;
            //comboBox1.ValueMember= "table_name.id";
            komut.ExecuteNonQuery();
            conn.Close();
        }

        private void pilottype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pilot_Load(object sender, EventArgs e)
        {

        }
    }
}
