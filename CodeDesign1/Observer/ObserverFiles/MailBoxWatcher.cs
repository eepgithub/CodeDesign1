using Design_Patterns_1.Observer.SubjectFiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_1.Observer.ObserverFiles
{
    public class MailBoxWatcher : IMailBoxWatcher
    {
        public void Update(string message)
        {
            Console.WriteLine(message);
        }
    }
}
