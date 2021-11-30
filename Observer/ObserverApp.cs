using Design_Patterns_Assignment.Observer.ObserverFiles;
using Design_Patterns_Assignment.Observer.SubjectFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer
{
    public class ObserverApp : IObserverApp
    {
        public ObserverApp(IInboxWatcher inboxWatcher, IEmail_Inbox email_Inbox)
        {
            this.inboxWatcher = inboxWatcher;
            this.email_Inbox = email_Inbox;
        }

        IInboxWatcher inboxWatcher { get; set; }
        IEmail_Inbox email_Inbox { get; set; }


        public void Run()
        {
            email_Inbox.RegisterObserver(inboxWatcher);


            email_Inbox.Incoming_Email_Timer(1000, "Mail nummer 1");
            email_Inbox.Incoming_Email_Timer(3000, "Mail nummer 2");
            email_Inbox.Incoming_Email_Timer(1000 * 5, "Mail nummer 3");
        }
    }
}
