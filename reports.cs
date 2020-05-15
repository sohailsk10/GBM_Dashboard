using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsDashboardApp
{
    public partial class reports : Form
    {
        public reports()
        {
            InitializeComponent();
            string connetionString = null;
            MySqlConnection cnn;
            MySqlDataReader row;
            MySqlCommand cmd = new MySqlCommand();
            connetionString = "server=localhost;database=dashboard;uid=root;pwd=admin;";
            cnn = new MySqlConnection(connetionString);
            string outputMessage = "";
            try
            {
                cnn.Open();
                string query1 = "select count(*) from violations;";
                cmd = new MySqlCommand(query1, cnn);
                row = cmd.ExecuteReader();
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        //MessageBox.Show(outputMessage);
                        //string rows_of_db = row;
                        //outputMessage += row.GetValue(0).ToString() + "- " + row.GetValue(1).ToString() + "\n";
                        outputMessage += row["violation_name"].ToString();
                        MessageBox.Show(outputMessage);
                    }
                }
                
                //MessageBox.Show("row " + row[0]);
                cnn.Close();
               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }




        ///select count(*) from violations;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

/*
string Connection1 = "";
SqlConnection conn = new SqlConnection(Connection1);
SqlCommand comm = new SqlCommand(query1, conn);
conn.Open();
SqlDataReader reader = comm.ExecuteReader();
string outputMessage = "";

while (reader.Read())
{
	outputMessage += reader.GetValue(0) + "- " + reader.GetValue(1) + "\n";
}

//don't forget to close your reader and connection
reader.Close();
conn.Close();
MessageBox.Show(outputMessage);
*/