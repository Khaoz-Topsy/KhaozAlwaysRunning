using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhaozAlwaysRunning.Communications
{
    public class Communicate
    {
        public static void SendNotification(bool hasPower)
        {
            string powerLost = "Power lost";
            string powerResume = "Power resumed";

            string powerMessage;

            if (hasPower)
                powerMessage = powerResume;
            else
                powerMessage = powerLost;

            SlackRepository.SendToSlackChannel(Environment.GetEnvironmentVariable("COMPUTERNAME"), 
                powerMessage, "http://khaoznet.xyz/", "#0000FF");

        }
        public static void SendNotification(string ipAddress, int attempts, string lastResponseTime)
        {
            SlackRepository.SendToSlackChannel(Environment.GetEnvironmentVariable("COMPUTERNAME"),
                $"[{ipAddress}] has not responded after {attempts} attempts, \nLast Response took: {lastResponseTime}", 
                "http://khaoznet.xyz/", "#00FF00");

        }

        public static void SendNotification(string text)
        {
            SlackRepository.SendToSlackChannel(Environment.GetEnvironmentVariable("COMPUTERNAME"), 
                text, "http://khaoznet.xyz/", "#FFA500");

        }

    }
}
