using Design_Patterns_Assignment.Strategy.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy.Sender
{
    interface ISender
    {
        IMessage Message { get; set; }

        void Send(string message);
    }
}
