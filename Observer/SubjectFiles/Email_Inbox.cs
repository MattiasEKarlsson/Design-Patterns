using Design_Patterns_Assignment.Observer.ObserverFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer.SubjectFiles
{
    public class Email_Inbox : IEmail_Inbox
    {
        public List<IObserver> Observers { get; set; }
        public DateTime Time { get; set; }
        public Email_Inbox()
        {
            Observers = new List<IObserver>();
        }


        public void notifyObservers(string message)
        {
            foreach (var observer in Observers)
            {
                observer.Update(Time, message);
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
        public void Incoming_Email_Timer(int seconds, string meassage)
        {
            Task.Delay(seconds).Wait();
            Time = DateTime.Now;
            notifyObservers(meassage);
        }
    }
}
