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
    public partial class HomeAdmin : Form
    {
        public string id;
        public HomeAdmin(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADHAM;Initial Catalog=TEST;Integrated Security=True";
            string queryString = "SELECT Name FROM [USER] WHERE ID = @Id";

            string result;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();
                    result = command.ExecuteScalar()?.ToString();
                }
            }
            welcome.Text =result;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            add_airport add = new add_airport(id);
            this.Hide();
            add.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_aircraft add = new add_aircraft(id);
            this.Hide();
            add.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add_flight add = new add_flight(id);
            this.Hide();
            add.ShowDialog();

            ;
        }

       

        private void button7_Click(object sender, EventArgs e)
        {
            updateAirport updateairport=new updateAirport(id);
            this.Hide();
            updateairport.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            updateAircraft updateaircraft = new updateAircraft(id);
            this.Hide();
            updateaircraft.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            modifyFlight modify = new modifyFlight(id);
            this.Hide();
            modify.ShowDialog();    
            this.Close();
        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form3 = new Form1();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            adminAcc adminAcc = new adminAcc(id);
            this.Hide();
            adminAcc.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report report=new Report(id);
            this.Hide();
            report.ShowDialog();
            this.Close();
        }
    }
}
