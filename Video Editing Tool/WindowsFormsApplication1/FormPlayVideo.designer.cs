namespace DataStudioRecorder
{
    partial class FormPlayVideo
    {
        /// <summary>
        /// Design Variables
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clear up resources being used
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region all the components on a window


        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFrameScreenShot = new System.Windows.Forms.Button();
            this.btn_back_1 = new System.Windows.Forms.Button();
            this.btn_forward_1 = new System.Windows.Forms.Button();
            this.btn_split_pre = new System.Windows.Forms.Button();
            this.btn_split_save = new System.Windows.Forms.Button();
            this.txt_split_end = new System.Windows.Forms.TextBox();
            this.btn_split_end = new System.Windows.Forms.Button();
            this.txt_split_start = new System.Windows.Forms.TextBox();
            this.btn_split_start = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.PlayerTimeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_info = new System.Windows.Forms.Panel();
            this.piBox_panel_info = new System.Windows.Forms.PictureBox();
            this.PlayertrackBar = new DataStudioRecorder.MyControls.MusicBar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piBox_panel_info)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnFrameScreenShot);
            this.panel1.Controls.Add(this.btn_back_1);
            this.panel1.Controls.Add(this.btn_forward_1);
            this.panel1.Controls.Add(this.btn_split_pre);
            this.panel1.Controls.Add(this.btn_split_save);
            this.panel1.Controls.Add(this.txt_split_end);
            this.panel1.Controls.Add(this.btn_split_end);
            this.panel1.Controls.Add(this.txt_split_start);
            this.panel1.Controls.Add(this.btn_split_start);
            this.panel1.Controls.Add(this.btn_play);
            this.panel1.Location = new System.Drawing.Point(0, 554);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 39);
            this.panel1.TabIndex = 0;
            // 
            // btnFrameScreenShot
            // 
            this.btnFrameScreenShot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFrameScreenShot.Location = new System.Drawing.Point(285, 8);
            this.btnFrameScreenShot.Name = "btnFrameScreenShot";
            this.btnFrameScreenShot.Size = new System.Drawing.Size(100, 23);
            this.btnFrameScreenShot.TabIndex = 20;
            this.btnFrameScreenShot.Text = "Screenshots\n\n";
            this.btnFrameScreenShot.UseVisualStyleBackColor = true;
            this.btnFrameScreenShot.Click += new System.EventHandler(this.btn_ScreenshotFrame_Click);
            // 
            // btn_back_1
            // 
            this.btn_back_1.Location = new System.Drawing.Point(193, 8);
            this.btn_back_1.Name = "btn_back_1";
            this.btn_back_1.Size = new System.Drawing.Size(75, 23);
            this.btn_back_1.TabIndex = 19;
            this.btn_back_1.Text = "Back ";
            this.btn_back_1.UseVisualStyleBackColor = true;
            this.btn_back_1.Click += new System.EventHandler(this.btn_back_1_Click);
            // 
            // btn_forward_1
            // 
            this.btn_forward_1.Location = new System.Drawing.Point(96, 8);
            this.btn_forward_1.Name = "btn_forward_1";
            this.btn_forward_1.Size = new System.Drawing.Size(82, 23);
            this.btn_forward_1.TabIndex = 18;
            this.btn_forward_1.Text = "forward\n\n";
            this.btn_forward_1.UseVisualStyleBackColor = true;
            this.btn_forward_1.Click += new System.EventHandler(this.btn_forward_1_Click);
            // 
            // btn_split_pre
            // 
            this.btn_split_pre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_split_pre.Location = new System.Drawing.Point(786, 8);
            this.btn_split_pre.Name = "btn_split_pre";
            this.btn_split_pre.Size = new System.Drawing.Size(56, 23);
            this.btn_split_pre.TabIndex = 17;
            this.btn_split_pre.Text = "play";
            this.btn_split_pre.UseVisualStyleBackColor = true;
            this.btn_split_pre.Click += new System.EventHandler(this.btn_split_pre_Click);
            // 
            // btn_split_save
            // 
            this.btn_split_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_split_save.Location = new System.Drawing.Point(874, 8);
            this.btn_split_save.Name = "btn_split_save";
            this.btn_split_save.Size = new System.Drawing.Size(85, 23);
            this.btn_split_save.TabIndex = 16;
            this.btn_split_save.Text = "Save as";
            this.btn_split_save.UseVisualStyleBackColor = true;
            this.btn_split_save.Click += new System.EventHandler(this.btn_split_save_Click);
            // 
            // txt_split_end
            // 
            this.txt_split_end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_split_end.Location = new System.Drawing.Point(708, 10);
            this.txt_split_end.Name = "txt_split_end";
            this.txt_split_end.ReadOnly = true;
            this.txt_split_end.Size = new System.Drawing.Size(66, 21);
            this.txt_split_end.TabIndex = 15;
            // 
            // btn_split_end
            // 
            this.btn_split_end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_split_end.Location = new System.Drawing.Point(613, 8);
            this.btn_split_end.Name = "btn_split_end";
            this.btn_split_end.Size = new System.Drawing.Size(89, 23);
            this.btn_split_end.TabIndex = 14;
            this.btn_split_end.Text = "End Point";
            this.btn_split_end.UseVisualStyleBackColor = true;
            this.btn_split_end.Click += new System.EventHandler(this.btn_split_end_Click);
            // 
            // txt_split_start
            // 
            this.txt_split_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_split_start.Location = new System.Drawing.Point(532, 10);
            this.txt_split_start.Name = "txt_split_start";
            this.txt_split_start.ReadOnly = true;
            this.txt_split_start.Size = new System.Drawing.Size(66, 21);
            this.txt_split_start.TabIndex = 13;
            // 
            // btn_split_start
            // 
            this.btn_split_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_split_start.Location = new System.Drawing.Point(429, 8);
            this.btn_split_start.Name = "btn_split_start";
            this.btn_split_start.Size = new System.Drawing.Size(97, 23);
            this.btn_split_start.TabIndex = 12;
            this.btn_split_start.Text = "Start point\n\n";
            this.btn_split_start.UseVisualStyleBackColor = true;
            this.btn_split_start.Click += new System.EventHandler(this.btn_split_start_Click);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(14, 8);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 11;
            this.btn_play.Text = "pause";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayerTimeLabel
            // 
            this.PlayerTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerTimeLabel.Location = new System.Drawing.Point(852, 23);
            this.PlayerTimeLabel.Name = "PlayerTimeLabel";
            this.PlayerTimeLabel.Size = new System.Drawing.Size(111, 23);
            this.PlayerTimeLabel.TabIndex = 8;
            this.PlayerTimeLabel.Text = "00:00:00/00:00:00";
            this.PlayerTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel_info);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 548);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.PlayertrackBar);
            this.panel3.Controls.Add(this.PlayerTimeLabel);
            this.panel3.Location = new System.Drawing.Point(0, 494);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 54);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "lb_seccound";
            this.label1.Visible = false;
            // 
            // panel_info
            // 
            this.panel_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_info.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_info.Controls.Add(this.piBox_panel_info);
            this.panel_info.Location = new System.Drawing.Point(0, 2);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(968, 488);
            this.panel_info.TabIndex = 7;
            // 
            // piBox_panel_info
            // 
            this.piBox_panel_info.BackColor = System.Drawing.Color.Transparent;
            this.piBox_panel_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.piBox_panel_info.Location = new System.Drawing.Point(0, 0);
            this.piBox_panel_info.Name = "piBox_panel_info";
            this.piBox_panel_info.Size = new System.Drawing.Size(968, 488);
            this.piBox_panel_info.TabIndex = 0;
            this.piBox_panel_info.TabStop = false;
            this.piBox_panel_info.DoubleClick += new System.EventHandler(this.piBox_panel_info_DoubleClick_1);
            // 
            // PlayertrackBar
            // 
            this.PlayertrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayertrackBar.BackColor = System.Drawing.Color.Transparent;
            this.PlayertrackBar.BarWidth = 4;
            this.PlayertrackBar.Location = new System.Drawing.Point(0, 15);
            this.PlayertrackBar.MaxValue = 100D;
            this.PlayertrackBar.Name = "PlayertrackBar";
            this.PlayertrackBar.Size = new System.Drawing.Size(842, 35);
            this.PlayertrackBar.TabIndex = 9;
            this.PlayertrackBar.Value = 0D;
            this.PlayertrackBar.OnValueChanged += new DataStudioRecorder.MyControls.MusicBar.ValueChanged(this.PlayertrackBar_OnValueChanged);
            this.PlayertrackBar.MouseLeave += new System.EventHandler(this.PlayertrackBar_MouseLeave);
            this.PlayertrackBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlayertrackBar_MouseHover);
            // 
            // FormPlayVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 593);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPlayVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Video player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPlayVideo_FormClosing);
            this.Load += new System.EventHandler(this.FormPlayVideo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piBox_panel_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label PlayerTimeLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.TextBox txt_split_end;
        private System.Windows.Forms.Button btn_split_end;
        private System.Windows.Forms.TextBox txt_split_start;
        private System.Windows.Forms.Button btn_split_start;
        private System.Windows.Forms.Button btn_split_save;
        private System.Windows.Forms.Button btn_split_pre;
        private System.Windows.Forms.Panel panel3;
        private MyControls.MusicBar PlayertrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox piBox_panel_info;
        private System.Windows.Forms.Button btn_back_1;
        private System.Windows.Forms.Button btn_forward_1;
        private System.Windows.Forms.Button btnFrameScreenShot;
    }
}

