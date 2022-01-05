using Design_Patterns_1.Observer.ObserverFiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns_1.Observer.SubjectFiles
{
    public interface ISubject
    {
        List<IObserver> Observers { get; set; }
        void RegisterObserver(IObserver observer);
        void UnRegisterObserver(IObserver observer);
        void notifyObservers();
    }
}
