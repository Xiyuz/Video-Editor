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
using TX.Framework.WindowUI.Forms;
using DataStudioRecorder.configs;
using DataStudioRecorder.moduel;
using DataStudioRecorder.MyControls;

namespace DataStudioRecorder
{
    public partial class IndexForm : Form
    {
        TestMicPro testMic;
        string water_img_path = "";
        KeyboardHook k_hook;
        public IndexForm()
        {
            InitializeComponent();

        }
 



        /// <summary>
        /// Get devices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IndexForm_Load(object sender, EventArgs e)
        {
            reloadMicDevice();

            RecordConf conf = ConfManager.readServerPath();
         

            k_hook = new KeyboardHook();
            //k_hook.KeyPressEvent += K_hook_KeyPressEvent;
            k_hook.KeyDownEvent += hook_KeyDown;
            k_hook.Start();


            this.Text = SystemValues.str;
            this.lb_test_mic_msg.Visible = false;
            this.btn_test_mic_stop.Enabled = false;
            this.StrartMenuItem.Enabled = true;
            this.stopRecordMenuItem.Enabled = false;
            this.pauseMenuItem.Enabled = false;

        }



        private void IndexForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            k_hook.Stop();

        }

        private void IndexForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
