using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;


namespace DataStudioRecorder.moduel
{
    public class UpFileResult
    {
        public bool flag { set; get; }
        bool success { set; get; }
        bool uploadOver { set; get; }
        long uploaded { set; get; }
        string file { set; get; }
    }

}
