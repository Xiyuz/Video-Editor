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
    public class ScreenShotVideoFrame
    {

        public delegate void DataCallBack<T>(T t, string msg);

        public DataCallBack<double> callBack;

        public ScreenShotVideoFrame()
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
        /// Total length of merged video
        /// </summary>
        private double videoTime;

        // ffmpeg process
        Process p = new Process();
        // ffmpeg.exe file path
        string ffmpegPath = AppDomain.CurrentDomain.BaseDirectory + "ffmpeg\\ffmpeg.exe";

        /// <summary>
        /// Get a list of sound input devices
        /// </summary>
        /// <returns>list of sould input devices</returns>
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
        public bool chouzhen(string inputFile, string time, string outFilePath)
        {


      
             /* target：Desktop；
             * audio recording：dshow；
             * format：h.264；*/
            ProcessStartInfo startInfo = new ProcessStartInfo(ffmpegPath);
            startInfo.WindowStyle = ProcessWindowStyle.Normal;


            string argus = "-ss {1}  -i {0} -f image2 -vframes 1 -y {2}";
            argus = string.Format(argus, inputFile, time, outFilePath);

            startInfo.Arguments = argus;
            p.StartInfo = startInfo;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardError = true;//ffmpeg writes to StandardError
            p.StartInfo.CreateNoWindow = true;//Do not create window
            p.ErrorDataReceived += new DataReceivedEventHandler(Output);
            p.Start();
            p.BeginErrorReadLine();//Read StandartError
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
