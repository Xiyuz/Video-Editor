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

namespace DataStudioRecorder
{
    public class UnionVideos
    {

        public delegate void DataCallBack<T>(T t, string msg);

        public DataCallBack<double> callBack;

        public UnionVideos()
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
        /// total length of videos
        /// </summary>
        private double videoTime;

        // ffmpeg process
        Process p = new Process();
        // ffmpeg.exe file path
        string ffmpegPath = AppDomain.CurrentDomain.BaseDirectory + "ffmpeg\\ffmpeg.exe";

        /// <summary>
        /// get a list sound input devices
        /// </summary>
        /// <returns>list of sound input devices</returns>
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
        public bool merge(string txtFile, List<string> file_list, string outFilePath)
        {
            //calculate total length of time
            double time = 0;
            foreach (string f in file_list)
            {
                string fPtah = f;
                time += GetVideoDuration("\"" + fPtah + "\"");
            }
            videoTime = time;

            ProcessStartInfo startInfo = new ProcessStartInfo(ffmpegPath);
            startInfo.WindowStyle = ProcessWindowStyle.Normal;

            string argus = "-f concat  -safe 0  -i {0}  -c copy {1}";
            argus = string.Format(argus, txtFile, outFilePath);

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
            if (!String.IsNullOrEmpty(output.Data))
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


    }
}
