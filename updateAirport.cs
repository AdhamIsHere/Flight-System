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
    public partial class updateAirport : Form
    {
        string id;
        public updateAirport(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void updateAirport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tESTDataSet1.AIRPORT' table. You can move, or remove it, as needed.
            this.aIRPORTTableAdapter.Fill(this.tESTDataSet1.AIRPORT);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "workstation id=Flight-system.mssql.somee.com;packet size=4096;user id=AdhamIsHere_SQLLogin_1;pwd=v3itc814el;data source=Flight-system.mssql.somee.com;persist security info=False;initial catalog=Flight-system";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [AIRPORT] WHERE ID = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", iDTextBox.Text);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        nAMETextBox.Text = reader["NAME"].ToString();
                        cOUNTRYTextBox.Text = reader["COUNTRY"].ToString();
                        cITYTextBox.Text = reader["CITY"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Enter Valid Airport ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "workstation id=Flight-system.mssql.somee.com;packet size=4096;user id=AdhamIsHere_SQLLogin_1;pwd=v3itc814el;data source=Flight-system.mssql.somee.com;persist security info=False;initial catalog=Flight-system";
            string query = "UPDATE [AIRPORT] SET NAME=@N, COUNTRY=@CO, CITY =@CIT WHERE ID= @ID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@N", nAMETextBox.Text);
                    command.Parameters.AddWithValue("@CO", cOUNTRYTextBox.Text);
                    command.Parameters.AddWithValue("@CIT", cITYTextBox.Text);
                    command.Parameters.AddWithValue("@ID", iDTextBox.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Airport Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomeAdmin homeAdmin = new HomeAdmin(id);
            this.Hide();
            homeAdmin.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.aIRPORTTableAdapter.Fill(this.tESTDataSet1.AIRPORT);
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
