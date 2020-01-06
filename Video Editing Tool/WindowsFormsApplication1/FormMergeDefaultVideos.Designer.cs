using System;

namespace DataStudioRecorder
{
    partial class FormMergeDefaultVideos
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
            this.lb_pro = new System.Windows.Forms.Label();
            this.lb_msg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_pro_pre = new System.Windows.Forms.Panel();
            this.pn_pro_back = new System.Windows.Forms.Panel();
            this.btn_cancel = new TX.Framework.WindowUI.Controls.TXButton();
            this.btn_close = new TX.Framework.WindowUI.Controls.TXButton();
            this.btn_find = new TX.Framework.WindowUI.Controls.TXButton();
            this.SuspendLayout();
            // 
            // lb_pro
            // 
            this.lb_pro.AutoSize = true;
            this.lb_pro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_pro.Location = new System.Drawing.Point(161, 19);
            this.lb_pro.Name = "lb_pro";
            this.lb_pro.Size = new System.Drawing.Size(23, 15);
            this.lb_pro.TabIndex = 13;
            this.lb_pro.Text = "0%";
            // 
            // lb_msg
            // 
            this.lb_msg.AutoSize = true;
            this.lb_msg.Location = new System.Drawing.Point(26, 91);
            this.lb_msg.Name = "lb_msg";
            this.lb_msg.Size = new System.Drawing.Size(55, 15);
            this.lb_msg.TabIndex = 10;
            this.lb_msg.Text = "lb_msg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 9;
            // 
            // pn_pro_pre
            // 
            this.pn_pro_pre.BackColor = System.Drawing.Color.SlateBlue;
            this.pn_pro_pre.Location = new System.Drawing.Point(12, 48);
            this.pn_pro_pre.Name = "pn_pro_pre";
            this.pn_pro_pre.Size = new System.Drawing.Size(332, 30);
            this.pn_pro_pre.TabIndex = 15;
            // 
            // pn_pro_back
            // 
            this.pn_pro_back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pn_pro_back.Location = new System.Drawing.Point(12, 48);
            this.pn_pro_back.Name = "pn_pro_back";
            this.pn_pro_back.Size = new System.Drawing.Size(332, 30);
            this.pn_pro_back.TabIndex = 14;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Image = null;
            this.btn_cancel.Location = new System.Drawing.Point(127, 124);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 28);
            this.btn_cancel.TabIndex = 24;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_close
            // 
            this.btn_close.Image = null;
            this.btn_close.Location = new System.Drawing.Point(244, 124);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(100, 28);
            this.btn_close.TabIndex = 12;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Visible = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_find
            // 
            this.btn_find.Image = null;
            this.btn_find.Location = new System.Drawing.Point(12, 124);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(100, 28);
            this.btn_find.TabIndex = 11;
            this.btn_find.Text = "Find video\n\n";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Visible = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // FormMergeDefaultVideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 170);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lb_pro);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.lb_msg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pn_pro_pre);
            this.Controls.Add(this.pn_pro_back);
            this.Font = new System.Drawing.Font("宋体", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMergeDefaultVideos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Merge Video";
            this.Load += new System.EventHandler(this.FormMergeDefaultVideos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private TX.Framework.WindowUI.Controls.TXButton btn_close;
        private System.Windows.Forms.Label lb_pro;
        private TX.Framework.WindowUI.Controls.TXButton btn_find;
        private System.Windows.Forms.Label lb_msg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn_pro_pre;
        private System.Windows.Forms.Panel pn_pro_back;
        private TX.Framework.WindowUI.Controls.TXButton btn_cancel;
    }
}