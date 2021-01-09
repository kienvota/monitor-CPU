using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace da_hđh
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fCPU = pCPU.NextValue();
            float fRAM = pRAM.NextValue();

            progressBarCPU.Value = (int)fCPU;
            lbCPU.Text = string.Format("{0:0.00}%", fCPU);
            progressBarRAM.Value = (int)fRAM;
            lbRAM.Text = string.Format("{0:0.00}%", fRAM);
            chart1.Series["CPU"].Points.AddY(fCPU);
            chart1.Series["RAM"].Points.AddY(fRAM);

            int iThread = (int)pThread.NextValue();
            lbThread.Text = "Số Thread :" + iThread;

            int iHandle = (int)pHandle.NextValue();
            lbHandle.Text = "Số Handle :" + iHandle;

            

            //lbSpeed.Text = ("Speed : " + getd());

            TimeSpan ts = TimeSpan.FromSeconds(pUpTime.NextValue());
            lbUpTime.Text = ("Up Time: " + ts.Days + ":" + ts.Hours + ":" + ts.Minutes + ":" + ts.Seconds);

            ManagementObjectSearcher ClockSpeedSearch = new ManagementObjectSearcher("select CurrentClockSpeed from Win32_Processor");


            foreach (var item in ClockSpeedSearch.Get())
            {
                var clockSpeed = (uint)item["CurrentClockSpeed"];
                lbSpeed.Invoke((MethodInvoker)(() => lbSpeed.Text = "CPU Clock Speed: " + clockSpeed + "Mhz"));
            }
        }



        private void Form1_Load_1(object sender, EventArgs e)
        {
            timer.Start();
        }

        /* public uint GetCpuSpeed()
         {
             var managementObject = new ManagementObject("Win32_Processor.DeviceID='CPU0'");
             var speed = (uint)(managementObject["CurrentClockSpeed"]);
             managementObject.Dispose();
             return speed;
         }
         */
        private string getCPU()
        {
            ManagementClass mObject = new ManagementClass("Win32_Processor");
            mObject.Get();
            if (mObject.Properties["MaxClockSpeed"].Value != null)
                return (String)mObject.Properties["MaxClockSpeed"].Value;
            else return "k ";
        }

        private void lbUpTime_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
