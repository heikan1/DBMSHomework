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
using System.Xml.Linq;

namespace DBMSHomework
{
    public partial class Airport : Form
    {

        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=odev1; user ID =postgres; password=1234");

        public Airport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("call add_airport (@p1,@p2)", conn);
            comm.Parameters.AddWithValue("@p2", airpname.Text);
            comm.Parameters.AddWithValue("@p1", int.Parse(airpno.Text));
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Eklendi :)");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm;
            if (!string.IsNullOrEmpty(airpno.Text))
            {
                comm = new NpgsqlCommand("Select * from airport where airportno = @p1", conn);
                comm.Parameters.AddWithValue("@p1", int.Parse(airpno.Text));
                comm.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewCmp.DataSource = ds.Tables[0];

            }
            else if (!string.IsNullOrEmpty(airpname.Text))
            {
                comm = new NpgsqlCommand("Select * from airport where airportname like '" + airpname.Text + "%'", conn);
                //MessageBox.Show(mfname.Text);
                //comm.Parameters.AddWithValue("@p1", "'" + mfname.Text +"'%");
                comm.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewCmp.DataSource = ds.Tables[0];
            }
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from airport";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewCmp.DataSource = ds.Tables[0];
        }

        private void dataGridViewCmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("call delete_airport(@p1)", conn);
            command.Parameters.AddWithValue("@p1", int.Parse(airpno2.Text));
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Silindi :)");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //stored procedure create for manufacturer
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("call update_airport (@p1,@p2)", conn);
            comm.Parameters.AddWithValue("@p2", airpname.Text);
            comm.Parameters.AddWithValue("@p1", int.Parse(airpno.Text));
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery(); 
            conn.Close();
            MessageBox.Show("Güncellendi :)");
        }
    }
}
