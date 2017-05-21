using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using System.Threading;
using System.Drawing.Text;
using System.IO;
using KhaozAlwaysRunning.Communications;

namespace KhaozAlwaysRunningForm
{
    public partial class DisplayForm : Form
    {
        private static string[] Running = new string[] { "Khaoz Always On.../", "Khaoz Always On...-", "Khaoz Always On...\\", "Khaoz Always On...|" };
        private static bool isBatteryPower = false;
        private static PerformanceCounter CPUCounter = new PerformanceCounter();

        private static int Count = 0;
        private static double CpuUsage = 0;
        private static int CPUAVG = 0;

        private bool PlexProtection;
        private bool BattNotify;

        public DisplayForm()
        {
            InitializeComponent();
            InitCustomLabelFont();

            CPUCounter.CategoryName = "Processor";
            CPUCounter.CounterName = "% Processor Time";
            CPUCounter.InstanceName = "_Total";

            CPUCounter.NextValue(); CPUCounter.NextValue();

            Display();
            LblBattey.Text = "On Charge";
            //LblCPU.Text = "CPU: " + CPUUsageDisplay(CPUCounter.NextValue()) + " %";
            TmrInterval.Start();

            BtnClick.Visible = false;
        }

        private void TmrInterval_Tick(object sender, EventArgs e)
        {
            Display();
        }

        private void Display()
        {
            Count = Count < 3 ? Count + 1 : 0;

            LblHeading.Text = Running[Count];

            CpuUsage = CPUCounter.NextValue();

            if (Count == 3)
            {
                #region Battery
                if (System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline) //On Battery
                {
                    if ( (isBatteryPower == false) && (BattNotify) )
                    {
                        Communicate.sendNotification(isBatteryPower);
                        isBatteryPower = true;
                    }
                    LblBattey.Text = "On Battery";
                }
                else // Plugged In
                {
                    if ( (isBatteryPower == true) && (BattNotify) )
                    {
                        Communicate.sendNotification(isBatteryPower);
                        isBatteryPower = false;
                    }
                    LblBattey.Text = "On Charge";
                }
                #endregion Battery

                #region cpuAverage
                CPUAVG = Convert.ToInt32((CpuUsage + CPUAVG) / 2);
                if(CPUAVG > 90)
                {
                    if(PlexProtection)
                    {
                        KillPlex();
                    }
                }
                #endregion
            }

            LblCPU.Text = "CPU: " + CPUUsageDisplay(CpuUsage) + " %";
        }

        private string CPUUsageDisplay(double CPU)
        {
            string temp = CPU.ToString("00.00");
            
            if (temp.Substring(0, 1).Equals("0"))
                return " " + temp.Substring(1);
            else
                return temp;
        }

        private void InitCustomLabelFont()
        {
            if(File.Exists("DengXian.ttf"))
            {
                PrivateFontCollection modernFont = new PrivateFontCollection();

                modernFont.AddFontFile("DengXian.ttf");

                LblHeading.Font = new Font(modernFont.Families[0], 18);
                LblBattey.Font = new Font(modernFont.Families[0], 14);
                LblCPU.Font = new Font(modernFont.Families[0], 14);
                LblPlex.Font = new Font(modernFont.Families[0], 14);
            }
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            //foreach (var process in Process.GetProcessesByName("PlexScriptHost"))
            //{
            //    process.Kill();
            //}

            //SMTPMail.Send("topsykretness@gmail.com", "This is the subject1 - " + System.Environment.MachineName.ToString(), "This is the message1");

            //PushJetCommands commands = new PushJetCommands();
            //commands.SendMessage(new PushJetMessageContent()
            //{
            //    secret = "d832e1527b368d29f290994db9456217",
            //    message = "Notification Test",
            //    title = "Khaoz Home",
            //    level = 3
            //});
        }

        private void KillPlex()
        {
            PushJetCommands comm = new PushJetCommands();
            comm.SendMessage(new PushJetMessageContent()
            {
                secret = SecretData.PushJetSecret,
                message = "Plex Processes being shutdown" + "\n" + DateTime.Now.ToString(),
                title = "Khaoz Home",
                level = 3
            });

            foreach (var process in Process.GetProcessesByName("PlexScriptHost"))
            {
                process.Kill();
            }
        }

        private void PBoxPlexProt_Click(object sender, EventArgs e)
        {
            PlexProtection = !PlexProtection;
            if (PlexProtection)
                PBoxPlexProt.Image = Properties.Resources.ToggleTrue;
            else
                PBoxPlexProt.Image = Properties.Resources.ToggleFalse;
        }

        private void PBoxBatteryNotify_Click(object sender, EventArgs e)
        {
            BattNotify = !BattNotify;
            if (BattNotify)
                PBoxBatteryNotify.Image = Properties.Resources.BatteryToggleTrue;
            else
                PBoxBatteryNotify.Image = Properties.Resources.ToggleFalse;
        }
    }
}
