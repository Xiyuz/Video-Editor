using DataStudioRecorder.utils;
using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DataStudioRecorder.configs;
using DataStudioRecorder.moduel;
using DataStudioRecorder.MyControls;
using System.Threading;


namespace DataStudioRecorder
{
    public partial class IndexForm : Form
    {        
   
        public IndexForm()
        {
            InitializeComponent();

        }




       
        
       
        private bool _status = true;
        

        

       
     
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a simple video tool. Copyright @ Xiyu Zhang");
        }
        #region Video Editing
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_select_cut_video_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectFile = new OpenFileDialog();

            RecordConf conf = ConfManager.readServerPath();
            selectFile.InitialDirectory = conf.record_save_dir;
            DialogResult result = selectFile.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            //Choose file
            string file = selectFile.FileName;
            FormPlayVideo playForm = new FormPlayVideo(file);
            playForm.ShowDialog();
        }
        #endregion
        #region Video editing allow different formats
        /// <summary>
        /// move up 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_merge_list_up_Click(object sender, EventArgs e)
        {

            int index = this.lbox_merge_video_list.SelectedIndex;
            if (index <= 0)
                return;
            
            object o = lbox_merge_video_list.Items[index];
            lbox_merge_video_list.Items.RemoveAt(index);
            index--;
            lbox_merge_video_list.Items.Insert(index, o);
            lbox_merge_video_list.SelectedIndex = index;

        }
        /// <summary>
        /// Move down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_merge_list_down_Click(object sender, EventArgs e)
        {
            
            int index = this.lbox_merge_video_list.SelectedIndex;
            if (index < 0)
                return;
            if (index + 2 > lbox_merge_video_list.Items.Count)
            {
                return;
            }
            //move down
            object o = lbox_merge_video_list.Items[index];
            lbox_merge_video_list.Items.RemoveAt(index);
            index++;
            lbox_merge_video_list.Items.Insert(index, o);
            lbox_merge_video_list.SelectedIndex = index;
        }
        /// <summary>
        /// remove a video from the list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_merge_list_remove_Click(object sender, EventArgs e)
        {
            int index = this.lbox_merge_video_list.SelectedIndex;
            if (index < 0)
                return;
            //remove
            lbox_merge_video_list.Items.RemoveAt(index);
            //reset the video list after delete
            if (lbox_merge_video_list.Items.Count <= 0)
                return;
            if (lbox_merge_video_list.Items.Count > index)
            {
                lbox_merge_video_list.SelectedIndex = index;
            }
            else if (lbox_merge_video_list.Items.Count > index - 1)
            {
                lbox_merge_video_list.SelectedIndex = index - 1;
            }


        }

        private void btn_select_merge_videos_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectFile = new OpenFileDialog();

            RecordConf conf = ConfManager.readServerPath();
            selectFile.InitialDirectory = conf.record_save_dir;
            selectFile.Multiselect = true;
            DialogResult result = selectFile.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            this.lbox_merge_video_list.DisplayMember = "fileName";
            this.lbox_merge_video_list.ValueMember = "filePath";

            //Choose file
            string[] files = selectFile.FileNames;
            string[] safeNames = selectFile.SafeFileNames;
            List<MergeFiles> mergeFiles = new List<MergeFiles>();
            for (int i = 0; i < files.Length; i++)
            {
                string path = files[i];
                string safe = safeNames[i];
                //Filter out the files already in the list
                bool isFound = false;
                foreach (object o in lbox_merge_video_list.Items)
                {
                    MergeFiles old = o as MergeFiles;
                   
                    if (old.filePath == path)
                    {
                        isFound = true;
                    }
                }
                if (isFound)
                    continue;
                
                MergeFiles mf = new MergeFiles();
                mf.filePath = path;
                mf.fileName = safe;
                this.lbox_merge_video_list.Items.Add(mf);
            }
        }
        /// <summary>
        /// Merge video
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txButton3_Click(object sender, EventArgs e)
        {
            if (this.lbox_merge_video_list.Items.Count < 2)
                return;
            SaveFileDialog sfd = new SaveFileDialog();

            string suffix = "mp4";
            sfd.Filter = "|*." + suffix;
            sfd.Title = "Save File";
            DialogResult result = sfd.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            List<string> inputFiles = new List<string>();
            foreach (object o in lbox_merge_video_list.Items)
            {
                MergeFiles old = o as MergeFiles;
                inputFiles.Add(old.filePath);
            }
            FormMergeDefaultVideos defaultMergeForm = new FormMergeDefaultVideos(inputFiles, sfd.FileName);
            defaultMergeForm.ShowDialog();
        }




        #endregion

        private void RecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }


}
