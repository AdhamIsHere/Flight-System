using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_System
{
    public partial class buyTicket : Form
    {
        public string id;
        public buyTicket(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void buyTicket_Load(object sender, EventArgs e)
        { 
            DataTable flightData = GetFlightData();
            dataGridView1.DataSource = flightData;
        }
        private DataTable GetFlightData()
        {
            DataTable flightData = new DataTable();

            string connectionString = "Data Source=ADHAM;Initial Catalog=TEST;Integrated Security=True";
            string query = "  SELECT [FLIGHT].ID,  [AIRPORT_FROM].CITY AS [FROM],  [AIRPORT_TO].CITY AS [TO],  [FLIGHT].DEPARTURE,  [FLIGHT].ARRIVAL FROM  [FLIGHT] JOIN [AIRPORT] AS [AIRPORT_FROM] ON [FLIGHT].AIRPORT_SOURCE = [AIRPORT_FROM].ID JOIN  [AIRPORT] AS [AIRPORT_TO] ON [FLIGHT].AIRPORT_DESTINATION = [AIRPORT_TO].ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    flightData.Load(reader);
                    reader.Close();
                }
            }

            return flightData;
        }
        private DataTable GetFiltered()
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Please Select atleast 1 Check box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                list.Clear();
                return GetFlightData();
            }
            else
            {
                DataTable flightData = new DataTable();
                string connectionString = "Data Source=ADHAM;Initial Catalog=TEST;Integrated Security=True";
                string query = "select* from " +
                    "(SELECT [FLIGHT].ID, " +
                    " [AIRPORT_FROM].CITY AS [FROM], " +
                    " [AIRPORT_TO].CITY AS [TO], " +
                    " [FLIGHT].DEPARTURE,  " +
                    "[FLIGHT].ARRIVAL FROM " +
                    " [FLIGHT] " +
                    "JOIN " +
                    "[AIRPORT] AS [AIRPORT_FROM] ON [FLIGHT].AIRPORT_SOURCE = [AIRPORT_FROM].ID " +
                    "JOIN  " +
                    "[AIRPORT] AS [AIRPORT_TO] ON [FLIGHT].AIRPORT_DESTINATION = [AIRPORT_TO].ID) as fly " +
                    "where fly.[FROM]=@S1 or fly.[TO]=@S2 or fly.[ARRIVAL]=@S3 or fly.[DEPARTURE]=@S4";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        if (from.Checked)
                        {
                            command.Parameters.AddWithValue("@S1", search.Text);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@S1", "");
                        }
                        if (to.Checked)
                        {
                            command.Parameters.AddWithValue("@S2", search.Text);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@S2", "");
                        }
                        if (arrive.Checked)
                        {
                            command.Parameters.AddWithValue("@S3", search.Text);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@S3", "");
                        }
                        if (dep.Checked)
                        {
                            command.Parameters.AddWithValue("@S4", search.Text);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@S4", "");
                        }

                        SqlDataReader reader = command.ExecuteReader();
                        flightData.Load(reader);
                        reader.Close();
                    }
                }
                list.Clear();
                return flightData;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home(id);
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADHAM;Initial Catalog=TEST;Integrated Security=True";
            string insertTicketQuery = "INSERT INTO TICKET (FLIGHT_ID, CLASS, PRICE) VALUES (@F, @C, @P)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand insertTicketCommand = new SqlCommand(insertTicketQuery, connection))
                {
                    insertTicketCommand.Parameters.AddWithValue("@F", FLIGHT.Text);
                    insertTicketCommand.Parameters.AddWithValue("@C", CLASS.Text);
                    insertTicketCommand.Parameters.AddWithValue("@P", PRICE.Text);
                    connection.Open();
                    insertTicketCommand.ExecuteNonQuery();
                    connection.Close();
                }
                string selectTicketIdQuery = "SELECT ID FROM TICKET WHERE FLIGHT_ID = @F AND CLASS = @C AND PRICE = @P";
                using (SqlCommand selectTicketIdCommand = new SqlCommand(selectTicketIdQuery, connection))
                {
                    selectTicketIdCommand.Parameters.AddWithValue("@F", FLIGHT.Text);
                    selectTicketIdCommand.Parameters.AddWithValue("@C", CLASS.Text);
                    selectTicketIdCommand.Parameters.AddWithValue("@P", PRICE.Text);
                    connection.Open();
                    object result = selectTicketIdCommand.ExecuteScalar();
                    connection.Close();
                    string idValue = result.ToString();
                    string insertReservationQuery = "INSERT INTO RESERVATION (USER_ID, TICKET_ID) VALUES (@id, @u)";
                    using (SqlCommand insertReservationCommand = new SqlCommand(insertReservationQuery, connection))
                    {
                        insertReservationCommand.Parameters.AddWithValue("@id", id);
                        insertReservationCommand.Parameters.AddWithValue("@u", idValue);
                        connection.Open();
                        insertReservationCommand.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            MessageBox.Show("Ticket added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home(id);
            this.Hide();
            home.ShowDialog();
            this.Close();
        }
        List<string> list = new List<string>();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                DataTable flightData = GetFlightData();
                dataGridView1.DataSource = flightData;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (from.Checked)
            {
                list.Add("FROM");
            }
            if (to.Checked)
            {
                list.Add("TO");
            }
            if (arrive.Checked)
            {
                list.Add("ARRIVAL");
            }
            if (dep.Checked)
            {
                list.Add("DEPARTURE");
            }
            DataTable flightData = GetFiltered();
            dataGridView1.DataSource = flightData;
            
        }
    }
}
