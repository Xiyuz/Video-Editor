namespace DataStudioRecorder
{
    partial class MergeVideos
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_msg = new System.Windows.Forms.Label();
            this.btn_find = new TX.Framework.WindowUI.Controls.TXButton();
            this.btn_close = new TX.Framework.WindowUI.Controls.TXButton();
            this.lb_pro = new System.Windows.Forms.Label();
            this.pn_pro_back = new System.Windows.Forms.Panel();
            this.pn_pro_pre = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // lb_msg
            // 
            this.lb_msg.AutoSize = true;
            this.lb_msg.Location = new System.Drawing.Point(39, 153);
            this.lb_msg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_msg.Name = "lb_msg";
            this.lb_msg.Size = new System.Drawing.Size(84, 20);
            this.lb_msg.TabIndex = 3;
            this.lb_msg.Text = "Progress...";
            this.lb_msg.Click += new System.EventHandler(this.lb_msg_Click);
            // 
            // btn_find
            // 
            this.btn_find.Image = null;
            this.btn_find.Location = new System.Drawing.Point(42, 208);
            this.btn_find.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(150, 47);
            this.btn_find.TabIndex = 4;
            this.btn_find.Text = "Find video\n\n";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Visible = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_close
            // 
            this.btn_close.Image = null;
            this.btn_close.Location = new System.Drawing.Point(308, 208);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(150, 47);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Visible = false;
            this.btn_close.Click += new System.EventHandler(this.txButton1_Click);
            // 
            // lb_pro
            // 
            this.lb_pro.AutoSize = true;
            this.lb_pro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_pro.Location = new System.Drawing.Point(242, 33);
            this.lb_pro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pro.Name = "lb_pro";
            this.lb_pro.Size = new System.Drawing.Size(32, 20);
            this.lb_pro.TabIndex = 6;
            this.lb_pro.Text = "0%";
            // 
            // pn_pro_back
            // 
            this.pn_pro_back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pn_pro_back.Location = new System.Drawing.Point(18, 82);
            this.pn_pro_back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pn_pro_back.Name = "pn_pro_back";
            this.pn_pro_back.Size = new System.Drawing.Size(498, 50);
            this.pn_pro_back.TabIndex = 7;
            // 
            // pn_pro_pre
            // 
            this.pn_pro_pre.BackColor = System.Drawing.Color.SlateBlue;
            this.pn_pro_pre.Location = new System.Drawing.Point(18, 82);
            this.pn_pro_pre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pn_pro_pre.Name = "pn_pro_pre";
            this.pn_pro_pre.Size = new System.Drawing.Size(498, 50);
            this.pn_pro_pre.TabIndex = 8;
            this.pn_pro_pre.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_pro_pre_Paint);
            // 
            // MergeVideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 283);
            this.Controls.Add(this.lb_pro);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.lb_msg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pn_pro_pre);
            this.Controls.Add(this.pn_pro_back);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MergeVideos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Video file processing";
            this.Load += new System.EventHandler(this.MergeVideos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_msg;
        private TX.Framework.WindowUI.Controls.TXButton btn_find;
        private TX.Framework.WindowUI.Controls.TXButton btn_close;
        private System.Windows.Forms.Label lb_pro;
        private System.Windows.Forms.Panel pn_pro_back;
        private System.Windows.Forms.Panel pn_pro_pre;
    }
}