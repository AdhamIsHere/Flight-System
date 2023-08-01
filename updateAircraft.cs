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

namespace Flight_System
{
    public partial class updateAircraft : Form
    {
        string id;
        public updateAircraft(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void updateAircraft_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tESTDataSet1.AIRCRAFT' table. You can move, or remove it, as needed.
            this.aIRCRAFTTableAdapter.Fill(this.tESTDataSet1.AIRCRAFT);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeAdmin homeAdmin = new HomeAdmin(id);
            this.Hide();
            homeAdmin.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADHAM;Initial Catalog=TEST;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [AIRCRAFT] WHERE ID = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", iDTextBox.Text);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        mODELTextBox.Text = reader["MODEL"].ToString();
                        tYPETextBox.Text = reader["TYPE"].ToString();
                        cAPACITYTextBox.Text = reader["CAPACITY"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Enter Valid Aircraft ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADHAM;Initial Catalog=TEST;Integrated Security=True";
            string query = "UPDATE [AIRCRAFT] SET TYPE=@T, MODEL=@M, CAPACITY =@C WHERE ID= @ID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@T", tYPETextBox.Text);
                    command.Parameters.AddWithValue("@M", mODELTextBox.Text);
                    command.Parameters.AddWithValue("@C", cAPACITYTextBox.Text);
                    command.Parameters.AddWithValue("@ID", iDTextBox.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Aircraft Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.aIRCRAFTTableAdapter.Fill(this.tESTDataSet1.AIRCRAFT);
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