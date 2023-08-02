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
    public partial class Reservations : Form
    {
        public string id;
        public Reservations()
        {
            InitializeComponent();
        }
        public Reservations(string id)
        {
            this.id = id;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home(id);
            this.Hide();
            home.ShowDialog();
            this.Close();
        }
        private void Reservations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tESTDataSet2.USER' table. You can move, or remove it, as needed.
            this.uSERTableAdapter.Fill(this.tESTDataSet2.USER);
            DataTable resulttable = PerformJoinOperation();
            dataGridView1.DataSource = resulttable;
        }



        private DataTable PerformJoinOperation()
        {
            DataTable resultTable = new DataTable();
            string connectionString = "workstation id=Flight-system.mssql.somee.com;packet size=4096;user id=AdhamIsHere_SQLLogin_1;pwd=v3itc814el;data source=Flight-system.mssql.somee.com;persist security info=False;initial catalog=Flight-system";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = " SELECT [TICKET].ID AS [TICKET ID],  [TICKET].CLASS, [AIRPORT_FROM].CITY AS [FROM],  [AIRPORT_TO].CITY AS [TO], [FLIGHT].DEPARTURE,  [FLIGHT].ARRIVAL FROM   [TICKET] JOIN   [FLIGHT] ON [TICKET].FLIGHT_ID = [FLIGHT].ID JOIN  [RESERVATION] ON [RESERVATION].TICKET_ID = [TICKET].ID JOIN   [AIRPORT] AS [AIRPORT_FROM] ON [FLIGHT].AIRPORT_SOURCE = [AIRPORT_FROM].ID JOIN  [AIRPORT] AS [AIRPORT_TO] ON [FLIGHT].AIRPORT_DESTINATION = [AIRPORT_TO].ID WHERE   [RESERVATION].USER_ID = @id ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = command.ExecuteReader();
            resultTable.Load(reader);
            reader.Close();
            return resultTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tid.Text))
            {
                MessageBox.Show("Enter Ticket ID to cancel Flight", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connectionString = "workstation id=Flight-system.mssql.somee.com;packet size=4096;user id=AdhamIsHere_SQLLogin_1;pwd=v3itc814el;data source=Flight-system.mssql.somee.com;persist security info=False;initial catalog=Flight-system";
                string query = "DELETE FROM RESERVATION WHERE TICKET_ID=@ID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", Tid.Text);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Flight Cancelled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                query = "DELETE FROM TICKET WHERE ID=@ID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", Tid.Text);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
        }

        private void uSERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tESTDataSet2);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home home = new Home(id);
            this.Hide();
            home.ShowDialog();
            this.Close();
        }
    }
}
