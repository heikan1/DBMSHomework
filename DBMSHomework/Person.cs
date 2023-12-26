using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DBMSHomework
{
    public partial class Person : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=odev1; user ID =postgres; password=1234");
        Staff Stf = new Staff();
        Pilot Plt = new Pilot();
        Hostess Hsts = new Hostess();  
        Client Clt = new Client();
        Passenger pssg = new Passenger();

        public Person()
        {
            InitializeComponent();
            comboBoxListele.SelectedIndex = 0;
            
        }

        public void loadform(object Form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            f.Show();
        }
        public void staffEkle()
        {
            personOlustur();
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("insert into staff(staffno,maas, bossno,personno) values(@p1,@p2,@p3,@p4)", conn);
            comm.Parameters.AddWithValue("@p1", int.Parse(Stf.staffno.Text));
            comm.Parameters.AddWithValue("@p2", int.Parse(Stf.staffmaas.Text));
            comm.Parameters.AddWithValue("@p3", Stf.staffboss.SelectedValue); //
            comm.Parameters.AddWithValue("@p4", int.Parse(personno.Text));
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Eklendi :)");
        }
        public void staffGuncelle()
        {
            //kontrol eklersin, staff numarasını değiştirmiyo
            PersonGuncelle();
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("update staff set maas = @p2, bossno = @p3 where personno = @p1 ", conn);
            comm.Parameters.AddWithValue("@p1", int.Parse(personno.Text));
            comm.Parameters.AddWithValue("@p2", int.Parse(Stf.staffmaas.Text));
            comm.Parameters.AddWithValue("@p3", Stf.staffboss.SelectedValue); 
            //comm.Parameters.AddWithValue("@p4", int.Parse(personno.Text));
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Eklendi :)");
        }
        public void PersonGuncelle()
        {
            if (!string.IsNullOrEmpty(personname.Text) && !string.IsNullOrEmpty(personno.Text))
            {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("update person set name = @p2 where personno = @p1", conn);
            comm.Parameters.AddWithValue("@p1", int.Parse(personno.Text));
            comm.Parameters.AddWithValue("@p2", personname.Text);
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
            }
        }
        public void staffOlustur(int no, int maas, object bno)
        {
            //personOlustur();
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("insert into staff(staffno,maas, bossno,personno) values(@p1,@p2,@p3,@p4)", conn);
            comm.Parameters.AddWithValue("@p1", no);
            comm.Parameters.AddWithValue("@p2", maas);
            comm.Parameters.AddWithValue("@p3", bno); //
            comm.Parameters.AddWithValue("@p4", int.Parse(personno.Text));
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Eklendi :)");
        }
        public void staffGuncellePar(int no, int maas, object bno)
        {
            //kontrol eklersin, staff numarasını değiştirmiyo
            PersonGuncelle();
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("update staff set maas = @p2, bossno = @p3 where personno = @p1 ", conn);
            comm.Parameters.AddWithValue("@p1",no);
            comm.Parameters.AddWithValue("@p2",maas);
            comm.Parameters.AddWithValue("@p3", bno);
            //comm.Parameters.AddWithValue("@p4", int.Parse(personno.Text));
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Eklendi :)");
        }
        public void PilotEkle()
        {
            personOlustur();
            staffOlustur(int.Parse(Plt.staffno.Text), int.Parse(Plt.staffno.Text), Plt.staffboss.SelectedValue);
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("insert into pilot(pilotno,pilottype) values(@p1,@p2)", conn);
            comm.Parameters.AddWithValue("@p1", int.Parse(Plt.staffno.Text));
            comm.Parameters.AddWithValue("@p2", Plt.pilottype.SelectedIndex+1);
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Eklendi :)");
        }
        public void PilotGuncelle()
        {
            PersonGuncelle();
            staffGuncellePar(int.Parse(Plt.staffno.Text), int.Parse(Plt.staffmaas.Text), Plt.staffboss.SelectedValue);
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("update pilot set pilottype =@p2 where pilotno = @p1 ", conn);
            comm.Parameters.AddWithValue("@p1", int.Parse(Plt.staffno.Text));
            comm.Parameters.AddWithValue("@p2", Plt.pilottype.SelectedIndex + 1);
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Eklendi :)");
        } 



        public void HostessEkle()
        {
            personOlustur();
            staffOlustur(int.Parse(Hsts.staffno.Text), int.Parse(Hsts.staffno.Text), Hsts.staffboss.SelectedValue);
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("insert into hostess(hostessno,boy) values(@p1,@p2)", conn);
            comm.Parameters.AddWithValue("@p1", int.Parse(Hsts.staffno.Text));
            comm.Parameters.AddWithValue("@p2", int.Parse(Hsts.boy.Text));
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Eklendi :)");

        }


        public void personOlustur()
        {
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("insert into person(personno,name) values(@p1,@p2)", conn);
            comm.Parameters.AddWithValue("@p1", int.Parse(personno.Text));
            comm.Parameters.AddWithValue("@p2", personname.Text);
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();
        }

        public void ClientEkle()
        {
            personOlustur();
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("insert into client(clientno,vergino) values(@p1,@p2)", conn);
            comm.Parameters.AddWithValue("@p1", int.Parse(personno.Text));
            comm.Parameters.AddWithValue("@p2", int.Parse(Clt.vergino.Text));
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();

        }
        public void PassengerEkle()
        {
            personOlustur();
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand("insert into passenger(passengerno,clientno,relatedemployee) values(@p1,@p2,@p3)", conn);
            comm.Parameters.AddWithValue("@p1", int.Parse(personno.Text));
            comm.Parameters.AddWithValue("@p2",pssg.comboBox2.SelectedValue);
            comm.Parameters.AddWithValue("@p3", pssg.comboBox1.SelectedValue );
            comm.CommandType = CommandType.Text;
            comm.ExecuteNonQuery();
            conn.Close();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 4)
            {
                loadform(Stf);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                loadform(Plt);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                loadform(Hsts);
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                loadform(Clt);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                loadform(pssg);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 4)
            {
                staffEkle();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                PilotEkle();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                HostessEkle();
            }
            if (comboBox1.SelectedIndex == 0)
            {
                ClientEkle();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                PassengerEkle();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sorgu = "";
            if (comboBoxListele.SelectedIndex == 0)
            {
               sorgu = "select * from person";
            }
            else if (comboBoxListele.SelectedIndex == 1)
            {
                sorgu = "select * from client";
            }
            else if (comboBoxListele.SelectedIndex == 2)
            {
                sorgu = "select * from passenger";
            }
            else if (comboBoxListele.SelectedIndex == 3)
            {
                sorgu = "select * from staff";
            }
            else if (comboBoxListele.SelectedIndex == 4)
            {
                sorgu = "select * from pilot";
            }
            else if (comboBoxListele.SelectedIndex == 5)
            {
                sorgu = "select * from hostess";
            }
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewPerson.DataSource = ds.Tables[0];
            conn.Close();

        }

        private void comboBoxListele_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 4)
            {
                staffGuncelle();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                PilotGuncelle();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                //HostessGuncelle();
            }
        }
    }
}
