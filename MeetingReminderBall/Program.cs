using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MeetingReminderBall
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            

            //Kill Existing Balls
            Process self = Process.GetCurrentProcess();
            foreach (Process p in Process.GetProcesses())
            {
                if(p.Id != self.Id && p.ProcessName.Equals("MeetingReminderBall"))
                {
                    p.Kill();
                }
            }

            MeetingReminderForm f = new MeetingReminderForm();
            f.Show();
            
            while (true)
            {
                f.Tick();
                Application.DoEvents();
                Thread.Sleep(10);
            }
        }
    }
}
