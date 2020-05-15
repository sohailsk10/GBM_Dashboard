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

namespace WindowsDashboardApp
{
    public partial class only_for_demo : DevExpress.XtraEditors.XtraForm
    {
        public only_for_demo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void only_for_demo_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            labeltext.BackColor = Color.BlueViolet;
        }
    }
}