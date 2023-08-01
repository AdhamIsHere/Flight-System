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
    public partial class Report : Form
    {
        string id;
        public Report(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomeAdmin homeAdmin = new HomeAdmin(id);
            this.Hide();
            homeAdmin.ShowDialog();
            this.Close();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADHAM;Initial Catalog=TEST;Integrated Security=True";
            string query = "SELECT source.COUNTRY AS [Source Country], source.CITY AS [Source City], dest.COUNTRY AS [Destination Country], dest.CITY AS [Destination e City],COUNT(*) AS FlightCount FROM Flight JOIN Airport AS source ON Flight.Airport_Source = source.ID JOIN Airport AS dest ON Flight.Airport_Destination = dest.ID GROUP BY dest.COUNTRY, source.COUNTRY,dest.CITY, source.CITY;";            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string connectionString = "Data Source=ADHAM;Initial Catalog=TEST;Integrated Security=True";
                string query = "SELECT source.COUNTRY AS [Source Country], source.CITY AS [Source City],COUNT(*) AS FlightCount FROM Flight JOIN Airport AS source ON Flight.Airport_Source = source.ID  GROUP BY source.COUNTRY, source.CITY;";
                checkBox2.Checked = false;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            else
            {               
                string connectionString = "Data Source=ADHAM;Initial Catalog=TEST;Integrated Security=True";
                string query = "SELECT source.COUNTRY AS [Source Country], source.CITY AS [Source City], dest.COUNTRY AS [Destination Country], dest.CITY AS [Destination e City],COUNT(*) AS FlightCount FROM Flight JOIN Airport AS source ON Flight.Airport_Source = source.ID JOIN Airport AS dest ON Flight.Airport_Destination = dest.ID GROUP BY dest.COUNTRY, source.COUNTRY,dest.CITY, source.CITY;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                string connectionString = "Data Source=ADHAM;Initial Catalog=TEST;Integrated Security=True";
                string query = "SELECT  dest.COUNTRY AS [Destination Country], dest.CITY AS [Destination e City],COUNT(*) AS FlightCount FROM Flight JOIN Airport AS dest ON Flight.Airport_Destination = dest.ID GROUP BY dest.COUNTRY,dest.CITY";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            else
            {
                
                string connectionString = "Data Source=ADHAM;Initial Catalog=TEST;Integrated Security=True";
                string query = "SELECT source.COUNTRY AS [Source Country], source.CITY AS [Source City], dest.COUNTRY AS [Destination Country], dest.CITY AS [Destination e City],COUNT(*) AS FlightCount FROM Flight JOIN Airport AS source ON Flight.Airport_Source = source.ID JOIN Airport AS dest ON Flight.Airport_Destination = dest.ID GROUP BY dest.COUNTRY, source.COUNTRY,dest.CITY, source.CITY;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
    }
}
