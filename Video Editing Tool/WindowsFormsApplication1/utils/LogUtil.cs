using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace DataStudioRecorder.utils
{
    class LogUtil
    {
        public static string lockerStr = "load_lock";
        /// <summary>
        /// Making logs
        /// </summary>
        /// <param name="contents"></param>
        public static void appendError(String error)
        {
            
            lock (lockerStr)
            {
                string path = string.Concat(System.AppDomain.CurrentDomain.BaseDirectory, "\\error.log");

                System.IO.FileInfo fileInfo = null;
                try
                {
                    fileInfo = new System.IO.FileInfo(path);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
                if (fileInfo != null && fileInfo.Exists)
                {
                    long mb = fileInfo.Length / 1024 / 1024;
                    //if bigger than 100mb, delete it and make a new one
                    if (mb > 100)
                    {
                        File.Delete(path);
                    }
                }
                else
                {
                    Console.WriteLine("Wrong path!");
                }
                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                }
                StreamWriter sw = new StreamWriter(path, true);
          //      sw.WriteLine("error_time:" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                sw.WriteLine(error);
          //      sw.WriteLine();
                sw.Close();
            }
        }


        public static void appendError(Exception error)
        {

            lock (lockerStr)
            {
                string path = string.Concat(System.AppDomain.CurrentDomain.BaseDirectory, "\\error.log");

                System.IO.FileInfo fileInfo = null;
                try
                {
                    fileInfo = new System.IO.FileInfo(path);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if (fileInfo != null && fileInfo.Exists)
                {
                    long mb = fileInfo.Length / 1024 / 1024;

                    if (mb > 100)
                    {
                        File.Delete(path);
                    }
                }
                else
                {
                    Console.WriteLine("Wrong path!");
                }
                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                }
                StreamWriter sw = new StreamWriter(path, true);
                sw.WriteLine("error_time:" + DateTime.Now.ToLongTimeString());
                sw.WriteLine(error);
                sw.WriteLine();
                sw.Close();
            }
        }
    }
}
