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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Logbtn_Click(object sender, EventArgs e)
        {
            string connectionString = "workstation id=Flight-system.mssql.somee.com;packet size=4096;user id=AdhamIsHere_SQLLogin_1;pwd=v3itc814el;data source=Flight-system.mssql.somee.com;persist security info=False;initial catalog=Flight-system";
            string query = "SELECT COUNT(*) FROM [USER] WHERE EMAIL = @Email and PASSWORD = @Password";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", Email.Text);
            command.Parameters.AddWithValue("@Password", Password.Text);
            connection.Open();
            int count = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            if (count > 0)
            {
                string adminQuery = "SELECT COUNT(*) FROM [USER] WHERE EMAIL = @Email and PASSWORD = @Password and ADMIN=0";
                SqlCommand adminCommand = new SqlCommand(adminQuery, connection);

                adminCommand.Parameters.AddWithValue("@Email", Email.Text);
                adminCommand.Parameters.AddWithValue("@Password", Password.Text);
                connection.Open();
                int adminCount = Convert.ToInt32(adminCommand.ExecuteScalar());
                string idquery = "SELECT ID FROM [USER] WHERE EMAIL = @Email1 AND PASSWORD = @Password1";
                SqlCommand idcommand = new SqlCommand(idquery, connection);
                idcommand.Parameters.AddWithValue("@Email1", Email.Text);
                idcommand.Parameters.AddWithValue("@Password1", Password.Text);
                object result = idcommand.ExecuteScalar();
                connection.Close();
                string idValue = result.ToString();
                if (adminCount > 0)
                {
                    Home form2 = new Home(idValue);
                    this.Hide();
                    form2.ShowDialog();
                    this.Close();
                }
                else
                {
                    HomeAdmin form3 = new HomeAdmin(idValue);
                    this.Hide();
                    form3.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid Email or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        private void Signbtn_Click(object sender, EventArgs e)
        {
            SignUp form2 = new SignUp();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
// 2023-05-20 10:30:00