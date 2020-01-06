using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DataStudioRecorder.SplitVideos;

namespace DataStudioRecorder
{
    public partial class FormSplitVideo : Form
    {
        string resource_file;
        string save_file;
        string start_time;
        string end_time;
        SplitVideos splitVideo = new SplitVideos();
        /// <summary>
        /// Initialize screen shot window
        /// </summary>
        /// <param name="resource_file"></param>
        /// <param name="save_file"></param>
        /// <param name="start_time"></param>
        /// <param name="end_time"></param>
        public FormSplitVideo(string resource_file, string save_file, string start_time, string end_time)
        {
            this.resource_file = resource_file;
            this.save_file = save_file;
            this.start_time = start_time;
            this.end_time = end_time;
            InitializeComponent();

        }

        private void FormSplitVideo_Load(object sender, EventArgs e)
        {
            
            int x = pn_pro_back.Location.X + (pn_pro_back.Width - lb_pro.Size.Width) / 2;
            int y = pn_pro_back.Location.Y + (pn_pro_back.Height - lb_pro.Size.Height) / 2;
            this.lb_pro.Location = new Point(x, y);
            lb_pro.Parent = this;
            this.ControlBox = false;
            this.btn_find.Visible = false;
            this.btn_close.Visible = false;

            
            this.lb_msg.Text = "Detecting file information";
            if (!File.Exists(this.resource_file))
            {
                this.lb_msg.Text = "file does not exist";
                this.btn_close.Visible = true;
                return;
            }
            this.lb_msg.Text = "Start Clipping";
            setPro(0);
            Thread t = new Thread(new ThreadStart(split));
            t.Start();
        }

        public void split()
        {
            Thread.Sleep(50);


            splitVideo.callBack = new DataCallBack<double>(delegate (double progress, string result_msg)
            {
                this.Invoke(new EventHandler(delegate
                {
                    setPro(progress);
                    lb_msg.Text = "Processing video file";
                }));
            });
            bool b = splitVideo.split(this.resource_file, this.save_file, this.start_time, this.end_time);
            if (b)
            {
                this.Invoke(new EventHandler(delegate
                {
                    lb_msg.Text = "Video file processing complete";
                    setPro(100);
                    btn_find.Visible = true;
                    this.btn_cancel.Visible = false;
                }));
            }
            else
            {
                this.Invoke(new EventHandler(delegate
                {
                    this.lb_msg.Text = "Video file processing failed";
                }));

            }
            this.Invoke(new EventHandler(delegate
            {

                btn_close.Visible = true;
            }));

        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            splitVideo.Stop();
            killProcess();
            if (File.Exists(this.save_file))
            {
                File.Delete(this.save_file);
            }
            this.btn_cancel.Visible = false;
            
            this.btn_close.Visible = true;
            
        }

        void killProcess()
        {
            Process[] pro = Process.GetProcesses();


            for (int i = 0; i < pro.Length; i++)
            {
                if (pro[i].ProcessName.ToString().ToLower() == "ffmpeg")
                {
                    pro[i].Kill();
                }
            }
        }


        private void setPro(double progress)
        {
            string str = string.Format("{0:F}", progress);
            progress = double.Parse(str);
            this.lb_pro.Text = progress + "%";
            pn_pro_pre.Width = (int)(pn_pro_back.Width * progress / 100);
            Console.WriteLine(pn_pro_pre.Width + ":" + pn_pro_pre.Location.Y + ":" + lb_pro.Location.X);
            if (pn_pro_pre.Width + pn_pro_pre.Location.Y > lb_pro.Location.X)
            {
                lb_pro.BackColor = Color.SlateBlue;
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string path = this.save_file;
            int index = save_file.LastIndexOf("\\");
            string dir = save_file.Substring(0, index);
            //012345
            string file = save_file.Substring(index + 1, path.Length - index - 1);
            System.Diagnostics.Process.Start("Explorer", "/select," + path);
        }


    }
}
