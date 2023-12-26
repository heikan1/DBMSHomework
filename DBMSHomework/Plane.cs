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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBMSHomework
{
    public partial class Plane : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=odev1; user ID =postgres; password=1234");
        public Plane()
        {
            InitializeComponent();
            comboBoxCmp_Guncelle();
            comboBoxMf_Guncelle();
        }

        private void comboBoxCmp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCmp_Guncelle()
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand("SELECT airlinecompanyno,companyname FROM airlinecompany", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = komut;
            DataTable table1 = new DataTable(); 
            da.Fill(table1);
            comboBoxCmp.DisplayMember = "companyname";
            comboBoxCmp.ValueMember = "airlinecompanyno";
            comboBoxCmp.DataSource = table1;
            //comboBox1.ValueMember= "table_name.id";
            komut.ExecuteNonQuery();
            conn.Close();
        }
        private void comboBoxMf_Guncelle()
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand("SELECT manufacturerno,mfname FROM manufacturer", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand = komut;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            comboBoxMf.DisplayMember = "mfname";
            comboBoxMf.ValueMember = "manufacturerno";
            comboBoxMf.DataSource = table1;
            //MessageBox.Show(comboBoxMf.ValueMember);
            //comboBox1.ValueMember= "table_name.id";
            komut.ExecuteNonQuery();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("call add_plane(@p1,@p2,@p3,@p4,@p5)",conn);
            comm.Parameters.AddWithValue("@p1", int.Parse(planeno.Text));
            comm.Parameters.AddWithValue("@p2", planename.Text);
            comm.Parameters.AddWithValue("@p3", comboBoxCmp.SelectedValue);
            comm.Parameters.AddWithValue("@p4", comboBoxMf.SelectedValue);
            comm.Parameters.AddWithValue("@p5", int.Parse(capacity.Text));
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm;
            if (!string.IsNullOrEmpty(planeno3.Text))
            {
                comm = new NpgsqlCommand("Select * from plane where planeno = @p1", conn);
                comm.Parameters.AddWithValue("@p1", int.Parse(planeno3.Text));
                comm.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewPlane.DataSource = ds.Tables[0];

            }
            else if (!string.IsNullOrEmpty(planemodel3.Text))
            {
                comm = new NpgsqlCommand("Select * from plane where model like '" + planemodel3.Text + "%'", conn);
                //MessageBox.Show(mfname.Text);
                //comm.Parameters.AddWithValue("@p1", "'" + mfname.Text +"'%");
                comm.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewPlane.DataSource = ds.Tables[0];
            }
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from plane";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewPlane.DataSource = ds.Tables[0];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("call update_plane(@p1,@p2,@p3,@p4,@p5)", conn);
            comm.Parameters.AddWithValue("@p1", int.Parse(planeno.Text));
            comm.Parameters.AddWithValue("@p2", planename.Text);
            comm.Parameters.AddWithValue("@p3", comboBoxCmp.SelectedValue);
            comm.Parameters.AddWithValue("@p4", comboBoxMf.SelectedValue);
            comm.Parameters.AddWithValue("@p5", int.Parse(capacity.Text));
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("delete from plane where planeno = @p1", conn);
            comm.Parameters.AddWithValue("@p1", int.Parse(planeno2.Text));
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
        }
    }
}
