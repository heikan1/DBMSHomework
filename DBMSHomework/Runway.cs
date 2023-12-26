using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBMSHomework
{
    public partial class Runway : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=odev1; user ID =postgres; password=1234");
        public Runway()
        {
            InitializeComponent();
            comboBoxAirport_Guncelle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from runway";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewCmp.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("Insert into runway(runwayno, airportno) values (@p1,@p2)", conn);
            comm.Parameters.AddWithValue("@p1", int.Parse(runwayno.Text));
            comm.Parameters.AddWithValue("@p2", airport.SelectedValue);
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void cmpname_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAirport_Guncelle()
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand("SELECT airportno,airportname FROM airport", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = komut;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            airport.DisplayMember = "airportname";
            airport.ValueMember = "airportno";
            airport.DataSource = table1;
            //comboBox1.ValueMember= "table_name.id";
            komut.ExecuteNonQuery();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("Delete from runway where runwayno = @p1 ", conn);
            comm.Parameters.AddWithValue("@p1", int.Parse(runwayno2.Text));
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("Update runway set airportno = @p2 where runwayno = @p1", conn);
            comm.Parameters.AddWithValue("@p1", int.Parse(runwayno.Text));
            comm.Parameters.AddWithValue("@p2", airport.SelectedValue);
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm;
            if (!string.IsNullOrEmpty(runwayno.Text))
            {
                comm = new NpgsqlCommand("Select * from runway where runwayno = @p1", conn);
                comm.Parameters.AddWithValue("@p1", int.Parse(runwayno.Text));
                comm.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewCmp.DataSource = ds.Tables[0];

            }
            else if (!string.IsNullOrEmpty(airport.SelectedValue.ToString()))
            {
                ///
                comm = new NpgsqlCommand("Select * from runway where airportno = @p1",conn);
                //MessageBox.Show(mfname.Text);
                comm.Parameters.AddWithValue("@p1", airport.SelectedValue);
                comm.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewCmp.DataSource = ds.Tables[0];
            }
            conn.Close();
        }

        private void airport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
