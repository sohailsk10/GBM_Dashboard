using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Violation
{
    public partial class Offline_video_2 : Form
    {
        public Offline_video_2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'video_violationDataSet.view_voilations' table. You can move, or remove it, as needed.
            this.view_voilationsTableAdapter.Fill(this.video_violationDataSet.view_voilations);

        }
    }
}
