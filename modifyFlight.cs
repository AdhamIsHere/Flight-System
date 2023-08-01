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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Flight_System
{
    public partial class modifyFlight : Form
    {
        string id;
        public modifyFlight(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void modifyFlight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tESTDataSet2.AIRCRAFT' table. You can move, or remove it, as needed.
            this.aIRCRAFTTableAdapter.Fill(this.tESTDataSet2.AIRCRAFT);
            // TODO: This line of code loads data into the 'tESTDataSet2.AIRPORT' table. You can move, or remove it, as needed.
            this.aIRPORTTableAdapter.Fill(this.tESTDataSet2.AIRPORT);
            // TODO: This line of code loads data into the 'tESTDataSet2.FLIGHT' table. You can move, or remove it, as needed.
            this.fLIGHTTableAdapter.Fill(this.tESTDataSet2.FLIGHT);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            HomeAdmin home = new HomeAdmin(id);
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADHAM;Initial Catalog=TEST;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [FLIGHT] WHERE ID = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", iDTextBox.Text);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        aIRPORT_SOURCETextBox.Text = reader["AIRPORT_SOURCE"].ToString();
                        aIRPORT_DESTINATIONTextBox.Text = reader["AIRPORT_DESTINATION"].ToString();
                        aIRCRAFT_IDTextBox.Text = reader["AIRCRAFT_ID"].ToString();
                        arrive.Text = reader["ARRIVAL"].ToString();
                        departure.Text = reader["DEPARTURE"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Enter Valid Flight ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.fLIGHTTableAdapter.Fill(this.tESTDataSet2.FLIGHT);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADHAM;Initial Catalog=TEST;Integrated Security=True";
            string query = "UPDATE [FLIGHT] SET AIRPORT_SOURCE=@SOUR , AIRPORT_DESTINATION=@DEST, AIRCRAFT_ID=@AID, ARRIVAL=@ARR, DEPARTURE = @DEP  WHERE ID= @ID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", iDTextBox.Text);
                    command.Parameters.AddWithValue("@SOUR", aIRPORT_SOURCETextBox.Text);
                    command.Parameters.AddWithValue("@DEST", aIRPORT_DESTINATIONTextBox.Text);
                    command.Parameters.AddWithValue("@AID", aIRCRAFT_IDTextBox.Text);
                    command.Parameters.AddWithValue("@ARR", arrive.Text);
                    command.Parameters.AddWithValue("@DEP", departure.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Flight Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
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
