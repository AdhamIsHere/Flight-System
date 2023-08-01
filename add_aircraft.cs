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
    public partial class add_aircraft : Form
    {
        public string id;
        public add_aircraft(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADHAM;Initial Catalog=TEST;Integrated Security=True";
            string query = "INSERT INTO AIRCRAFT (TYPE,MODEL,CAPACITY)VALUES(@T,@M,@C)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@T", Type.Text);
                    command.Parameters.AddWithValue("@M", Model.Text);
                    command.Parameters.AddWithValue("@C", Capacity.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Aircraft Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
