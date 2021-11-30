using Design_Patterns_Assignment.Observer.ObserverFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer.SubjectFiles
{
    public interface ISubject
    {
        List<IObserver> Observers { get; set; }
        void RegisterObserver(IObserver observer);
        void UnRegisterObserver(IObserver observer);
        void notifyObservers(string message);
        void Incoming_Email_Timer(int seconds, string meassage);
    }
}
