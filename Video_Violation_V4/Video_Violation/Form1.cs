using DevExpress.Utils.Drawing;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Card.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Views.Layout.ViewInfo;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gridView1.RowCellClick += gridView1_RowCellClick;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'video_violationDataSet.qry_video_year' table. You can move, or remove it, as needed.
            this.qry_video_yearTableAdapter.Fill(this.video_violationDataSet.qry_video_year);
            this.qry_video_monthTableAdapter.Fill(this.video_violationDataSet.qry_video_month);
           
            this.qry_video_dayTableAdapter.Fill(this.video_violationDataSet.qry_video_day);
            this.qry_video_hourTableAdapter.Fill(this.video_violationDataSet.qry_video_hour);
            this.video_viewTableAdapter.Fill(this.video_violationDataSet.video_view);
            this.violationsTableAdapter.Fill(this.video_violationDataSet.violations);
            
            


                    //

                    /* this.columnImage.Caption = "Image (unbound)";
                     this.columnImage.ColumnEdit = this.repositoryItemPictureEdit1;
                     this.columnImage.FieldName = "Image";
                     this.columnImage.Name = "columnImage";
                     this.columnImage.OptionsColumn.AllowEdit = false;
                     this.columnImage.UnboundType = DevExpress.Data.UnboundColumnType.Object;
                     this.columnImage.Visible = true;
                     this.columnImage.VisibleIndex = 3;
                     this.columnImage.Width = 118;*/
                    // 
                    // repositoryItemPictureEdit1
                    // 
                    //this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";


                    //(CardView.Columns["video_path"] as CardViewHyperLinkColumn).PropertiesHyperLinkEdit.NavigateUrlFormatString = "string";
                    //gridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.True;
                    //  gridView1.OptionsCustomization.AllowQuickHideColumns.ToString();  
        }

        private void datagridview1_SelectionChanged(object sender, EventArgs e)
        {
          
        }


        private void qryvideoyearBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("currentChanged");
        }

        private void CurrentChanged(object sender, EventArgs e)
        {
            MessageBox.Show("currentChanged1");
        }

        private void cardView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            MessageBox.Show("selection changed");
        }

        private void gridView3_CalcPreviewText(object sender, CalcPreviewTextEventArgs e)
        {
            MessageBox.Show("previewtext");
        }

        private void cardView2_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(cardView2.GetRow(0).ToString());
            //CardHitInfo hi = cardView2.CalcHitInfo(e.Location);
            //object row = cardView2.GetRow(hi.RowHandle);
            //MessageBox.Show(hi.ToString());
            //var record = this.cardView2.GetRow(e.Clicks);
            //MessageBox.Show(Convert.ToString(record));
            // MessageBox.Show("value"+cardView2.GetRow.colviolation_video_path[1]);
            /* MessageBox.Show("lue:::" + lView.GetRowCellValue);
            LayoutViewHitInfo hInfo = lView.CalcHitInfo(e.X, e.Y);
            if (hInfo.HitTest == LayoutViewHitTest.FieldCaption)
            {
                int rowHandle = hInfo.RowHandle;
                GridColumn column = hInfo.Column;
                // your code here
                MessageBox.Show("rowhandle"+rowHandle);
                MessageBox.Show("Column" +column.Caption); ;
            }*/
        }

        private void pictureEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void cardView2_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            MessageBox.Show(e.FocusedRowHandle.ToString());
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            //MessageBox.Show(e.CellValue.ToString());
            //MessageBox.Show(e.column.ToString());
            var col = Convert.ToString(e.Column);
            if (col == "violation_video_path")
            {
                var video = e.CellValue.ToString();
                axWindowsMediaPlayer1.URL = video;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else if (col == "violation_frame_path")
            {
                var image = e.CellValue.ToString();
                pictureBox1.Image = Image.FromFile(image);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //private void gridControl2_cardView_cellClick(object sender, EventArgs e)
        //{
        //    play_video = gridControl2_cardView_cellClick[e.]
        //}


    }
}
