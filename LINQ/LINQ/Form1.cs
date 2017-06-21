using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data;

/* Don't forget to:
   - Create a database named 'csharp' with a table 'students', which contains an id, name and subject in phpMyAdmin.
   - Install the MySql connector .Net
 */
namespace LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Insert Into - query 
        private void insertButton_Click(object sender, EventArgs e)
        {
            // Initialize connection / command
            MySql.Data.MySqlClient.MySqlConnection conn;
            MySql.Data.MySqlClient.MySqlCommand cmd;

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            cmd = new MySql.Data.MySqlClient.MySqlCommand();

            // Set connection / query
            conn.ConnectionString = "server=localhost;uid=root;pwd=;database=csharp;";
            string myquerystring = "INSERT INTO students (name, subject) VALUES('Mark', 'C#')";

            // Check the connection and the query
            try
            {
                // Open the connection and execute command (query)
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = myquerystring;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Row Inserted into database successfully!",
                "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                // Close connection
                conn.Close();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                // Show error
                MessageBox.Show(ex.Message);
            }
        }

        // Update - query 
        private void updateButton_Click(object sender, EventArgs e)
        {
            // Initialize connection / command
            MySql.Data.MySqlClient.MySqlConnection conn;
            MySql.Data.MySqlClient.MySqlCommand cmd;

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            cmd = new MySql.Data.MySqlClient.MySqlCommand();

            // Set connection / query
            conn.ConnectionString = "server=localhost;uid=root;pwd=;database=csharp;";
            string myquerystring = "UPDATE students SET name='John', subject='JAVA' WHERE name='Mark'";

            // Check the connection and the query
            try
            {
                // Open the connection and execute command (query)
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = myquerystring;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Row(s) updated successfully!",
                "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                // Close connection
                conn.Close();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                // Show error
                MessageBox.Show(ex.Message);
            }
        }

        // Delete From - query 
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Initialize connection / command
            MySql.Data.MySqlClient.MySqlConnection conn;
            MySql.Data.MySqlClient.MySqlCommand cmd;

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            cmd = new MySql.Data.MySqlClient.MySqlCommand();

            // Set connection / query
            conn.ConnectionString = "server=localhost;uid=root;pwd=;database=csharp;";
            string myquerystring = "DELETE FROM students WHERE name='John'";

            // Check the connection and the query
            try
            {
                // Open the connection and execute command (query)
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = myquerystring;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Row(s) deleted successfully!",
                "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                // Close connection                
                conn.Close();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                // Show error
                MessageBox.Show(ex.Message);
            }
        }
    }
}
