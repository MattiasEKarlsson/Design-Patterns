using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    public class Deleted : TextDecorator, IDeleted
    {
        public Deleted(IText text) : base(text)
        {
            StartTag = "<del>";
            EndTag = "</del>";
        }
    }
}
