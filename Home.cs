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
    public partial class Home : Form
    {
        public string id;
        public Home()
        {
            InitializeComponent();
        }
        public Home(string id)
        {   
            this.id=id;
            InitializeComponent();
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reservations reservations = new Reservations(id);
            this.Hide();
            reservations.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
             
        }

        private void Home_Load(object sender, EventArgs e)
        {
            string connectionString = "workstation id=Flight-system.mssql.somee.com;packet size=4096;user id=AdhamIsHere_SQLLogin_1;pwd=v3itc814el;data source=Flight-system.mssql.somee.com;persist security info=False;initial catalog=Flight-system";
            string queryString = "SELECT Name FROM [USER] WHERE ID = @Id";

            string result ;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();
                    result = command.ExecuteScalar()?.ToString();
                }
            }
            welcome.Text =  result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buyTicket buyTicket = new buyTicket(id);
            this.Hide();
            buyTicket.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            userAcc userAcc = new userAcc(id);
            this.Hide();
            userAcc.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form3 = new Form1();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
