using DataStudioRecorder.configs;
using DataStudioRecorder.moduel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DataStudioRecorder
{
    public partial class FormPlayVideo : Form
    {
        VlcPlayer vlc_player_;
        bool is_playinig_;
        Timer timer1 = new Timer();
        string FilePath = "";
        private string fileName;


        private double play_split_end_point;

        public FormPlayVideo(string fileName)
        {
            this.fileName = fileName;

            InitializeComponent();
            //Read progress every 0.3 s
            timer1.Interval = 300;
            timer1.Enabled = false;
            timer1.Tick += timer1_Tick;
            //Read c++ plugins
            string pluginPath = System.Environment.CurrentDirectory + "\\plugins\\";
            vlc_player_ = new VlcPlayer(pluginPath);
            IntPtr render_wnd = this.panel_info.Handle;
            vlc_player_.SetRenderWindow((int)render_wnd);
            this.PlayerTimeLabel.Text = "00:00:00/00:00:00";
            is_playinig_ = false;
        }

        private void FormPlayVideo_Load(object sender, EventArgs e)
        {
            this.Text = this.fileName;
            FilePath = fileName;
            //Start playing
            vlc_player_.PlayFile(fileName);
            //Assign time to play progress bar
            PlayertrackBar.MaxValue = vlc_player_.Duration();
            play_split_end_point = vlc_player_.Duration();
            //default to 0
            PlayertrackBar.Value = 0;

            //timer start
            timer1.Start();
            is_playinig_ = true;
        }

        //Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (is_playinig_)
            {
                this.PlayertrackBar.Value = vlc_player_.GetPlayTime();
                Console.WriteLine(this.PlayertrackBar.Value + ":" + this.play_split_end_point);
                if (this.PlayertrackBar.Value == PlayertrackBar.MaxValue)//If finish playing
                {
                    vlc_player_.Stop();
                    timer1.Stop();
                    this.p = PlayOrPause.Stop;
                    this.btn_play.Text = "Replay";
                    is_playinig_ = false;
                }
                else if (this.PlayertrackBar.Value >= this.play_split_end_point)
                {
                    vlc_player_.Pause();
                    timer1.Stop();
                    this.p = PlayOrPause.Pause;
                    this.btn_play.Text = "Play";
                    is_playinig_ = false;
                    this.play_split_end_point = vlc_player_.Duration();
                }
                PlayerTimeLabel.Text = string.Format("{0}/{1}",
                    GetTimeString(PlayertrackBar.Value),
                    GetTimeString(PlayertrackBar.MaxValue));


            }
        }

        //Get time string
        private string GetTimeString(double val)
        {
            double hour = val / 3600;
            val %= 3600;
            double minute = val / 60;
            double second = val % 60;
            return string.Format("{0:00}:{1:00}:{2:00}", hour, minute, second);
        }


        private void PlayertrackBar_Scroll(object sender, EventArgs e)
        {
            double thisValue = PlayertrackBar.Value;
            vlc_player_.SetPlayTime(thisValue);
        }
        PlayOrPause p = PlayOrPause.Play;
        /// <summary>
        /// click to pause and stop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            playOrPause();

        }
        //fast forward a second
        private void btn_forward_1_Click(object sender, EventArgs e)
        {
            if (vlc_player_.GetPlayTime() + 1 >= (vlc_player_.Duration()))
            {
                this.vlc_player_.SetPlayTime(vlc_player_.Duration());
                PlayertrackBar.Value = vlc_player_.Duration();
                PlayerTimeLabel.Text = string.Format("{0}/{1}",
                   GetTimeString(PlayertrackBar.Value),
                   GetTimeString(PlayertrackBar.MaxValue));
            }
            else
            {
                this.vlc_player_.SetPlayTime(this.vlc_player_.GetPlayTime() + 1);
                PlayertrackBar.Value = vlc_player_.GetPlayTime();
                PlayerTimeLabel.Text = string.Format("{0}/{1}",
                    GetTimeString(PlayertrackBar.Value),
                    GetTimeString(PlayertrackBar.MaxValue));
            }
        }
        //backforward a second
        private void btn_back_1_Click(object sender, EventArgs e)
        {
            if (vlc_player_.GetPlayTime() - 1 < 0)
            {
                this.vlc_player_.SetPlayTime(0);
                PlayertrackBar.Value = vlc_player_.GetPlayTime();
                PlayerTimeLabel.Text = string.Format("{0}/{1}",
                    GetTimeString(PlayertrackBar.Value),
                    GetTimeString(PlayertrackBar.MaxValue));
            }
            else
            {
                this.vlc_player_.SetPlayTime(this.vlc_player_.GetPlayTime() - 1);
                PlayertrackBar.Value = vlc_player_.GetPlayTime();
                PlayerTimeLabel.Text = string.Format("{0}/{1}",
                    GetTimeString(PlayertrackBar.Value),
                    GetTimeString(PlayertrackBar.MaxValue));
            }
        }
        //play or pause
        private void playOrPause()
        {
            if (p == PlayOrPause.Play)
            {

                vlc_player_.Pause();
                timer1.Stop();
                is_playinig_ = false;
                btn_play.Text = "Play";
                p = PlayOrPause.Pause;
            }
            else if (p == PlayOrPause.Pause)
            {
                vlc_player_.PlayFile(FilePath);
                double i = PlayertrackBar.Value;
                vlc_player_.SetPlayTime(i);
                timer1.Start();
                is_playinig_ = true;
                btn_play.Text = "Pause";
                p = PlayOrPause.Play;
            }

            else if (p == PlayOrPause.Stop)
            {
                PlayertrackBar.Value = 0;
                timer1.Start();
                vlc_player_.PlayFile(FilePath);
                vlc_player_.SetPlayTime(0);
                is_playinig_ = true;
                btn_play.Text = "Pause";
                p = PlayOrPause.Play;
            }
        }

        private void PlayertrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            double thisValue = PlayertrackBar.Value;
            Console.WriteLine(thisValue);
            vlc_player_.SetPlayTime(thisValue);
        }

        private void PlayertrackBar_OnValueChanged(MyControls.MusicBar sender, double Value)
        {
            double thisValue = Value;
            vlc_player_.SetPlayTime(thisValue);
            if (p == PlayOrPause.Stop)
            {
                timer1.Start();
                vlc_player_.PlayFile(FilePath);
                vlc_player_.SetPlayTime(thisValue);
                is_playinig_ = true;
                btn_play.Text = "Pause";
                p = PlayOrPause.Play;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_split_start_Click(object sender, EventArgs e)
        {
            double split = PlayertrackBar.Value;
            this.txt_split_start.Tag = split;
            this.txt_split_start.Text = GetTimeString(split);

        }

        private void btn_split_end_Click(object sender, EventArgs e)
        {
            double split = PlayertrackBar.Value;
            this.txt_split_end.Text = GetTimeString(PlayertrackBar.Value);
            this.txt_split_end.Tag = split;
        }
       
        private void btn_split_pre_Click(object sender, EventArgs e)
        {
            double start = 0;
            double end = this.PlayertrackBar.MaxValue;
            if (txt_split_start.Text != "")
            {
                start = double.Parse(txt_split_start.Tag.ToString());
            }
            if (txt_split_end.Text != "")
            {
                end = double.Parse(txt_split_end.Tag.ToString());
            }
            timer1.Stop();
            vlc_player_.Stop();

            this.play_split_end_point = end;

            is_playinig_ = true;
            btn_play.Text = "Pause";
            p = PlayOrPause.Play;

            vlc_player_.PlayFile(FilePath);
            vlc_player_.SetPlayTime(start);
            PlayertrackBar.Value = start;
            timer1.Start();

        }
        private void PlayertrackBar_MouseHover(object sender, MouseEventArgs e)
        {
           
        }
        private void PlayertrackBar_MouseLeave(object sender, EventArgs e)
        {
            this.label1.Visible = false;
        }
        //Get keyboard event
        protected override bool ProcessDialogKey(Keys keyData)

        {
            switch (keyData)
            {
                case Keys.Escape:
                  
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    break;
                case Keys.Space:
                    playOrPause();
                    break;
            }
            return true;

        }
        //Double click
        private void piBox_panel_info_DoubleClick_1(object sender, EventArgs e)
        {
            
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_split_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_split_start.Text) && string.IsNullOrEmpty(txt_split_end.Text))
            {
                return;
            }
            //Stop playing
            vlc_player_.Stop();
            timer1.Stop();
            is_playinig_ = false;
            btn_play.Text = "Replay";
            p = PlayOrPause.Stop;
            //Pop dialog window
            SaveFileDialog sfd = new SaveFileDialog();

            //get filename suffix
            int index = fileName.LastIndexOf(".");
            if (index > -1)
            {
                string suffix = fileName.Substring(index + 1, fileName.Length - index - 1);
                sfd.Filter = "|*." + suffix;
            }
            sfd.Title = "Save captured video";
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string saveFile = sfd.FileName;
                try
                {
                    if (File.Exists(saveFile))
                    {
                        File.Delete(saveFile);
                    }
                    File.Create(saveFile).Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                string start = "00:00:00";
                string end = this.GetTimeString(this.PlayertrackBar.MaxValue);
                if (txt_split_start.Text != "")
                {
                    start = txt_split_start.Text;
                }
                if (txt_split_end.Text != "")
                {
                    end = txt_split_end.Text;
                }
                timer1.Stop();
                vlc_player_.Stop();
                //Enable screen shot
                FormSplitVideo splitForm = new FormSplitVideo(this.fileName, saveFile, start, end);
                splitForm.ShowDialog();
            }
        }

        private void FormPlayVideo_FormClosing(object sender, FormClosingEventArgs e)
        {
            vlc_player_.Stop();
        }

        private void btn_ScreenshotFrame_Click(object sender, EventArgs e)
        {
            //Get path to save the file
            RecordConf conf = ConfManager.readServerPath();

            double split = PlayertrackBar.Value;
            string time = GetTimeString(split);
            string outputName = DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".jpg";
            string outputFile = conf.record_save_dir + @"\" + outputName;
            ScreenShotVideoFrame cv = new ScreenShotVideoFrame();
            bool b = cv.chouzhen(this.FilePath, time, outputFile);
            System.Diagnostics.Process.Start("Explorer", "/select," + outputFile);
        }
    }
    public enum PlayOrPause : int
    {
        Pause = 0, Play = 1, Stop = 2
    }
}
