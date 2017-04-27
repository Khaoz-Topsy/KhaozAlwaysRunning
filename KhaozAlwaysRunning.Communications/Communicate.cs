using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhaozAlwaysRunning.Communications
{
    public class Communicate
    {
        public static void sendMail(bool hasPower)
        {
            string powerLost = "Power lost on " + System.Environment.MachineName.ToString();
            string powerResume = "Power resumed " + System.Environment.MachineName.ToString();

            string powerMessage;

            if (hasPower)
                powerMessage = powerResume;
            else
                powerMessage = powerLost;

            SMTPMail.Send(powerMessage, powerMessage + "\n" + DateTime.Now.ToString());
        }

        public static void sendNotification(bool hasPower)
        {
            string powerLost = "Power lost on " + System.Environment.MachineName.ToString() + "\n" + DateTime.Now.ToString();
            string powerResume = "Power resumed " + System.Environment.MachineName.ToString() + "\n" + DateTime.Now.ToString();

            string powerMessage;

            if (hasPower)
                powerMessage = powerResume;
            else
                powerMessage = powerLost;

            PushJetCommands commands = new PushJetCommands();
            commands.SendMessage(new PushJetMessageContent()
            {
                secret = SecretData.PushJetSecret,
                message = powerMessage,
                title = "Khaoz Home",
                level = 3
            });
        }
    }
}
