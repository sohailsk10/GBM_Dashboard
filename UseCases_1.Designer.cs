namespace WindowsDashboardApp
{
    partial class UseCases_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UseCases_1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayout_ip = new System.Windows.Forms.FlowLayoutPanel();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.flowLayout_sidePanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayout_ip);
            this.splitContainer1.Panel2.Controls.Add(this.sidePanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1182, 707);
            this.splitContainer1.SplitterDistance = 47;
            this.splitContainer1.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(0, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 41);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "BACK";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // flowLayout_ip
            // 
            this.flowLayout_ip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayout_ip.Location = new System.Drawing.Point(568, 0);
            this.flowLayout_ip.Name = "flowLayout_ip";
            this.flowLayout_ip.Size = new System.Drawing.Size(614, 656);
            this.flowLayout_ip.TabIndex = 1;
            this.flowLayout_ip.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayout_ip_Paint);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.flowLayout_sidePanel);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(568, 656);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "usecase_buttons";
            // 
            // flowLayout_sidePanel
            // 
            this.flowLayout_sidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayout_sidePanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayout_sidePanel.Name = "flowLayout_sidePanel";
            this.flowLayout_sidePanel.Size = new System.Drawing.Size(567, 656);
            this.flowLayout_sidePanel.TabIndex = 0;
            // 
            // UseCases_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1182, 707);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UseCases_1";
            this.Text = "UseCases_1";
            this.Load += new System.EventHandler(this.UseCases_1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.sidePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_ip;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_sidePanel;
    }
}