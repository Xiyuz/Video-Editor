using DataStudioRecorder.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DataStudioRecorder.UnionVideos;

namespace DataStudioRecorder
{
    public partial class MergeVideos : Form
    {
        string old_fileName;
        public MergeVideos()
        {
           //buttons
            InitializeComponent();
            pn_pro_pre.Width = 0;
            this.ControlBox = false;
            btn_find.Visible = false;
            btn_close.Visible = false;

    
            int x = pn_pro_back.Location.X + (pn_pro_back.Width - lb_pro.Size.Width) / 2;
            int y = pn_pro_back.Location.Y + (pn_pro_back.Height - lb_pro.Size.Height) / 2;
            this.lb_pro.Location = new Point(x, y);
            lb_pro.Parent = this;
            //Processing video
            lb_msg.Text = "Processing Video";
            old_fileName = VideoListUtils.getInstance().getMergeName();
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

        private void MergeVideos_Load(object sender, EventArgs e)
        {
            //Merge
            List<string> videos = VideoListUtils.getInstance().getVideos();
            if (videos.Count == 1)
            {
               
                Thread t = new Thread(new ThreadStart(renameVideo));
                t.Start();
            }
            else
            {
                Thread t = new Thread(new ThreadStart(mergeVideo));
                t.Start();
            }
        }

        public void renameVideo()
        {

            //rename 
            List<string> videos = VideoListUtils.getInstance().getVideos();
            string old_file_path = videos[0];
            string name = old_file_path.Substring(0, old_file_path.LastIndexOf("_"));
            string suffix = old_file_path.Substring(old_file_path.LastIndexOf(".") + 1, old_file_path.Length - old_file_path.LastIndexOf(".") - 1);
            string save_file = name + "." + suffix;
            Thread.Sleep(100);
            File.Move(old_file_path, save_file);
            //Clear 
            videos.Clear();
            this.Invoke(new EventHandler(delegate
            {
                setPro(100);
                lb_msg.Text = "Video file processing complete";
                btn_find.Visible = true;
                btn_close.Visible = true;
            }));
        }

        public void mergeVideo()
        {
            Thread.Sleep(50);
            string old_file_path = VideoListUtils.getInstance().getMergeName();
            string name = old_file_path.Substring(0, old_file_path.LastIndexOf(".")) + ".txt";
            StreamWriter writer = File.CreateText(name);
            List<string> videos = VideoListUtils.getInstance().getVideos();
            foreach (string list in videos)
            {
                writer.WriteLine("file '" + list + "'");
            }
            writer.Close();
            UnionVideos unionVideos = new UnionVideos();
            unionVideos.callBack = new DataCallBack<double>(delegate (double progress, string result_msg)
            {
                this.Invoke(new EventHandler(delegate
                {
                    setPro(progress);
                    lb_msg.Text = "Processing video file";
                }));
            });
            bool b = unionVideos.merge(name, videos, old_file_path);
            if (b)
            {
                this.Invoke(new EventHandler(delegate
                {
                    setPro(99);
                    lb_msg.Text = "Verifying Video files";
                }));
                //Delete TXt
                File.Delete(name);
                 // Delete original video
                for (int i = 0; i < videos.Count; i++)
                {
                    File.Delete(videos[i]);
                }
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
                    this.lb_msg.Text = "Video file processing faild";
                }));

            }
            videos.Clear();
            this.Invoke(new EventHandler(delegate
            {
                btn_find.Visible = true;
                btn_close.Visible = true;
            }));

        }


        private void txButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string path = old_fileName.Replace(@"\\", @"\");
            int index = old_fileName.LastIndexOf("\\");
            string dir = old_fileName.Substring(0, index);
            //012345
            string file = old_fileName.Substring(index + 1, path.Length - index - 1);
            System.Diagnostics.Process.Start("Explorer", "/select," + path);
        }

        private void pn_pro_pre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_msg_Click(object sender, EventArgs e)
        {

        }
    }
}
