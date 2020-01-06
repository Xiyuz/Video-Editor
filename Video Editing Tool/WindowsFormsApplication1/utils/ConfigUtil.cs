using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using ThinkdataClient.util.ui;
using ThinkdataClient.model.system;
using ThinkdataClient.util.json;

namespace DiskMatrixsClient.util
{
    /// <summary>
    /// config
    /// </summary>
    class ConfigUtil
    {
        /// <summary>
        /// read path
        /// </summary>
        /// <returns></returns>
        public static string[] readServerPath()
        {

            string path = string.Concat(System.AppDomain.CurrentDomain.BaseDirectory, "\\data\\config.db");
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }
            string read = File.ReadAllText(path);
            string[] ips = read.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            return ips;
        }

        /// <summary>
        /// save path
        /// </summary>
        /// <param name="path"></param>
        public static void saveServerPath(string server_path)
        {
            string path = string.Concat(System.AppDomain.CurrentDomain.BaseDirectory, "\\data\\config.db");
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            File.WriteAllText(path, server_path);
        }

        /// <summary>
        /// read service path
        /// </summary>
        /// <returns></returns>
        public static String readServicePath()
        {

            string path = string.Concat(System.AppDomain.CurrentDomain.BaseDirectory, "\\data\\service.db");
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }
            String read = File.ReadAllText(path);
            return read;
        }

        /// <summary>
        /// read shared path
        /// </summary>
        /// <returns></returns>
        public static String readSharePath()
        {

            string path = string.Concat(System.AppDomain.CurrentDomain.BaseDirectory, "\\data\\share.db");
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }
            String read = File.ReadAllText(path);
            return read;
        }


        /// <summary>
        /// read web path
        /// </summary>
        /// <returns></returns>
        public static String readWebPath()
        {

            string path = string.Concat(System.AppDomain.CurrentDomain.BaseDirectory, "\\data\\web.db");
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }
            String read = File.ReadAllText(path);
            return read;
        }

        /// <summary>
        /// read title
        /// </summary>
        /// <returns></returns>
        public static String readTitle()
        {

            string path = string.Concat(System.AppDomain.CurrentDomain.BaseDirectory, "\\data\\title.db");
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }
            String read = File.ReadAllText(path);
            return read;
        }

    }
}
