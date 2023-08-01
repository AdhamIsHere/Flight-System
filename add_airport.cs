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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Flight_System
{
    public partial class add_airport : Form
    {
        public string id;
        public add_airport(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADHAM;Initial Catalog=TEST;Integrated Security=True";
            string query = "INSERT INTO AIRPORT (NAME,COUNTRY,CITY)VALUES(@NAME,@COUNTRY,@CITY)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NAME",name.Text);
                    command.Parameters.AddWithValue("@COUNTRY", country.Text);
                    command.Parameters.AddWithValue("@CITY", city.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Airport Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void city_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void country_TextChanged(object sender, EventArgs e)
        {

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
