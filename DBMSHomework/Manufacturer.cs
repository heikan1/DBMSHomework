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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBMSHomework
{
    public partial class Manufacturer : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=odev1; user ID =postgres; password=1234");
        public Manufacturer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //stored procedure delete for manufacturer
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("call delete_manufacturer(@p1)", conn);
            command.Parameters.AddWithValue("@p1", int.Parse(mfno2.Text));
            command.CommandType= CommandType.Text;
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Silindi :)");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open(); 
            NpgsqlCommand comm;
            if (!string.IsNullOrEmpty(mfno.Text))
            {
                comm = new NpgsqlCommand("Select * from manufacturer where manufacturerno = @p1", conn);
                comm.Parameters.AddWithValue("@p1", int.Parse(mfno.Text));
                comm.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            
            }
            else if (!string.IsNullOrEmpty(mfname.Text))
            {
                comm = new NpgsqlCommand("Select * from manufacturer where mfname like '" + mfname.Text +"%'", conn);
                //MessageBox.Show(mfname.Text);
                //comm.Parameters.AddWithValue("@p1", "'" + mfname.Text +"'%");
                comm.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //stored procedure create for manufacturer
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("call add_manufacturer (@p1,@p2)", conn);
            comm.Parameters.AddWithValue("@p2", mfname.Text);
            comm.Parameters.AddWithValue("@p1", int.Parse(mfno.Text));
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Eklendi :)");
        }

        private void mfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mfno_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //stored procedure create for manufacturer
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("call update_manufacturer (@p1,@p2)", conn);
            comm.Parameters.AddWithValue("@p2", mfname.Text);
            comm.Parameters.AddWithValue("@p1", int.Parse(mfno.Text));
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Güncellendi :)");
        }

        private void mfno2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from manufacturer";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
