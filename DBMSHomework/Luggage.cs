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
    public partial class Luggage : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=odev1; user ID =postgres; password=1234");
        public Luggage()
        {
            InitializeComponent();
            comboBoxBoss_Guncelle();
        }

        private void Luggage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("insert into luggage(luggageno,passengerno,count) values(@p1,@p2,@p3)", conn);
            comm.Parameters.AddWithValue("@p1", int.Parse(cmpname.Text));
            comm.Parameters.AddWithValue("@p2", comboBox2.SelectedValue);
            comm.Parameters.AddWithValue("@p3", comboBox1.SelectedIndex);
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Eklendi :)");
        }
        private void comboBoxBoss_Guncelle()
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand("SELECT passengerno,name FROM passenger inner join person on passengerno = person.personno;", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = komut;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "passengerno";
            comboBox2.DataSource = table1;
            //comboBox1.ValueMember= "table_name.id";
            komut.ExecuteNonQuery();
            conn.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from luggage";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewCmp.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("delete from luggage where luggageno= @p1", conn);
            comm.Parameters.AddWithValue("@p1", int.Parse(cmpno2.Text));
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Silindi :)");
        }
    }
}
