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
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        public MainForm()
        {
            InitializeComponent();
            //if (!container.Controls.Contains(GBMIVA.Instance))
            //{
            //    container.Controls.Add(GBMIVA.Instance);
            //    GBMIVA.Instance.Dock = DockStyle.Fill;
            //    GBMIVA.Instance.BringToFront();
            //}
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (!container.Controls.Contains(GBMIVA.Instance))
            {
                container.Controls.Add(GBMIVA.Instance);
                GBMIVA.Instance.Dock = DockStyle.Fill;
                GBMIVA.Instance.BringToFront();
            }
        }

        private void aceHome_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            GBMIVA gbm = new GBMIVA();
            gbm.Dock = DockStyle.Fill;
            container.Controls.Add(gbm);
        }

        private void aceConfig_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(Form2.Instance))
            {
                container.Controls.Add(Form2.Instance);
                Form2.Instance.Dock = DockStyle.Fill;
                Form2.Instance.BringToFront();
            }
            Form2.Instance.BringToFront();


        }

        private void aceReports_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(useReports.Instance))
            {
                container.Controls.Add(useReports.Instance);
                useReports.Instance.Dock = DockStyle.Fill;
                useReports.Instance.BringToFront();
            }
            useReports.Instance.BringToFront();

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}