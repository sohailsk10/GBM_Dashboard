using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsDashboardApp
{
    public partial class useReports : DevExpress.XtraEditors.XtraUserControl
    {
        private static useReports _instance;
        public static useReports Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new useReports();
                return _instance;
            }
        }
        public useReports()
        {
            InitializeComponent();
        }
    }
}
