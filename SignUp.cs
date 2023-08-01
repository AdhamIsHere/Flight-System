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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Flight_System
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADHAM;Initial Catalog=TEST;Integrated Security=True";
            string query = "INSERT INTO [USER] (NAME, COUNTRY, CITY, STREET, EMAIL, PASSWORD, PHONE, ADMIN) VALUES (@name, @country, @city, @street, @email, @pass, @phone, @admin)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name.Text);
                    command.Parameters.AddWithValue("@country", country.Text);
                    command.Parameters.AddWithValue("@city", city.Text);
                    command.Parameters.AddWithValue("@street", street.Text);
                    command.Parameters.AddWithValue("@email", email.Text);
                    command.Parameters.AddWithValue("@pass", pass.Text);
                    command.Parameters.AddWithValue("@phone", phone.Text);
                    bool isChecked = admin.Checked;
                    int value = isChecked ? 1 : 0;
                    command.Parameters.AddWithValue("@admin", value);

                    command.ExecuteNonQuery();

                    string idquery = "SELECT ID FROM [USER] WHERE EMAIL = @Email1 and PASSWORD = @Password1 ";
                    using (SqlCommand idcommand = new SqlCommand(idquery, connection))
                    {
                        idcommand.Parameters.AddWithValue("@Email1", email.Text);
                        idcommand.Parameters.AddWithValue("@Password1", pass.Text);

                        object result = idcommand.ExecuteScalar();

                        string idValue = result.ToString();
                        MessageBox.Show("Sign Up Successful!","Success",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

                        if (isChecked)
                        {
                            HomeAdmin form3 = new HomeAdmin(idValue);
                            this.Hide();
                            form3.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            Home form2 = new Home(idValue);
                            this.Hide();
                            form2.ShowDialog();
                            this.Close();
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1=new Form1();
            this.Hide();  
            form1.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }
    }
}
