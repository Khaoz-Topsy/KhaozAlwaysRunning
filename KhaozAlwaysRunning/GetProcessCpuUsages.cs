using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhaozAlwaysRunningForm
{
    public class ProcessCpuUsages
    {

        public List<KeyValuePair<string, float>> Get()
        {
            List<PerformanceCounter> counterList = new List<PerformanceCounter>();
            var procDict = new Dictionary<string, float>();

            Process.GetProcesses().ToList().ForEach(p =>
            {
                using (p)
                    if (counterList
                        .FirstOrDefault(c => c.InstanceName == p.ProcessName) == null)
                        counterList.Add(
                            new PerformanceCounter("Process", "% Processor Time",
                                p.ProcessName, true));
            });

            counterList.ForEach(c =>
            {
                try
                {
                    var percent = c.NextValue();// / Environment.ProcessorCount;
                    if (percent == 0)
                        return;

                    // Uncomment if you want to filter the "Idle" process
                    //if (c.InstanceName.Trim().ToLower() == "idle")
                    //    return;

                    procDict[c.InstanceName] = percent;
                }
                catch (InvalidOperationException) { /* some will fail */ }
            });

            return procDict.OrderByDescending(d => d.Value).ToList()
                //.ForEach(d => Console.WriteLine("{0:00.00}% - {1}", d.Value, d.Key))
                ;
            
        }
    }
}
