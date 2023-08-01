using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Flight_System
{
    public partial class add_flight : Form
    {
        public string id; 
        public add_flight(string id)
        {   
            this.id = id;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void add_flight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tESTDataSet1.AIRCRAFT' table. You can move, or remove it, as needed.
            this.aIRCRAFTTableAdapter.Fill(this.tESTDataSet1.AIRCRAFT);
            // TODO: This line of code loads data into the 'tESTDataSet1.AIRPORT' table. You can move, or remove it, as needed.
            this.aIRPORTTableAdapter.Fill(this.tESTDataSet1.AIRPORT);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADHAM;Initial Catalog=TEST;Integrated Security=True";
            string query = "INSERT INTO FLIGHT (AIRPORT_SOURCE,AIRPORT_DESTINATION,AIRCRAFT_ID,ARRIVAL,DEPARTURE)VALUES(@SOURCE,@DEST,@CRAFT,@ARRIVE,@DEP)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SOURCE", Source.Text);
                    command.Parameters.AddWithValue("@DEST", Dest.Text);
                    command.Parameters.AddWithValue("@CRAFT", craft.Text);
                    command.Parameters.AddWithValue("@ARRIVE", Arrive.Text);
                    command.Parameters.AddWithValue("@DEP", dep.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Flight Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeAdmin homeAdmin = new HomeAdmin(id);
            this.Hide();
            homeAdmin.ShowDialog();
            this.Close();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HomeAdmin home = new HomeAdmin(id);
            this.Hide();
            home.ShowDialog();
            this.Close();
        }
    }
}
