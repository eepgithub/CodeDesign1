using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDesign1.Strategy.Messages
{
    public class Sms : ISms
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending \"{message}\" as a sms");
        }
    }
}
