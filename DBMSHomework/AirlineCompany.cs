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
    public partial class AirlineCompany : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=odev1; user ID =postgres; password=1234");
        public AirlineCompany()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("call add_airlinecompany (@p1,@p2)", conn);
            comm.Parameters.AddWithValue("@p2", cmpname.Text);
            comm.Parameters.AddWithValue("@p1", int.Parse(cmpno.Text));
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Eklendi :)");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm;
            if (!string.IsNullOrEmpty(cmpno.Text))
            {
                comm = new NpgsqlCommand("Select * from airlinecompany where airlinecompanyno = @p1", conn);
                comm.Parameters.AddWithValue("@p1", int.Parse(cmpno.Text));
                comm.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewCmp.DataSource = ds.Tables[0];

            }
            else if (!string.IsNullOrEmpty(cmpname.Text))
            {
                comm = new NpgsqlCommand("Select * from airlinecompany where companyname like '" + cmpname.Text + "%'", conn);
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

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("delete from airlinecompany where airlinecompanyno = @p1", conn);
            comm.Parameters.AddWithValue("@p1", int.Parse(cmpno2.Text));
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Silindi :)");

        }

        private void button5_Click(object sender, EventArgs e)
        {

            string sorgu = "select * from airlinecompany";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewCmp.DataSource = ds.Tables[0];

        }

        private void cmpno_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("Update airlinecompany set companyname = @p2 where airlinecompanyno = @p1", conn);
            comm.Parameters.AddWithValue("@p1", int.Parse(cmpno.Text));
            comm.Parameters.AddWithValue("@p2", cmpname.Text);
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Güncellendi :)");
        }
    }
}
