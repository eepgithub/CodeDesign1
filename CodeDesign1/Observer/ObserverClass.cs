using Design_Patterns_1.Observer.ObserverFiles;
using Design_Patterns_1.Observer.SubjectFiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_1.Observer
{
    public class ObserverClass
    {
        internal static void Run()
        {
            MailBox Email = new MailBox();
            MailBoxWatcher emailObserver = new MailBoxWatcher();

            Email.RegisterObserver(emailObserver);
            Email.CreateTimer();
            Console.WriteLine("Observer");


        }

    }
}
