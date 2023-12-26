using Npgsql;
using System.Data;
using System.Xml.Linq;

namespace DBMSHomework
{
    public partial class Form1 : Form
    {

        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=odev1; user ID =postgres; password=1234");
        public Form1()
        {
            InitializeComponent();

            conn.Open();
            /*NpgsqlCommand komut = new NpgsqlCommand("SELECT table_name FROM information_schema.tables WHERE table_schema='public' AND table_type='BASE TABLE'", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            da.SelectCommand= komut;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            comboBox1.DisplayMember= "table_name";
            comboBox1.DataSource= table1;
            //comboBox1.ValueMember= "table_name.id";
            komut.ExecuteNonQuery();
            conn.Close();*/
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboboxýn içeriðine göre olmasýný ayarlamam lazým
            if (comboBox1.SelectedIndex == 0)
            {
                loadform(new Manufacturer());
            }
            else if(comboBox1.SelectedIndex == 1){
                loadform(new AirlineCompany());
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                loadform(new Plane());
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                loadform(new Airport());
            }
            else if(comboBox1.SelectedIndex == 4)
            {
                loadform(new Runway());
            }
            else if(comboBox1.SelectedIndex == 5)
            {
                loadform(new Class());
            }
            else if(comboBox1.SelectedIndex == 6)
            {
                loadform(new Person());
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                loadform(new Luggage());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}