using DataStudioRecorder.utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace DataStudioRecorder
{
    static class Program
    {
        /// <summary>
        /// The start point of the program
        /// </summary>
        [STAThread]
        static void Main()
        {
            int processCount = 0;
            Process[] pa = Process.GetProcesses();
            foreach (Process PTest in pa)
            {
                if (PTest.ProcessName == Process.GetCurrentProcess().ProcessName)
                {
                    processCount += 1;
                }
            }
            if (processCount > 1)
            {
                //If the program is already running
                MessageBox.Show("Program is already running！");
                //Then exit
                return; //Exit;
            }

            SystemValues.str = "Video Tool";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         
            Application.Run(new IndexForm());

        }
    }
}
