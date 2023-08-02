using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Flight_System
{
    public partial class userAcc : Form
    {
        public string id;
        public userAcc(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void uSERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tESTDataSet1);

        }

        private void userAcc_Load(object sender, EventArgs e)
        {
            string connectionString = "workstation id=Flight-system.mssql.somee.com;packet size=4096;user id=AdhamIsHere_SQLLogin_1;pwd=v3itc814el;data source=Flight-system.mssql.somee.com;persist security info=False;initial catalog=Flight-system";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [USER] WHERE ID = @UserId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", id);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        nAMETextBox.Text = reader["NAME"].ToString();
                        cOUNTRYTextBox.Text = reader["COUNTRY"].ToString();
                        cITYTextBox.Text = reader["CITY"].ToString();
                        sTREETTextBox.Text = reader["STREET"].ToString();
                        pASSWORDTextBox.Text = reader["PASSWORD"].ToString();
                        pHONETextBox.Text = reader["PHONE"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }

                    reader.Close();
                    connection.Close();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "workstation id=Flight-system.mssql.somee.com;packet size=4096;user id=AdhamIsHere_SQLLogin_1;pwd=v3itc814el;data source=Flight-system.mssql.somee.com;persist security info=False;initial catalog=Flight-system";
            string query = "UPDATE [USER] SET NAME=@N, COUNTRY=@COU, CITY=@CI, STREET=@ST, PASSWORD=@PASS, PHONE=@PH WHERE ID= @ID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@N", nAMETextBox.Text);
                    command.Parameters.AddWithValue("@COU", cOUNTRYTextBox.Text);
                    command.Parameters.AddWithValue("@CI", cITYTextBox.Text);
                    command.Parameters.AddWithValue("@ST", sTREETTextBox.Text);
                    command.Parameters.AddWithValue("@PASS", pASSWORDTextBox.Text);
                    command.Parameters.AddWithValue("@PH", pHONETextBox.Text);
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Info Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home(id);
            this.Hide();
            home.ShowDialog();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete your account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                List<int> ticketIds = new List<int>();
                string connectionString = "workstation id=Flight-system.mssql.somee.com;packet size=4096;user id=AdhamIsHere_SQLLogin_1;pwd=v3itc814el;data source=Flight-system.mssql.somee.com;persist security info=False;initial catalog=Flight-system";
                string selectQuery = "SELECT TICKET_ID FROM RESERVATION WHERE USER_ID=@id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@id", id);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int ticketId = (int)reader["TICKET_ID"];
                            ticketIds.Add(ticketId);
                        }
                        reader.Close();
                    }
                }
                string deleteQuery = "DELETE FROM RESERVATION WHERE USER_ID=@id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }

                deleteQuery = "DELETE FROM TICKET WHERE ID IN ({0})";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection=connection;
                        connection.Open();
                        string parameterPlaceholders = string.Join(",", ticketIds.Select((_, i) => "@ticketId" + i));
                        command.CommandText = string.Format(deleteQuery, parameterPlaceholders);
                        for (int i = 0; i < ticketIds.Count; i++)
                        {
                            command.Parameters.AddWithValue("@ticketId" + i, ticketIds[i]);
                        }
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Tickets deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("No tickets found to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                deleteQuery = "DELETE FROM [USER] WHERE ID=@id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Account deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Form1 form1 = new Form1();
                        this.Hide();
                        form1.ShowDialog();
                        this.Close();
                    }
                }
            }
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
