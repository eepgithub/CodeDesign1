using Design_Patterns_1.Observer.ObserverFiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_1.Observer
{
    public class ObserverClass
    {
        internal static void Run()
        {

            MailBoxWatcher emailObserver = new MailBoxWatcher();
            Console.WriteLine("Observer");
            emailObserver.Update();

        }

    }
}
