using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStudioRecorder.utils
{
    public class VideoListUtils
    {
        public static VideoListUtils instance;
        public static VideoListUtils getInstance()
        {
            if (instance == null)
            {
                instance = new VideoListUtils();
            }
            return instance;
        }



        private VideoListUtils() { }
        private List<string> videos = new List<string>();
        private string oldName;

        public string getMergeName()
        {
            return oldName;
        }

        public void addVideo(string filePath)
        {
            int index = videos.Count + 1;
            if (index == 1)
            {
                oldName = filePath;
            }
            int splitIndex = filePath.LastIndexOf(".");
            string name = filePath.Substring(0, splitIndex);
            string suffix = filePath.Substring(splitIndex + 1, filePath.Length - splitIndex - 1);
            string file = filePath.Substring(0, splitIndex);
            string full_name = name + "_" + index + "." + suffix;
            videos.Add(full_name);
        }
        public List<string> getVideos()
        {
            return this.videos;
        }



    }
}
