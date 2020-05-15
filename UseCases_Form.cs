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
    public partial class UseCases_Form : XtraForm
    {
        public UseCases_Form()
        {
            InitializeComponent();
        }

        private void UseCases_Form_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            string connetionString = null;
            MySqlConnection cnn;
            var gbm_iva_id = 0;
            MySqlDataReader row;
            MySqlCommand cmd = new MySqlCommand();
            connetionString = "server=localhost;database=dashboard;uid=root;pwd=admin;";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            string get_gbm_iva_id = "SELECT ID FROM gbm_iva where Name = '" + GBMIVA.UseCases_Form + "';";
            cmd = new MySqlCommand(get_gbm_iva_id, cnn);
            row = cmd.ExecuteReader();
            while (row.Read())
            {
                gbm_iva_id = Convert.ToInt32(row["ID"].ToString());
            }
            row.Close();

            string query = "SELECT * FROM configuration_type_tbl WHERE fk_gbm_iva_id = " + gbm_iva_id + ";";
            cmd = new MySqlCommand(query, cnn);
            row = cmd.ExecuteReader();
            var count_of_records = 0;
            List<string> buttons = new List<string>();
            List<string> images = new List<string>();
            List<int> config_type_id = new List<int>();

            while (row.Read())
            {
                string col1Value = row["configuration_description_fld"].ToString();
                string col2Value = row["image_path"].ToString();
                buttons.Add(col1Value);
                images.Add(col2Value);
                config_type_id.Add(Convert.ToInt32(row["ID"]));
                count_of_records += 1;
            }

            SplitContainer[] violation = new SplitContainer[count_of_records];
            SimpleButton[] simple_btns = new SimpleButton[count_of_records * 2];
            List<Label> labels = new List<Label>();
            int buttons_count = 0;
            var tab_index_var = 0;

            for (int x = 0; x < count_of_records; x++)
            {
                //
                // SplitContainer
                //
                //violation[x].Visible = true;
                //FlowLayoutPanel.Controls.Add(this.splitContainer1);
                violation[x] = new SplitContainer();
                violation[x].Orientation = System.Windows.Forms.Orientation.Horizontal;
                violation[x].Parent = this.flowLayoutPanel1;
                violation[x].Location = new System.Drawing.Point(0, 0);
                violation[x].Name = buttons[x].ToString();
                violation[x].Orientation = System.Windows.Forms.Orientation.Horizontal;
                violation[x].Size = new System.Drawing.Size(380, 345);
                violation[x].SplitterDistance = 225;
                violation[x].TabIndex = buttons_count + 1;
                violation[x].Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Paint);
                //
                // Panel1
                //
                violation[x].Panel1.BackgroundImage = Image.FromFile(images[x]);
                violation[x].Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                violation[x].Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Paint);
             
                //
                // Simplebtn1
                //
                simple_btns[buttons_count] = new SimpleButton();
                simple_btns[buttons_count].Location = new Point(10, 70);
                simple_btns[buttons_count].Name = buttons[x];
                simple_btns[buttons_count].Size = new System.Drawing.Size(160, 45);
                simple_btns[buttons_count].TabIndex = buttons_count;
                simple_btns[buttons_count].Text = "OFFLINE";
                simple_btns[buttons_count].Tag = config_type_id[x]; // add id value
                simple_btns[buttons_count].Click += new System.EventHandler(this.simpleButton_Click);
                simple_btns[buttons_count].Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
                simple_btns[buttons_count].Appearance.Options.UseForeColor = true;
                //
                // Simplebtn2
                //
                simple_btns[buttons_count + 1] = new SimpleButton();
                simple_btns[buttons_count + 1].Location = new Point(200, 70);
                simple_btns[buttons_count + 1].Name = buttons[x];
                simple_btns[buttons_count + 1].Size = new System.Drawing.Size(160, 45);
                simple_btns[buttons_count + 1].TabIndex = buttons_count + 1;
                simple_btns[buttons_count + 1].Text = "LIVE CAMERA";
                simple_btns[buttons_count + 1].Click += new System.EventHandler(this.simpleButton2_Click);
                simple_btns[buttons_count + 1].Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
                simple_btns[buttons_count + 1].Appearance.Options.UseForeColor = true;
                //
                // Label
                //
                var temp = new Label();
                temp.Font = new System.Drawing.Font("Tahome", 20F);
                temp.Location = new System.Drawing.Point(25, 20);
                temp.Name = "label_" + x.ToString();
                temp.Size = new Size(340, 35);
                temp.TabIndex = tab_index_var + 2;
                temp.Text = buttons[x].ToString();
                temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                temp.ForeColor = System.Drawing.Color.BlueViolet;
                temp.Show();
                labels.Add(temp);
                //
                // Panel2
                //
                violation[x].Panel2.Controls.Add(simple_btns[buttons_count]);
                violation[x].Panel2.Controls.Add(temp);
                violation[x].Panel2.Controls.Add(simple_btns[buttons_count + 1]);
                violation[x].Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Paint);
                buttons_count += 2;
                tab_index_var += 2;
            }
        }

        private void simpleButton_Click(object sender, EventArgs e)
        {
            UseCases = (sender as SimpleButton).Name;
            conf_type_id = (int)(sender as SimpleButton).Tag;
            Offline_Violation offline_form = new Offline_Violation();
            offline_form.Show();

        }

        public static string UseCases = "";
        public static int conf_type_id = -1;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ///MessageBox.Show("Simple Button 2");
            //this.Hide();
            //online_offline form = new online_offline();
            //form.Show();
            //var Label = new Label();
            UseCases = (sender as SimpleButton).Name;
            //MessageBox.Show(UseCases);
            UseCases_1 form2 = new UseCases_1();
            form2.Show();


        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.DarkBlue, ButtonBorderStyle.Inset);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}