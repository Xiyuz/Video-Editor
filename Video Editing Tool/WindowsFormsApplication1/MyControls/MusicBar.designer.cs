namespace DataStudioRecorder.MyControls
{
    partial class MusicBar
    {
        /// <summary> 
        /// Design Variable
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clear up all resources being used
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

        #region 

     
        private void InitializeComponent()
        {
            this.PlayButton = new DataStudioRecorder.MyControls.PlayButton();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.IsActive = true;
            this.PlayButton.Location = new System.Drawing.Point(0, 0);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(35, 35);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayButton_MouseDown);
            this.PlayButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlayButton_MouseMove);
            this.PlayButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayButton_MouseUp);
            // 
            // MusicBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PlayButton);
            this.Name = "MusicBar";
            this.Size = new System.Drawing.Size(345, 35);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MusicBar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MusicBar_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        public PlayButton PlayButton;
    }
}
