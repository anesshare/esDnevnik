using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esDnevnik
{
    public partial class cetvrtoSest : UserControl
    {
        public cetvrtoSest()
        {
            InitializeComponent();
            label2.Text = Globalne.profesor.username;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string konekcija = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\aness\\OneDrive\\Radna površina\\PROJEKAT C#\\esDnevnik\\esDnevnik\\bin\\Debug\\net6.0-windows\\esDnevnikDB.accdb";
            string upit = "SELECT * FROM Student WHERE Class = 'IV/6';";

            using (OleDbConnection connection = new OleDbConnection(konekcija))
            {
                OleDbCommand command = new OleDbCommand(upit, connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    // Handle any errors that occurred during the data retrieval process
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string konekcija = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\aness\\OneDrive\\Radna površina\\PROJEKAT C#\\esDnevnik\\esDnevnik\\bin\\Debug\\net6.0-windows\\esDnevnikDB.accdb";

            try
            {
                if (dataGridView1 == null)
                {
                    MessageBox.Show("dataGridView1 is null or not properly initialized.");
                    return;
                }

                using (OleDbConnection connection = new OleDbConnection(konekcija))
                {
                    connection.Open();

                    List<string> columnNames = new List<string>();
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        columnNames.Add(column.Name);
                    }

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string value1 = row.Cells[columnNames[1]].Value?.ToString();
                        string value2 = row.Cells[columnNames[2]].Value?.ToString();
                        string value3 = row.Cells[columnNames[3]].Value?.ToString();
                        string value4 = row.Cells[columnNames[4]].Value?.ToString();

                        if (value1 == null || value2 == null || value3 == null || value4 == null)
                        {
                            continue;
                        }

                        string upit = $"INSERT INTO Student ([First Name], [Last Name], [Subject], [Grade]) VALUES ('{value1}', '{value2}', '{value3}', '{value4}')";

                        using (OleDbCommand command = new OleDbCommand(upit, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Uspesno ste dodali ucenika!");
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occurred during the data insertion process
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
