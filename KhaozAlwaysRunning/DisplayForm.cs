using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using KhaozAlwaysRunning.Communications;
using System.Net.NetworkInformation;

namespace KhaozAlwaysRunningForm
{
    public partial class DisplayForm : Form
    {
        private static readonly string[] Running = { "Khaoz Always On.../", "Khaoz Always On...-", "Khaoz Always On...\\", "Khaoz Always On...|" };
        private static bool _isBatteryPower;
        private static readonly PerformanceCounter CpuCounter = new PerformanceCounter();
        private static readonly ProcessCpuUsages ProcessCpuUsages = new ProcessCpuUsages();

        private const string IpAddress = "192.168.0.2";
        private static int _pingCount;
        private static bool _pingIsAlive;
        private static string _oldResponseTime; 

        private static int _count;
        private static double _cpuUsage;
        private static int _cpuOverLimitCount;

        private bool _cpuNotify;
        private bool _battNotify;
        private bool _networkNotify;

        public DisplayForm()
        {
            InitializeComponent();
            InitCustomLabelFont();

            CpuCounter.CategoryName = "Processor";
            CpuCounter.CounterName = "% Processor Time";
            CpuCounter.InstanceName = "_Total";

            CpuCounter.NextValue(); CpuCounter.NextValue();

            Display();
            LblBattey.Text = @"On Charge";
            LblPing.Text = @"Ping: ";
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
            _count = (_count < 3) ? _count + 1 : 0;

            LblHeading.Text = Running[_count];

            _cpuUsage = CpuCounter.NextValue();

            if (_count != 3) return;

            #region Battery
            if (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline) //On Battery
            {
                if ((_isBatteryPower == false) && (_battNotify))
                {
                    Communicate.SendNotification(_isBatteryPower);
                    _isBatteryPower = true;
                }
                LblBattey.Text = @"On Battery";
            }
            else // Plugged In
            {
                if (_isBatteryPower && _battNotify)
                {
                    Communicate.SendNotification(_isBatteryPower);
                    _isBatteryPower = false;
                }
                LblBattey.Text = @"On Charge";
            }
            #endregion Battery

            #region cpuAverage
            if (_cpuUsage > 75)
            {
                if (_cpuNotify)
                {
                    _cpuOverLimitCount++;
                }
            }
            else if (_cpuUsage < 20)
            {
                _cpuOverLimitCount = 0;
            }

            if (_cpuOverLimitCount > 9)
            {
                if (_cpuNotify)
                {
                    KillPlex();
                    _cpuOverLimitCount = 0;
                }
            }

            LblHighCPU.Text = $@"Count: {_cpuOverLimitCount}";
            LblCPU.Text = $@"CPU: {CpuUsageDisplay(_cpuUsage)} %";
            #endregion

            #region Network
            if(_networkNotify)
            {
                PingHost(IpAddress, delegate (PingResult ping)
                {
                    if (ping.Success)
                    {
                        _pingCount = 0;
                        _pingIsAlive = true;
                        _oldResponseTime = PingTimeDisplay(ping.RoundtripTime);
                        LblPing.Text = _oldResponseTime;
                    }
                    else
                    {
                        _pingCount++;
                    }

                    if (_pingCount <= 9) return;
                    if (!_pingIsAlive) return;

                    _pingIsAlive = false;
                    Communicate.SendNotification(IpAddress, _pingCount, _oldResponseTime);
                });
            }

            LblPingCount.Text = $@"Count: {_pingCount}";
            #endregion
        }

        private static string CpuUsageDisplay(double cpu)
        {
            string temp = cpu.ToString("00.00");

            return temp.Substring(0, 1).Equals("0") ? " " + temp.Substring(1) : temp;
        }

        private static string PingTimeDisplay(long time)
        {
            string number = time.ToString();
            string measurement = "ms";

            if (time > 1000)
            {
                number = (time / 1000).ToString();
                measurement = "s";
            }

            return $"Ping: {number}{measurement}";
        }

        private void InitCustomLabelFont()
        {
            if (File.Exists("DengXian.ttf"))
            {
                PrivateFontCollection modernFont = new PrivateFontCollection();

                modernFont.AddFontFile("DengXian.ttf");

                LblHeading.Font = new Font(modernFont.Families[0], 18);
                LblBattey.Font = new Font(modernFont.Families[0], 14);
                LblCPU.Font = new Font(modernFont.Families[0], 14);
                LblCpuNotify.Font = new Font(modernFont.Families[0], 14);
                LblBattNotify.Font = new Font(modernFont.Families[0], 14);
                LblHighCPU.Font = new Font(modernFont.Families[0], 8);
                LblPing.Font = new Font(modernFont.Families[0], 14);
                LblPingCount.Font = new Font(modernFont.Families[0], 8);
                LblPingNotify.Font = new Font(modernFont.Families[0], 14);
            }
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {

        }

        private static void KillPlex()
        {
            string processes = string.Empty;

            ProcessCpuUsages.Get().ForEach(d => 
                processes += $"\n{d.Value:00.00}% - {d.Key}"
            );
            Communicate.SendNotification($"CPU Usage is high\n\n{processes}");

            foreach (Process process in Process.GetProcessesByName("PlexScriptHost"))
            {
                process.Kill();
            }
            foreach (Process process in Process.GetProcessesByName("python"))
            {
                process.Kill();
            }
        }

        private static void PingHost(string nameOrAddress, Action<PingResult> complete)
        {
            PingResult pingable = new PingResult() { Success = false, RoundtripTime = 0 };
            Ping pinger = new Ping();
            try
            {
                PingReply reply = pinger.Send(nameOrAddress);
                if (reply != null)
                {
                    pingable.Success = reply.Status == IPStatus.Success;
                    pingable.RoundtripTime = reply.RoundtripTime;
                }
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }

            complete(pingable);
        }

        private void PBoxPlexProt_Click(object sender, EventArgs e)
        {
            _cpuNotify = !_cpuNotify;
            PBoxCpuNotify.Image = _cpuNotify ? 
                Properties.Resources.ToggleTrue : Properties.Resources.ToggleFalse;
        }

        private void PBoxBatteryNotify_Click(object sender, EventArgs e)
        {
            _battNotify = !_battNotify;
            PBoxBatteryNotify.Image = _battNotify ? 
                Properties.Resources.BatteryToggleTrue : Properties.Resources.ToggleFalse;
        }

        private void PBoxPingNotify_Click(object sender, EventArgs e)
        {
            _networkNotify = !_networkNotify;
            PBoxPingNotify.Image = _networkNotify ? 
                Properties.Resources.NetworkToggleTrue : Properties.Resources.ToggleFalse;
        }
    }
}
