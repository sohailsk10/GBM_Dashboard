namespace WindowsDashboardApp
{
    partial class GBMIVA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GBMIVA));
            this.gbm_usecases_flow_layout = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gbm_usecases_flow_layout
            // 
            this.gbm_usecases_flow_layout.AutoScroll = true;
            this.gbm_usecases_flow_layout.BackColor = System.Drawing.Color.Black;
            this.gbm_usecases_flow_layout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbm_usecases_flow_layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbm_usecases_flow_layout.Location = new System.Drawing.Point(0, 85);
            this.gbm_usecases_flow_layout.Name = "gbm_usecases_flow_layout";
            this.gbm_usecases_flow_layout.Size = new System.Drawing.Size(1254, 633);
            this.gbm_usecases_flow_layout.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1254, 85);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GBMIVA
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbm_usecases_flow_layout);
            this.Controls.Add(this.label1);
            this.Name = "GBMIVA";
            this.Size = new System.Drawing.Size(1254, 718);
            this.Load += new System.EventHandler(this.GBMIVA_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel gbm_usecases_flow_layout;
        private System.Windows.Forms.Label label1;
    }
}