using DataStudioRecorder.utils;
using Microsoft.DirectX.DirectSound;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace DataStudioRecorder
{
    public class SplitVideos
    {

        public delegate void DataCallBack<T>(T t, string msg);

        public DataCallBack<double> callBack;

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
        /// TTotal length of video
        /// </summary>
        private double videoTime;

        // ffmpeg process
        Process p = new Process();
        // ffmpeg.exe file path
        string ffmpegPath = AppDomain.CurrentDomain.BaseDirectory + "ffmpeg\\ffmpeg.exe";


        /// <summary>
        /// Video Split
        /// </summary>
        /// <param name="source_file"></param>
        /// <param name="target_file"></param>
        /// <param name="startpoint"></param>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public bool split(string source_file, string target_file, string startpoint, string endpoint)
        {
            //Calculate the total length of video
            double time = 0;
            time = this.timeStrToTimeInt(endpoint);
            time -= this.timeStrToTimeInt(startpoint);
            videoTime = time;


            
             /* target：Desktop；
             * audio recording：dshow；
             * format：h.264；*/
            ProcessStartInfo startInfo = new ProcessStartInfo(ffmpegPath);
            startInfo.WindowStyle = ProcessWindowStyle.Normal;

            //  ffmpeg.exe -ss 00:00:03 - to 00:00:08 - i 2018121115443525.mp4 -intra out.mp4 - y
            string argus = "-ss {1} -to {2} -i {0} -intra {3} -y";
            argus = string.Format(argus, source_file, startpoint, endpoint, target_file);

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

                double progress = Math.Round(timeStrToTimeInt(time) / videoTime, 4) * 100;//keep two decimal places
                Console.WriteLine(timeStrToTimeInt(time) + "/" + videoTime + "     " + progress);
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
        /// Stop recording
        /// </summary>
        public void Stop()
        {
            AttachConsole(p.Id);
            SetConsoleCtrlHandler(IntPtr.Zero, true);
            GenerateConsoleCtrlEvent(0, 0);
            Thread.Sleep(1000); //wait sometime
            FreeConsole();
            SetConsoleCtrlHandler(IntPtr.Zero, false);
            status = "stop";
        }


    }
}
