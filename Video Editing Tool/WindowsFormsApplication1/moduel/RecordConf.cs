using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace DataStudioRecorder.moduel
{
    public class RecordConf
    {
        /// <summary>
        /// Default folder to save the screen recording
        /// </summary>
        public string record_save_dir { set; get; }
        /// <summary>
        /// The bit rate
        /// </summary>
        public string record_rate { set; get; }
        /// <summary>
        /// Whether to include sound
        /// </summary>
        public bool record_system_sound { set; get; }
        /// <summary>
        /// Choose the microphone
        /// </summary>
        public string mic_device { set; get; }

        /// <summary>
        /// water marks
        /// </summary>
        public int water { set; get; }
        /// <summary>
        /// text watermark
        /// </summary>
        public string water_text { set; get; }
        /// <summary>
        /// image watermark
        /// </summary>
        public string water_img { set; get; }



    }
}
