using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraEditors;

namespace WindowsDashboardApp
{
    public partial class Offline_Violation : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Offline_Violation()
        {
            InitializeComponent();
        }

        private static int config_type = -1;

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Offline_Violation_Load(object sender, EventArgs e)
        {
            toDate.Value = DateTime.Today.AddDays(+1);
            this.WindowState = FormWindowState.Maximized;
            label3.Text = UseCases_Form.UseCases;
            label3.Font = new System.Drawing.Font("Tahoma", 20F);
            label3.Left = (this.Width - label3.Width) / 2;
            var id = "";

            string connetionString = "server=localhost;database=dashboard;uid=root;pwd=admin;";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlDataReader row, row2;
            MySqlCommand cmd = new MySqlCommand();
            cnn.Open();

            string query_to_get_btn = "SELECT ID FROM configuration_type_tbl WHERE configuration_description_fld = '" + label3.Text + "';";
            cmd = new MySqlCommand(query_to_get_btn, cnn);
            row = cmd.ExecuteReader();

            while (row.Read())
            {
                id = row["ID"].ToString();
            }
            row.Close();

            string query = "SELECT * FROM configuration_tbl WHERE config_type_id = '" + id + "';";
            cmd = new MySqlCommand(query, cnn);
            row2 = cmd.ExecuteReader();
            List<string> desc = new List<string>();
            List<string> config_tbl_id = new List<string>();

            while (row2.Read())
            {
                string desc_from_db = row2["configuaration_description_fld"].ToString();
                string id_from_db = row2["ID"].ToString();
                desc.Add(desc_from_db);
                config_tbl_id.Add(id_from_db);
            }
            row2.Close();

            SimpleButton[] simple_btns = new SimpleButton[desc.Count];
            for (int j = 0; j < desc.Count; j++)
            {
                simple_btns[j] = new SimpleButton();
                simple_btns[j].Location = new Point(0, 0);
                simple_btns[j].Name = desc[j];
                simple_btns[j].Size = new System.Drawing.Size(160, 45);
                simple_btns[j].TabIndex = j;
                simple_btns[j].Text = desc[j];
                simple_btns[j].Tag = config_tbl_id[j];
                this.side_panel_flow_layout.Controls.Add(simple_btns[j]);
                simple_btns[j].Click += new System.EventHandler(this.site_click);
            }


            List<string> camera_ips = new List<string>();
            List<string> camera_users = new List<string>();
            List<string> camera_pwds = new List<string>();
            List<string> camera_ports = new List<string>();
            List<string> camera_active_ = new List<string>();
            List<int> camera_config_ID = new List<int>();


            for (int i = 0; i < config_tbl_id.Count; i++)
            {
                string query_for_camera_ips = "SELECT * FROM camera_configuration_tbl where config_id_fld = " + config_tbl_id[i] + ";";
                cmd = new MySqlCommand(query_for_camera_ips, cnn);
                row = cmd.ExecuteReader();
                while(row.Read())
                {
                    string camera_ip = row["camera_ip_fid"].ToString();
                    string camera_user = row["camera_user_id"].ToString();
                    string camera_pwd = row["camera_password_fid"].ToString();
                    string camera_port = row["camera_port_no_fid"].ToString();
                    string camera_active = row["camera_active_fid"].ToString();
                    int ID = Convert.ToInt32(row["ID"]);
                    camera_ips.Add(camera_ip);
                    camera_users.Add(camera_user);
                    camera_pwds.Add(camera_pwd);
                    camera_ports.Add(camera_port);
                    camera_active_.Add(camera_active);
                    camera_config_ID.Add(ID);
                }
                row.Close();
            }

            Label[] label_select_camera = new Label[camera_ips.Count];

            for (int j = 0; j < camera_ips.Count; j++)
            {
                label_select_camera[j] = new Label();
                label_select_camera[j].Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label_select_camera[j].Name = camera_ips[j];
                label_select_camera[j].Size = new System.Drawing.Size(160, 120);
                label_select_camera[j].TabIndex = j;
                label_select_camera[j].Tag = camera_config_ID[j];
                label_select_camera[j].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                label_select_camera[j].Text = camera_ips[j] + "\r\n" + camera_users[j] + "\r\n" + camera_pwds[j] + "\r\n" + camera_ports[j];
                label_select_camera[j].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                label_select_camera[j].DoubleClick += new EventHandler(this.camera_click);
                flow_layout_camera.Controls.Add(label_select_camera[j]);
            }

            List<int> id_list = new List<int>();
            List<string> video_path_list = new List<string>();
            List<string> video_name_list = new List<string>();


            for (int i = 0; i < camera_config_ID.Count; i++)
            {
                //SELECT * FROM dashboard.videos where camer_config_id = 8;
                string query_for_video_list = "SELECT * FROM videos where camera_config_id = '" + camera_config_ID[i] + "';";
                cmd = new MySqlCommand(query_for_video_list, cnn);
                row = cmd.ExecuteReader();
                while (row.Read())
                {
                    //id videoname videopath
                    id_list.Add(Convert.ToInt32(row["id"]));
                    video_name_list.Add(row["video_name_fld"].ToString());
                    video_path_list.Add(row["video_path_fld"].ToString());
                }
                row.Close();
            }

            Label[] label_select_video = new Label[video_name_list.Count];

            for (int j = 0; j < video_name_list.Count; j++)
            {
                label_select_video[j] = new Label();
                label_select_video[j].Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label_select_video[j].Name = video_name_list[j];
                label_select_video[j].Size = new System.Drawing.Size(160, 120);
                label_select_video[j].TabIndex = j;
                label_select_video[j].Tag = id_list[j];
                label_select_video[j].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                label_select_video[j].Text = video_name_list[j] + "\r\n" + video_path_list[j];
                label_select_video[j].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                flowLayout_video.Controls.Add(label_select_video[j]);
            }

            List<string> violation_image_path_list = new List<string>();
            List<string> violation_video_path_list = new List<string>();
            List<DateTime> violation_datetime_list = new List<DateTime>();

            for (int i = 0; i < id_list.Count; i++)
            {
                string query_for_violation_list = "SELECT * FROM violation_tbl where fk_video_id = '" + id_list[i] + "';";
                cmd = new MySqlCommand(query_for_violation_list, cnn);
                row = cmd.ExecuteReader();
                while (row.Read())
                {
                    violation_image_path_list.Add(row["violation_frame_path_fld"].ToString());
                    violation_video_path_list.Add(row["violation_video_path_fld"].ToString());
                    violation_datetime_list.Add((DateTime)row["violation_datetime_fld"]);
                }
                row.Close();
            }

            SimpleButton[] label_violation = new SimpleButton[violation_video_path_list.Count * 3];
            var srno = 1;

            for (int x = 0; x < violation_video_path_list.Count; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    var rowValue = 1;
                    var colValue = 0; 
                    label_violation[x] = new SimpleButton();
                    label_violation[x].Dock = System.Windows.Forms.DockStyle.Top;
                    //label_violation[x].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    //label_violation[x].Size = new System.Drawing.Size(140, 47);
                    //label_violation[x].BorderStyle = BorderStyle.FixedSingle;

                    if (y == 0)
                    {
                        label_violation[x].Name = "srno" + srno.ToString();
                        label_violation[x].TabIndex = rowValue + x + y;
                        label_violation[x].Text = srno.ToString();
                        this.tablePanel1.SetColumn(label_violation[x], colValue + y);
                        this.tablePanel1.SetRow(label_violation[x], rowValue + x);
                    }

                    else if (y == 1)
                    {
                        label_violation[x].Name = violation_image_path_list[x];
                        label_violation[x].TabIndex = rowValue + x + y;
                        label_violation[x].Text = violation_image_path_list[x];
                        label_violation[x].Click += new EventHandler(this.show_frame);
                        this.tablePanel1.SetColumn(label_violation[x], colValue + y);
                        this.tablePanel1.SetRow(label_violation[x], rowValue + x);

                    }

                    else if (y == 2)
                    {
                        label_violation[x].Name = violation_video_path_list[x];
                        label_violation[x].TabIndex = rowValue + y + x;
                        label_violation[x].Text = violation_video_path_list[x];
                        label_violation[x].Click += new EventHandler(this.play_video);
                        this.tablePanel1.SetColumn(label_violation[x], colValue + y);
                        this.tablePanel1.SetRow(label_violation[x], rowValue + x);
                    }

                    else if (y == 3)
                    {
                        label_violation[x].Name = violation_datetime_list[x].ToString();
                        label_violation[x].TabIndex = rowValue + y + x;
                        label_violation[x].Text = violation_datetime_list[x].ToString();
                        this.tablePanel1.SetColumn(label_violation[x], colValue + y);
                        this.tablePanel1.SetRow(label_violation[x], rowValue + x);
                    }
                    this.tablePanel1.Controls.Add(label_violation[x]);
                }

                this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 42F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
                 srno += 1;
            }



            cnn.Close();
        }

        private void play_video(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer2.URL = (sender as SimpleButton).Text.ToString();
            
        }

        private void site_click(object sender, EventArgs e)
        {
            tablePanel1.Controls.Clear();
            flow_layout_camera.Controls.Clear();
            flowLayout_video.Controls.Clear();
            string site = (sender as SimpleButton).Name;
            string site_no = "";
            string connetionString = "server=localhost;database=dashboard;uid=root;pwd=admin;";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlDataReader row;
            MySqlCommand cmd = new MySqlCommand();
            cnn.Open();
            
            string site_number = "SELECT ID FROM configuration_tbl where configuaration_description_fld = '" + site + "';";
            cmd = new MySqlCommand(site_number, cnn);
            row = cmd.ExecuteReader();

            while (row.Read())
            {
                site_no = row["ID"].ToString();
            }
            row.Close();

            string filter_camera = "SELECT distinct ID FROM dashboard.camera_view where config_id_fld = " + site_no + " and violation_datetime_fld between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "'; ";
            cmd = new MySqlCommand(filter_camera, cnn);
            row = cmd.ExecuteReader();
            List<string> camera_list = new List<string>();

            while (row.Read())
            {
                camera_list.Add(row["id"].ToString());
            }
            row.Close();

            //MessageBox.Show(camera_list.Count.ToString()); 

            List<string> camera_ips = new List<string>();
            List<string> camera_users = new List<string>();
            List<string> camera_pwds = new List<string>();
            List<string> camera_ports = new List<string>();
            List<string> camera_active_ = new List<string>();
            List<int> camera_config_ID = new List<int>();
            flow_layout_camera.Controls.Clear();

            for (int i = 0; i < camera_list.Count; i++)
            {
                string query_for_camera_ips = "SELECT * FROM camera_configuration_tbl where ID = " + camera_list[i] + ";";
                cmd = new MySqlCommand(query_for_camera_ips, cnn);
                row = cmd.ExecuteReader();
                while (row.Read())
                {
                    string camera_ip = row["camera_ip_fid"].ToString();
                    string camera_user = row["camera_user_id"].ToString();
                    string camera_pwd = row["camera_password_fid"].ToString();
                    string camera_port = row["camera_port_no_fid"].ToString();
                    string camera_active = row["camera_active_fid"].ToString();
                    int ID = Convert.ToInt32(row["ID"]);
                    camera_ips.Add(camera_ip);
                    camera_users.Add(camera_user);
                    camera_pwds.Add(camera_pwd);
                    camera_ports.Add(camera_port);
                    camera_active_.Add(camera_active);
                    camera_config_ID.Add(ID);
                }
                row.Close();
            }

            Label[] label_select_camera = new Label[camera_ips.Count];

            for (int j = 0; j < camera_ips.Count; j++)
            {
                label_select_camera[j] = new Label();
                label_select_camera[j].Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label_select_camera[j].Name = camera_ips[j];
                label_select_camera[j].Size = new System.Drawing.Size(160, 120);
                label_select_camera[j].TabIndex = j;
                label_select_camera[j].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                label_select_camera[j].Tag = camera_config_ID[j];
                label_select_camera[j].Text = camera_ips[j] + "\r\n" + camera_ports[j];
                label_select_camera[j].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                label_select_camera[j].DoubleClick += new EventHandler(this.camera_click);
                flow_layout_camera.Controls.Add(label_select_camera[j]);
            }

            cnn.Close();
        }

        private void camera_click(object sender, EventArgs e)
        {
            tablePanel1.Controls.Clear();
            flowLayout_video.Controls.Clear();
            int camera_id = (int)(sender as Label).Tag;
            string connetionString = "server=localhost;database=dashboard;uid=root;pwd=admin;";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlDataReader row;
            MySqlCommand cmd = new MySqlCommand();
            cnn.Open();
            //SELECT * FROM dashboard.video_view where camera_config_id = 5 and datetime_fld between "2018-01-01" and "2020-12-31";
            string filter_camera = "SELECT * FROM dashboard.video_view where camera_config_id = " + camera_id + " and datetime_fld between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "'; ";
            cmd = new MySqlCommand(filter_camera, cnn);
            row = cmd.ExecuteReader();
            List<string> video_list = new List<string>();
            List<string> id_list = new List<string>();

            while (row.Read())
            {
                id_list.Add(row["id"].ToString());
                video_list.Add(row["video_name_fld"].ToString());
            }
            row.Close();

            List<string> video_name_list = new List<string>();
            List<string> video_path_list = new List<string>();
            List<int> id_filter = new List<int>();

            for (int i = 0; i < id_list.Count; i++)
            {
                string query_for_video = "SELECT * FROM videos where id = " + id_list[i] + ";";
                cmd = new MySqlCommand(query_for_video, cnn);
                row = cmd.ExecuteReader();
                while (row.Read())
                {
                    video_name_list.Add(row["video_name_fld"].ToString());
                    video_path_list.Add(row["video_path_fld"].ToString());
                    id_filter.Add(Convert.ToInt32(row["id"].ToString()));
                }
                row.Close();
            }

            Label[] label_select_video = new Label[video_name_list.Count];

            for (int j = 0; j < video_name_list.Count; j++)
            {
                label_select_video[j] = new Label();
                label_select_video[j].Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label_select_video[j].Name = video_name_list[j];
                label_select_video[j].Size = new System.Drawing.Size(160, 120);
                label_select_video[j].TabIndex = j;
                label_select_video[j].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                label_select_video[j].Tag = id_filter[j];
                label_select_video[j].Text = video_name_list[j] + "\r\n" + video_path_list[j];
                label_select_video[j].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                label_select_video[j].DoubleClick += new EventHandler(this.filter_violation);
                flowLayout_video.Controls.Add(label_select_video[j]);
            }

            cnn.Close();
        }

        private void filter_violation(object sender, EventArgs e)
        {
            tablePanel1.Controls.Clear();

            int video_id = (int)(sender as Label).Tag;
            string connetionString = "server=localhost;database=dashboard;uid=root;pwd=admin;";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlDataReader row;
            MySqlCommand cmd = new MySqlCommand();
            cnn.Open();

            //SELECT * FROM dashboard.violation_tbl where fk_video_id = 7;
            string filter_violation = "SELECT * FROM dashboard.violation_tbl where fk_video_id = '"+ video_id +"';";
            cmd = new MySqlCommand(filter_violation, cnn);
            row = cmd.ExecuteReader();

            List<string> violation_video_path_list = new List<string>();
            List<string> violation_frame_path_list = new List<string>();
            List<DateTime> violation_datetime_list = new List<DateTime>();

            while (row.Read())
            {
                violation_frame_path_list.Add(row["violation_frame_path_fld"].ToString());
                violation_video_path_list.Add(row["violation_video_path_fld"].ToString());
                violation_datetime_list.Add((DateTime)row["violation_datetime_fld"]);
            }
            row.Close();

            SimpleButton[] label_violation = new SimpleButton[violation_video_path_list.Count * 3];
            var srno = 1;

            for (int x = 0; x < violation_video_path_list.Count; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    var rowValue = 1;
                    var colValue = 0;
                    label_violation[x] = new SimpleButton();
                    label_violation[x].Dock = System.Windows.Forms.DockStyle.Top;
                    //label_violation[x].Size = new System.Drawing.Size(140, 47);

                    if (y == 0)
                    {
                        //srno
                        label_violation[x].Name = "srno" + srno.ToString();
                        label_violation[x].TabIndex = rowValue + x + y;
                        label_violation[x].Text = srno.ToString();
                        this.tablePanel1.SetColumn(label_violation[x], colValue + y);
                        this.tablePanel1.SetRow(label_violation[x], rowValue + x);
                    }

                    else if (y == 1)
                    {
                        //frame_path
                        label_violation[x].Name = violation_frame_path_list[x];
                        label_violation[x].TabIndex = rowValue + x + y;
                        label_violation[x].Text = violation_frame_path_list[x];
                        label_violation[x].Click += new EventHandler(this.show_frame);
                        this.tablePanel1.SetColumn(label_violation[x], colValue + y);
                        this.tablePanel1.SetRow(label_violation[x], rowValue + x);
                    }

                    else if (y == 2)
                    {
                        //video_path
                        label_violation[x].Name = violation_video_path_list[x];
                        label_violation[x].TabIndex = rowValue + y + x;
                        label_violation[x].Text = violation_video_path_list[x];
                        label_violation[x].Click += new EventHandler(this.play_video);
                        this.tablePanel1.SetColumn(label_violation[x], colValue + y);
                        this.tablePanel1.SetRow(label_violation[x], rowValue + x);
                    }

                    else if (y == 3)
                    {
                        //datetime
                        label_violation[x].Name = violation_datetime_list[x].ToString();
                        label_violation[x].TabIndex = rowValue + y + x;
                        label_violation[x].Text = violation_datetime_list[x].ToString();
                        this.tablePanel1.SetColumn(label_violation[x], colValue + y);
                        this.tablePanel1.SetRow(label_violation[x], rowValue + x);
                    }
                    this.tablePanel1.Controls.Add(label_violation[x]);
                }

                this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 42F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
                srno += 1;
            }

            cnn.Close();
        }

        private void show_frame(object sender, EventArgs e)
        {
            this.frame.Controls.Clear();
            var image_path = (sender as SimpleButton).Text.ToString();
            PictureBox picture = new PictureBox
            {
                Name = "show_frame_path",
                Image = Image.FromFile(image_path),
                Location = new Point(1, 391),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Fill,
            };
            this.frame.Controls.Add(picture);
        }

        private void Offline_Violation_SizeChanged(object sender, EventArgs e)
        {
            label3.Left = (this.Width - label3.Width) / 2;
        }

        private void fromDate_ValueChanged(object sender, EventArgs e)
        {
            //String sql = "insert into table values(" + dtp.Value.Date.Year + "/" +
            //dtp.Value.Date.Month + "/" + dtp.Value.Date.Day + ");";
            //Console.WriteLine(fromDate.Value.Date.Year + " " + fromDate.Value.Date.Month + " " + fromDate.Value.Date.Day);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void show_violation_Click(object sender, EventArgs e)
        {
            side_panel_flow_layout.Controls.Clear();
            flow_layout_camera.Controls.Clear();
            flowLayout_video.Controls.Clear();
            tablePanel1.Controls.Clear();
            string connetionString = "server=localhost;database=dashboard;uid=root;pwd=admin;";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            MySqlDataReader row;
            MySqlCommand cmd = new MySqlCommand();
            cnn.Open();

            //dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string filter_site = "SELECT distinct id FROM dashboard.site_view where config_type_id = "+ UseCases_Form.conf_type_id +" and violation_datetime_fld between '" + fromDate.Value.ToString("yyyy-MM-dd") + "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "'; ";
            cmd = new MySqlCommand(filter_site, cnn);
            row = cmd.ExecuteReader();
            List<string> site_list = new List<string>();

            while (row.Read())
            {
                site_list.Add(row["id"].ToString());
            }
            row.Close();

            List<string> desc = new List<string>();

            for (int i = 0; i < site_list.Count; i++)
            {
                string query = "SELECT * FROM configuration_tbl where ID = '" + site_list[i] + "';";
                cmd = new MySqlCommand(query, cnn);
                row = cmd.ExecuteReader();
                while (row.Read())
                {
                    desc.Add(row["configuaration_description_fld"].ToString());
                }
                row.Close();
            }

            //SELECT * FROM dashboard.configuration_tbl where ID = 5;
            SimpleButton[] simple_btns = new SimpleButton[desc.Count];
            for (int j = 0; j < desc.Count; j++)
            {
                simple_btns[j] = new SimpleButton();
                simple_btns[j].Location = new Point(0, 0);
                simple_btns[j].Name = desc[j];
                simple_btns[j].Size = new System.Drawing.Size(160, 45);
                simple_btns[j].TabIndex = j;
                simple_btns[j].Text = desc[j];
                this.side_panel_flow_layout.Controls.Add(simple_btns[j]);
                simple_btns[j].Click += new System.EventHandler(this.site_click);
            }

            cnn.Close();
        }
    }
}
