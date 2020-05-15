using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace WindowsDashboardApp
{
    public partial class UseCases_1 : DevExpress.XtraEditors.XtraForm
    {
        public UseCases_1()
        {
            InitializeComponent();
        }

        private void UseCases_1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            label1.Text = UseCases_Form.UseCases;
            label1.Font = new System.Drawing.Font("Tahoma", 20F);

            var id = "";
            string connetionString = "server=localhost;database=dashboard;uid=root;pwd=admin;";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlDataReader row;
            MySqlDataReader row2;
            MySqlCommand cmd = new MySqlCommand();
            MySqlCommand cmd1 = new MySqlCommand();
            cnn.Open();

            string query_config_type = "SELECT ID FROM configuration_type_tbl WHERE configuration_description_fld = '" + label1.Text + "';";
            //MessageBox.Show(query_config_type);
            cmd1 = new MySqlCommand(query_config_type, cnn);
            row = cmd1.ExecuteReader();

            while (row.Read())
            {
                id = row["ID"].ToString();
            }
            row.Close();

            string query = "SELECT * FROM configuration_tbl WHERE config_type_id = " + id + ";";
            cmd = new MySqlCommand(query, cnn);
            row2 = cmd.ExecuteReader();
            List<string> desc = new List<string>();

            while (row2.Read())
            {
                string desc_from_db = row2["configuaration_description_fld"].ToString();
                desc.Add(desc_from_db);
            }
            row2.Close();

            SimpleButton[] simple_btns = new SimpleButton[desc.Count];
            //flowLayout_sidepanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            //this.flowLayout_sidepanel.Controls.Add(this.simpleButton3);
            //this.flowLayout_sidepanel.Controls.Add(this.simpleButton4);

            flowLayout_sidePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;

            for (int j = 0; j < desc.Count; j++)
            {
                simple_btns[j] = new SimpleButton();
                simple_btns[j].Location = new Point(0, 0);
                simple_btns[j].Name = desc[j];
                simple_btns[j].Size = new System.Drawing.Size(160, 45);
                simple_btns[j].TabIndex = j;
                simple_btns[j].Text = desc[j];
                flowLayout_sidePanel.Controls.Add(simple_btns[j]);
                simple_btns[j].Click += new System.EventHandler(this.useCaseButton_click);
            }

            cnn.Close();
        }

        private void useCaseButton_click(object sender, EventArgs e)
        {
            flowLayout_ip.Controls.Clear();
            var id = "";
            string btn = (sender as SimpleButton).Name;
            string connetionString = "server=localhost;database=dashboard;uid=root;pwd=admin;";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlDataReader row;
            MySqlDataReader row2;
            MySqlCommand cmd = new MySqlCommand();
            MySqlCommand cmd1 = new MySqlCommand();
            cnn.Open();
            //SELECT ID FROM dashboard.configuration_tbl where configuaration_description_fld = 'Kurla Mall';
            string query_for_config = "SELECT ID FROM configuration_tbl WHERE configuaration_description_fld = '" + btn + "';";
            //MessageBox.Show(query_for_config);
            cmd = new MySqlCommand(query_for_config, cnn);
            row = cmd.ExecuteReader();

            while (row.Read())
            {
                id = row["ID"].ToString();
            }
            row.Close();

            string query_for_cam = "SELECT * FROM camera_configuration_tbl WHERE config_id_fld = " + id + ";";
            cmd = new MySqlCommand(query_for_cam, cnn);
            row2 = cmd.ExecuteReader();
            List<string> camera_ips = new List<string>();
            List<string> camera_users = new List<string>();
            List<string> camera_pwds = new List<string>();
            List<string> camera_ports = new List<string>();
            List<string> camera_active_ = new List<string>();

            while (row2.Read())
            {
                string camera_ip = row2["camera_ip_fid"].ToString();
                string camera_user = row2["camera_user_id"].ToString();
                string camera_pwd = row2["camera_password_fid"].ToString();
                string camera_port = row2["camera_port_no_fid"].ToString();
                string camera_active = row2["camera_active_fid"].ToString();
                camera_ips.Add(camera_ip);
                camera_users.Add(camera_user);
                camera_pwds.Add(camera_pwd);
                camera_ports.Add(camera_port);
                camera_active_.Add(camera_active);
            }
            row2.Close();

            SimpleButton[] simple_btns = new SimpleButton[camera_ips.Count];

            for (int j = 0; j < camera_ips.Count; j++)
            {
                simple_btns[j] = new SimpleButton();
                simple_btns[j].Location = new Point(0, 0);
                simple_btns[j].Name = camera_ips[j];
                simple_btns[j].Size = new System.Drawing.Size(170, 100);
                simple_btns[j].TabIndex = j;
                //"195.229.90.110\r\nadmin\r\nIndia12345\r\n4444\r\n"
                simple_btns[j].Text = camera_ips[j] + "\r\n" +camera_users[j] + "\r\n" + camera_pwds[j] + "\r\n" + camera_ports[j];
                flowLayout_ip.Controls.Add(simple_btns[j]);
                simple_btns[j].Click += new System.EventHandler(this.ip_btn_click);
            }
        }

        private void ip_btn_click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as SimpleButton).Name.ToString());
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void flowLayout_ip_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}