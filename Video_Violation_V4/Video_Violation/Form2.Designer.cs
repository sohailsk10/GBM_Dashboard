namespace Video_Violation
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.viewvoilationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.video_violationDataSet = new Video_Violation.video_violationDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colvideo_year = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvideo_month = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvideo_day = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvideo_hour = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvideo_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvideo_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvideo_path = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colviolation_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colviolation_video_path = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colviolation_frame_path = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colviolation_datetime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.view_voilationsTableAdapter = new Video_Violation.video_violationDataSetTableAdapters.view_voilationsTableAdapter();
            this.repositoryItemMRUEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewvoilationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.video_violationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMRUEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.viewvoilationsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.cardView1;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMRUEdit1,
            this.repositoryItemImageEdit1});
            this.gridControl1.Size = new System.Drawing.Size(800, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.cardView1});
            // 
            // viewvoilationsBindingSource
            // 
            this.viewvoilationsBindingSource.DataMember = "view_voilations";
            this.viewvoilationsBindingSource.DataSource = this.video_violationDataSet;
            // 
            // video_violationDataSet
            // 
            this.video_violationDataSet.DataSetName = "video_violationDataSet";
            this.video_violationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colvideo_year,
            this.colvideo_month,
            this.colvideo_day,
            this.colvideo_hour,
            this.colvideo_id,
            this.colvideo_name,
            this.colvideo_path,
            this.colviolation_id,
            this.colviolation_video_path,
            this.colviolation_frame_path,
            this.colviolation_datetime});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 6;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colvideo_year, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colvideo_month, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colvideo_day, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colvideo_hour, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colvideo_id, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colviolation_id, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colvideo_year
            // 
            this.colvideo_year.FieldName = "video_year";
            this.colvideo_year.Name = "colvideo_year";
            this.colvideo_year.OptionsColumn.AllowEdit = false;
            this.colvideo_year.Visible = true;
            this.colvideo_year.VisibleIndex = 0;
            // 
            // colvideo_month
            // 
            this.colvideo_month.FieldName = "video_month";
            this.colvideo_month.Name = "colvideo_month";
            this.colvideo_month.OptionsColumn.AllowEdit = false;
            this.colvideo_month.Visible = true;
            this.colvideo_month.VisibleIndex = 0;
            // 
            // colvideo_day
            // 
            this.colvideo_day.FieldName = "video_day";
            this.colvideo_day.Name = "colvideo_day";
            this.colvideo_day.OptionsColumn.AllowEdit = false;
            this.colvideo_day.Visible = true;
            this.colvideo_day.VisibleIndex = 0;
            // 
            // colvideo_hour
            // 
            this.colvideo_hour.FieldName = "video_hour";
            this.colvideo_hour.Name = "colvideo_hour";
            this.colvideo_hour.OptionsColumn.AllowEdit = false;
            this.colvideo_hour.Visible = true;
            this.colvideo_hour.VisibleIndex = 0;
            // 
            // colvideo_id
            // 
            this.colvideo_id.FieldName = "video_id";
            this.colvideo_id.Name = "colvideo_id";
            this.colvideo_id.OptionsColumn.AllowEdit = false;
            this.colvideo_id.Visible = true;
            this.colvideo_id.VisibleIndex = 0;
            this.colvideo_id.Width = 83;
            // 
            // colvideo_name
            // 
            this.colvideo_name.FieldName = "video_name";
            this.colvideo_name.Name = "colvideo_name";
            this.colvideo_name.OptionsColumn.AllowEdit = false;
            this.colvideo_name.Visible = true;
            this.colvideo_name.VisibleIndex = 0;
            this.colvideo_name.Width = 125;
            // 
            // colvideo_path
            // 
            this.colvideo_path.FieldName = "video_path";
            this.colvideo_path.Name = "colvideo_path";
            this.colvideo_path.OptionsColumn.AllowEdit = false;
            this.colvideo_path.Visible = true;
            this.colvideo_path.VisibleIndex = 1;
            // 
            // colviolation_id
            // 
            this.colviolation_id.FieldName = "violation_id";
            this.colviolation_id.Name = "colviolation_id";
            this.colviolation_id.OptionsColumn.AllowEdit = false;
            this.colviolation_id.Visible = true;
            this.colviolation_id.VisibleIndex = 2;
            // 
            // colviolation_video_path
            // 
            this.colviolation_video_path.FieldName = "violation_video_path";
            this.colviolation_video_path.Name = "colviolation_video_path";
            this.colviolation_video_path.OptionsColumn.AllowEdit = false;
            this.colviolation_video_path.Visible = true;
            this.colviolation_video_path.VisibleIndex = 2;
            // 
            // colviolation_frame_path
            // 
            this.colviolation_frame_path.ColumnEdit = this.repositoryItemImageEdit1;
            this.colviolation_frame_path.FieldName = "violation_frame_path";
            this.colviolation_frame_path.Name = "colviolation_frame_path";
            this.colviolation_frame_path.OptionsColumn.AllowEdit = false;
            this.colviolation_frame_path.Visible = true;
            this.colviolation_frame_path.VisibleIndex = 3;
            // 
            // colviolation_datetime
            // 
            this.colviolation_datetime.FieldName = "violation_datetime";
            this.colviolation_datetime.Name = "colviolation_datetime";
            this.colviolation_datetime.OptionsColumn.AllowEdit = false;
            this.colviolation_datetime.Visible = true;
            this.colviolation_datetime.VisibleIndex = 4;
            // 
            // view_voilationsTableAdapter
            // 
            this.view_voilationsTableAdapter.ClearBeforeFill = true;
            // 
            // repositoryItemMRUEdit1
            // 
            this.repositoryItemMRUEdit1.AutoHeight = false;
            this.repositoryItemMRUEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMRUEdit1.Name = "repositoryItemMRUEdit1";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // cardView1
            // 
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewvoilationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.video_violationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMRUEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private video_violationDataSet video_violationDataSet;
        private System.Windows.Forms.BindingSource viewvoilationsBindingSource;
        private video_violationDataSetTableAdapters.view_voilationsTableAdapter view_voilationsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colvideo_year;
        private DevExpress.XtraGrid.Columns.GridColumn colvideo_month;
        private DevExpress.XtraGrid.Columns.GridColumn colvideo_day;
        private DevExpress.XtraGrid.Columns.GridColumn colvideo_hour;
        private DevExpress.XtraGrid.Columns.GridColumn colvideo_id;
        private DevExpress.XtraGrid.Columns.GridColumn colvideo_name;
        private DevExpress.XtraGrid.Columns.GridColumn colvideo_path;
        private DevExpress.XtraGrid.Columns.GridColumn colviolation_id;
        private DevExpress.XtraGrid.Columns.GridColumn colviolation_video_path;
        private DevExpress.XtraGrid.Columns.GridColumn colviolation_frame_path;
        private DevExpress.XtraGrid.Columns.GridColumn colviolation_datetime;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit repositoryItemMRUEdit1;
    }
}