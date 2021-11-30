using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer.ObserverFiles
{
    public class InboxWatcher : IInboxWatcher
    {
        public void Update(DateTime time, string message)
        {
            Console.WriteLine($"Det kom ett mail vid: {time} med meddelandet: {message} ");
        }
    }
}
