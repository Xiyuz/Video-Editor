using DataStudioRecorder.utils;
using Microsoft.DirectX.DirectSound;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace DataStudioRecorder
{
    public class UnionDefaultVideos
    {

        public delegate void DataCallBack<T>(T t, string msg);

        public DataCallBack<double> callBack;

        public UnionDefaultVideos()
        {

        }

        #region all the api needed

        [DllImport("kernel32.dll")]
        static extern bool GenerateConsoleCtrlEvent(int dwCtrlEvent, int dwProcessGroupId);

        [DllImport("kernel32.dll")]
        static extern bool SetConsoleCtrlHandler(IntPtr handlerRoutine, bool add);

        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);

        [DllImport("kernel32.dll")]
        static extern bool FreeConsole();

        #endregion
        public string status { set; get; }

        /// <summary>
        /// Total length of video
        /// </summary>
        private double videoTime;

        // ffmpeg process
        Process p = new Process();
        // ffmpeg.exe path file
        string ffmpegPath = AppDomain.CurrentDomain.BaseDirectory + "ffmpeg\\ffmpeg.exe";

        /// <summary>
        /// get a list of sould input devices
        /// </summary>
        /// <returns>sound input devices</returns>
        public CaptureDevicesCollection GetAudioList()
        {
            CaptureDevicesCollection collection = new CaptureDevicesCollection();
            DevicesCollection c = new DevicesCollection();
            return collection;
        }
        /// <summary>
        /// connect to videos
        /// </summary>
        /// <param name="txtFile"></param>
        /// <param name="file_list"></param>
        /// <param name="outFilePath"></param>
        /// <returns></returns>
        public bool merge(List<string> file_list, string outFilePath)
        {
            //calculate total time
            double time = 0;
            string input = "";
            string filter = "";
            int i = 0;
            foreach (string f in file_list)
            {
                input += " -i " + f;
         //       filter += string.Format(" [{0}:1]", i);
                time += GetVideoDuration("\"" + f + "\"");
                i++;
            }
            videoTime = time;


            ProcessStartInfo startInfo = new ProcessStartInfo(ffmpegPath);
            startInfo.WindowStyle = ProcessWindowStyle.Normal;





            string argus = "{0} -filter_complex \"{1} concat=n={2}:v=1:a=1 [v] [a]\" -map \"[v]\" -map \"[a]\" -vcodec libx264 {3} -y";
            argus = string.Format(argus, input, filter, file_list.Count, outFilePath);

            startInfo.Arguments = argus;
            p.StartInfo = startInfo;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.ErrorDataReceived += new DataReceivedEventHandler(Output);
            p.Start();
            p.BeginErrorReadLine();
            p.WaitForExit();
            Console.WriteLine("___________:Done！");
            int status = p.ExitCode;
            return status == 0;

        }

        private void Output(object sendProcess, DataReceivedEventArgs output)
        {
            if (!String.IsNullOrEmpty(output.Data) && status != "stop")
            {

                LogUtil.appendError(output.Data);

                string message = output.Data;
                int reg = message.IndexOf(" time=");
                Console.Write(reg + ":" + message);
                if (reg < 0)
                {
                    return;
                }
                string time = message.Substring(reg + (" time=").Length, ("00:00:00").Length);

                double progress = Math.Round(timeStrToTimeInt(time) / videoTime, 4) * 100;
                Console.WriteLine(progress);
                if (progress > 100 || progress < 0)
                {
                    return;
                }
                callBack(progress, "");



            }
        }

        /// <summary>
        /// Get time
        /// </summary>
        /// <param name="fileUrl"></param>
        /// <returns></returns>
        private double GetVideoDuration(string fileUrl)
        {
            try
            {
                string commed = " -i " + fileUrl;
                Process p = new Process();
                p.StartInfo.FileName = ffmpegPath;
                p.StartInfo.Arguments = commed;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                StreamReader errorreader = p.StandardError;
                p.WaitForExit();
                string result = errorreader.ReadToEnd();
                p.Close();
                p.Dispose();
                string timeStr = result.Substring(result.IndexOf("Duration: ") + ("Duration: ").Length, ("00:00:00").Length);
                return timeStrToTimeInt(timeStr);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        /// <summary>
        /// convert string to time
        /// </summary>
        /// <param name="timeStr"></param>
        /// <returns></returns>
        private double timeStrToTimeInt(string timeStr)
        {
            double second = 0;
            string[] ts = timeStr.Split(':');
            try
            {
                second = double.Parse(ts[0]) * 60 * 60;
                second += double.Parse(ts[1]) * 60;
                second += double.Parse(ts[2]);
            }
            catch (Exception ex)
            {
                LogUtil.appendError(ex);
                Console.WriteLine(ex);
            }
            return second;
        }
        /// <summary>
        /// stop recording
        /// </summary>
        public void Stop()
        {
            AttachConsole(p.Id);
            SetConsoleCtrlHandler(IntPtr.Zero, true);
            GenerateConsoleCtrlEvent(0, 0);
            Thread.Sleep(1000);
            FreeConsole();
            SetConsoleCtrlHandler(IntPtr.Zero, false);
            status = "stop";
        }


    }
}
