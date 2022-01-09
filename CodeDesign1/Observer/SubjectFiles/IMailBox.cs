using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Design_Patterns_1.Observer.SubjectFiles
{
    public interface IMailBox : ISubject
    {
        public void CreateTimer();
        public void HandleTimerElapsed(object sender, ElapsedEventArgs e);

    }
}
