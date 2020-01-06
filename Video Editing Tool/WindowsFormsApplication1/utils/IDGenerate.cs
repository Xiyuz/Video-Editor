using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStudioRecorder.utils
{
    public class IDGenerate
    {
        /// <summary>
        /// Generate an unique ID for water mark 
        /// </summary>
        /// <returns></returns>
        public static long generateLong() {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            return BitConverter.ToInt64(buffer, 0);
        }
    }
}
