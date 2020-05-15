using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsDashboardApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection cnn;
            MySqlDataReader row;
            MySqlCommand cmd = new MySqlCommand();
            connetionString = "server=localhost;database=dashboard;uid=root;pwd=admin;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {

                    cnn.Open();
                    string query = "select username, password from admin WHERE username ='" + textBox1.Text + "' AND password ='" + textBox2.Text + "'";

                    cmd = new MySqlCommand(query, cnn);
                    row = cmd.ExecuteReader();
                    
                    if (row.HasRows)
                    {
                        this.Hide();
                        MainForm form = new MainForm();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password does not match", "Information");
                    }
                }
                else
                {
                    MessageBox.Show(" Please enter your Username and Password", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
