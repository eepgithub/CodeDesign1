using Design_Patterns_1.Observer.ObserverFiles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Design_Patterns_1.Observer.SubjectFiles
{
    internal class MailBox : IMailBox
    {
        public List<IObserver> Observers { get; set; }

        public MailBox()
        {
            Observers = new List<IObserver>();
        }

        public void notifyObservers(string message)
        {
            foreach (var observer in Observers)
            {
                observer.Update(message);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void UnRegisterObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void CreateTimer()
        {
            var timer = new Timer(3000); // fire every 3 second
            timer.Elapsed += HandleTimerElapsed;

            // Have the timer fire repeated events (true is the default)
            timer.AutoReset = true;

            // Start the timer
            timer.Enabled = true;

            Console.WriteLine("Press the Enter key to exit the program at any time... ");
            Console.ReadLine();



        }

        public void HandleTimerElapsed(object sender, ElapsedEventArgs e)
        {
            string message = "You have a new mail";
            notifyObservers(message);
        }
    }
}
