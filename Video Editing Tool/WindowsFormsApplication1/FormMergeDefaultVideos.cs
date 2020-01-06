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
using static DataStudioRecorder.UnionDefaultVideos;

namespace DataStudioRecorder
{
    public partial class FormMergeDefaultVideos : Form
    {

        List<string> resouce_files;
        string out_put_file;
        UnionDefaultVideos unionVideos = new UnionDefaultVideos();
        public FormMergeDefaultVideos(List<string> resouce_files, string out_put_file)
        {
            this.resouce_files = resouce_files;
            this.out_put_file = out_put_file;
            InitializeComponent();
            pn_pro_pre.Width = 0;
            this.ControlBox = false;
            btn_find.Visible = false;
            btn_close.Visible = false;

            int x = pn_pro_back.Location.X + (pn_pro_back.Width - lb_pro.Size.Width) / 2;
            int y = pn_pro_back.Location.Y + (pn_pro_back.Height - lb_pro.Size.Height) / 2;
            this.lb_pro.Location = new Point(x, y);
            lb_pro.Parent = this;
            lb_msg.Text = "Processing Video";
        }
        private void FormMergeDefaultVideos_Load(object sender, EventArgs e)
        {

            Thread t = new Thread(new ThreadStart(mergeVideo));
            t.Start();
        }

        private void setPro(double progress)
        {
            this.lb_pro.Text = progress + "%";
            pn_pro_pre.Width = (int)(pn_pro_back.Width * progress / 100);
            Console.WriteLine(pn_pro_pre.Width + ":" + pn_pro_pre.Location.Y + ":" + lb_pro.Location.X);
            if (pn_pro_pre.Width + pn_pro_pre.Location.Y > lb_pro.Location.X)
            {
                lb_pro.BackColor = Color.SlateBlue;
            }
        }

        public void mergeVideo()
        {
            Thread.Sleep(50);

            //Merge
            List<string> videos = resouce_files;

            unionVideos.callBack = new DataCallBack<double>(delegate (double progress, string result_msg)
            {
                this.Invoke(new EventHandler(delegate
                {
                    setPro(progress);
                    lb_msg.Text = "Processing video file";
                }));
            });
            bool b = unionVideos.merge(videos, this.out_put_file);
            if (b)
            {
                this.Invoke(new EventHandler(delegate
                {
                    lb_msg.Text = "Video file processing complete";
                    setPro(100);
                }));
            }
            else
            {
                this.Invoke(new EventHandler(delegate
                {
                    this.lb_msg.Text = "Video file processing failed";
                }));
            }
            videos.Clear();
            this.Invoke(new EventHandler(delegate
            {
                btn_find.Visible = true;
                btn_close.Visible = true;
                this.btn_cancel.Visible = false;
            }));

        }
        private void txButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string path = this.out_put_file;
            int index = out_put_file.LastIndexOf("\\");
            string dir = out_put_file.Substring(0, index);
            //012345
            string file = out_put_file.Substring(index + 1, path.Length - index - 1);
            System.Diagnostics.Process.Start("Explorer", "/select," + path);
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            unionVideos.Stop();
            killProcess();
            if (File.Exists(this.out_put_file))
            {
                File.Delete(this.out_put_file);
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
    }
}