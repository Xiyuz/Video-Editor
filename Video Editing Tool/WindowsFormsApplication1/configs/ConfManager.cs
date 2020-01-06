using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStudioRecorder.moduel;
using System.Windows.Forms;

namespace DataStudioRecorder.configs
{
    public class ConfManager
    {
        /// <summary>
        /// Read config path
        /// </summary>
        /// <returns></returns>
        public static RecordConf readServerPath()
        {
            try
            {
                string path = string.Concat(System.AppDomain.CurrentDomain.BaseDirectory, "\\data\\config.db");

                if (!File.Exists(path))
                {
                    FileStream fs = File.Create(path);
                    fs.Close();
                    return new RecordConf();
                }

                string read = File.ReadAllText(path);
                RecordConf conf = JsonHelper.DeserializeJsonToObject<RecordConf>(read);
                if (conf == null)
                {
                    return new RecordConf();
                }
                return conf;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new RecordConf();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public static void saveServerPath(RecordConf conf)
        {
            string path = string.Concat(System.AppDomain.CurrentDomain.BaseDirectory, "\\data\\config.db");
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            string json = JsonHelper.SerializeObject(conf);
            File.WriteAllText(path, json);
        }


    }
}
