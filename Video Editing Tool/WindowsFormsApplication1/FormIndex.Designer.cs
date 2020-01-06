namespace DataStudioRecorder
{
    partial class IndexForm
    {
        /// <summary>
        /// Required design variable.
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notify_recording = new System.Windows.Forms.NotifyIcon(this.components);
            this.notify_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notify_menu_item_continue = new System.Windows.Forms.ToolStripMenuItem();
            this.notify_menu_item_pause = new System.Windows.Forms.ToolStripMenuItem();
            this.notify_menu_item_stop = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_notify = new System.Windows.Forms.Timer(this.components);
            this.tab_video_cut = new System.Windows.Forms.TabPage();
            this.group_cut_videos = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_select_cut_video = new TX.Framework.WindowUI.Controls.TXButton();
            this.group_merge_vidoes = new System.Windows.Forms.GroupBox();
            this.btn_select_merge_videos = new TX.Framework.WindowUI.Controls.TXButton();
            this.label15 = new System.Windows.Forms.Label();
            this.lbox_merge_video_list = new System.Windows.Forms.ListBox();
            this.txButton3 = new TX.Framework.WindowUI.Controls.TXButton();
            this.btn_merge_list_up = new System.Windows.Forms.Button();
            this.btn_merge_list_down = new System.Windows.Forms.Button();
            this.btn_merge_list_remove = new System.Windows.Forms.Button();
            this.txTabControl1 = new TX.Framework.WindowUI.Controls.TXTabControl();
            this.menuStrip1.SuspendLayout();
            this.tab_video_cut.SuspendLayout();
            this.group_cut_videos.SuspendLayout();
            this.group_merge_vidoes.SuspendLayout();
            this.txTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // notify_menu
            // 
            this.notify_menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.notify_menu.Name = "notify_menu";
            this.notify_menu.Size = new System.Drawing.Size(61, 4);
            // 
            // notify_menu_item_continue
            // 
            this.notify_menu_item_continue.Name = "notify_menu_item_continue";
            this.notify_menu_item_continue.Size = new System.Drawing.Size(32, 19);
            // 
            // notify_menu_item_pause
            // 
            this.notify_menu_item_pause.Name = "notify_menu_item_pause";
            this.notify_menu_item_pause.Size = new System.Drawing.Size(32, 19);
            // 
            // notify_menu_item_stop
            // 
            this.notify_menu_item_stop.Name = "notify_menu_item_stop";
            this.notify_menu_item_stop.Size = new System.Drawing.Size(32, 19);
            // 
            // tab_video_cut
            // 
            this.tab_video_cut.Controls.Add(this.group_merge_vidoes);
            this.tab_video_cut.Controls.Add(this.group_cut_videos);
            this.tab_video_cut.Location = new System.Drawing.Point(4, 32);
            this.tab_video_cut.Margin = new System.Windows.Forms.Padding(4);
            this.tab_video_cut.Name = "tab_video_cut";
            this.tab_video_cut.Padding = new System.Windows.Forms.Padding(4);
            this.tab_video_cut.Size = new System.Drawing.Size(601, 416);
            this.tab_video_cut.TabIndex = 1;
            this.tab_video_cut.Text = "Video Editor";
            this.tab_video_cut.UseVisualStyleBackColor = true;
            // 
            // group_cut_videos
            // 
            this.group_cut_videos.Controls.Add(this.btn_select_cut_video);
            this.group_cut_videos.Controls.Add(this.label14);
            this.group_cut_videos.Location = new System.Drawing.Point(18, 31);
            this.group_cut_videos.Name = "group_cut_videos";
            this.group_cut_videos.Size = new System.Drawing.Size(575, 92);
            this.group_cut_videos.TabIndex = 0;
            this.group_cut_videos.TabStop = false;
            this.group_cut_videos.Text = "Video Cut";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(186, 22);
            this.label14.TabIndex = 0;
            this.label14.Text = "Select Cut Video";
            // 
            // btn_select_cut_video
            // 
            this.btn_select_cut_video.Image = null;
            this.btn_select_cut_video.Location = new System.Drawing.Point(197, 39);
            this.btn_select_cut_video.Name = "btn_select_cut_video";
            this.btn_select_cut_video.Size = new System.Drawing.Size(75, 28);
            this.btn_select_cut_video.TabIndex = 1;
            this.btn_select_cut_video.Text = "Select";
            this.btn_select_cut_video.UseVisualStyleBackColor = true;
            this.btn_select_cut_video.Click += new System.EventHandler(this.btn_select_cut_video_Click);
            // 
            // group_merge_vidoes
            // 
            this.group_merge_vidoes.Controls.Add(this.btn_merge_list_remove);
            this.group_merge_vidoes.Controls.Add(this.btn_merge_list_down);
            this.group_merge_vidoes.Controls.Add(this.btn_merge_list_up);
            this.group_merge_vidoes.Controls.Add(this.txButton3);
            this.group_merge_vidoes.Controls.Add(this.lbox_merge_video_list);
            this.group_merge_vidoes.Controls.Add(this.label15);
            this.group_merge_vidoes.Controls.Add(this.btn_select_merge_videos);
            this.group_merge_vidoes.Location = new System.Drawing.Point(18, 154);
            this.group_merge_vidoes.Name = "group_merge_vidoes";
            this.group_merge_vidoes.Size = new System.Drawing.Size(576, 265);
            this.group_merge_vidoes.TabIndex = 1;
            this.group_merge_vidoes.TabStop = false;
            this.group_merge_vidoes.Text = "Video Merge";
            // 
            // btn_select_merge_videos
            // 
            this.btn_select_merge_videos.Image = null;
            this.btn_select_merge_videos.Location = new System.Drawing.Point(197, 35);
            this.btn_select_merge_videos.Name = "btn_select_merge_videos";
            this.btn_select_merge_videos.Size = new System.Drawing.Size(75, 28);
            this.btn_select_merge_videos.TabIndex = 2;
            this.btn_select_merge_videos.Text = "Select";
            this.btn_select_merge_videos.UseVisualStyleBackColor = true;
            this.btn_select_merge_videos.Click += new System.EventHandler(this.btn_select_merge_videos_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(219, 22);
            this.label15.TabIndex = 3;
            this.label15.Text = "Select Merge_Videos";
            // 
            // lbox_merge_video_list
            // 
            this.lbox_merge_video_list.FormattingEnabled = true;
            this.lbox_merge_video_list.ItemHeight = 22;
            this.lbox_merge_video_list.Location = new System.Drawing.Point(39, 81);
            this.lbox_merge_video_list.Name = "lbox_merge_video_list";
            this.lbox_merge_video_list.Size = new System.Drawing.Size(417, 136);
            this.lbox_merge_video_list.TabIndex = 4;
            // 
            // txButton3
            // 
            this.txButton3.Image = null;
            this.txButton3.Location = new System.Drawing.Point(381, 35);
            this.txButton3.Name = "txButton3";
            this.txButton3.Size = new System.Drawing.Size(75, 28);
            this.txButton3.TabIndex = 5;
            this.txButton3.Text = "Merge";
            this.txButton3.UseVisualStyleBackColor = true;
            this.txButton3.Click += new System.EventHandler(this.txButton3_Click);
            // 
            // btn_merge_list_up
            // 
            this.btn_merge_list_up.Location = new System.Drawing.Point(462, 81);
            this.btn_merge_list_up.Name = "btn_merge_list_up";
            this.btn_merge_list_up.Size = new System.Drawing.Size(59, 23);
            this.btn_merge_list_up.TabIndex = 6;
            this.btn_merge_list_up.Text = "up";
            this.btn_merge_list_up.UseVisualStyleBackColor = true;
            this.btn_merge_list_up.Click += new System.EventHandler(this.btn_merge_list_up_Click);
            // 
            // btn_merge_list_down
            // 
            this.btn_merge_list_down.Location = new System.Drawing.Point(462, 121);
            this.btn_merge_list_down.Name = "btn_merge_list_down";
            this.btn_merge_list_down.Size = new System.Drawing.Size(59, 23);
            this.btn_merge_list_down.TabIndex = 7;
            this.btn_merge_list_down.Text = "down";
            this.btn_merge_list_down.UseVisualStyleBackColor = true;
            this.btn_merge_list_down.Click += new System.EventHandler(this.btn_merge_list_down_Click);
            // 
            // btn_merge_list_remove
            // 
            this.btn_merge_list_remove.Location = new System.Drawing.Point(462, 160);
            this.btn_merge_list_remove.Name = "btn_merge_list_remove";
            this.btn_merge_list_remove.Size = new System.Drawing.Size(59, 23);
            this.btn_merge_list_remove.TabIndex = 8;
            this.btn_merge_list_remove.Text = "remove";
            this.btn_merge_list_remove.UseVisualStyleBackColor = true;
            this.btn_merge_list_remove.Click += new System.EventHandler(this.btn_merge_list_remove_Click);
            // 
            // txTabControl1
            // 
            this.txTabControl1.BaseTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txTabControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txTabControl1.CaptionFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txTabControl1.CheckedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txTabControl1.Controls.Add(this.tab_video_cut);
            this.txTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txTabControl1.HeightLightTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.txTabControl1.Location = new System.Drawing.Point(0, 33);
            this.txTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.txTabControl1.Name = "txTabControl1";
            this.txTabControl1.SelectedIndex = 0;
            this.txTabControl1.Size = new System.Drawing.Size(609, 452);
            this.txTabControl1.TabCornerRadius = 3;
            this.txTabControl1.TabIndex = 0;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 485);
            this.Controls.Add(this.txTabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "IndexForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recoder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tab_video_cut.ResumeLayout(false);
            this.group_cut_videos.ResumeLayout(false);
            this.group_cut_videos.PerformLayout();
            this.group_merge_vidoes.ResumeLayout(false);
            this.group_merge_vidoes.PerformLayout();
            this.txTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notify_recording;
        private System.Windows.Forms.ContextMenuStrip notify_menu;
        private System.Windows.Forms.ToolStripMenuItem notify_menu_item_continue;
        private System.Windows.Forms.ToolStripMenuItem notify_menu_item_pause;
        private System.Windows.Forms.ToolStripMenuItem notify_menu_item_stop;
        private System.Windows.Forms.Timer timer_notify;
        private System.Windows.Forms.TabPage tab_video_cut;
        private System.Windows.Forms.GroupBox group_merge_vidoes;
        private System.Windows.Forms.Button btn_merge_list_remove;
        private System.Windows.Forms.Button btn_merge_list_down;
        private System.Windows.Forms.Button btn_merge_list_up;
        private TX.Framework.WindowUI.Controls.TXButton txButton3;
        private System.Windows.Forms.ListBox lbox_merge_video_list;
        private System.Windows.Forms.Label label15;
        private TX.Framework.WindowUI.Controls.TXButton btn_select_merge_videos;
        private System.Windows.Forms.GroupBox group_cut_videos;
        private TX.Framework.WindowUI.Controls.TXButton btn_select_cut_video;
        private System.Windows.Forms.Label label14;
        private TX.Framework.WindowUI.Controls.TXTabControl txTabControl1;
    }
}