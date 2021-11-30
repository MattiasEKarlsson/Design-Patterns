using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators.Marked
{
    public class Marked : TextDecorator, IMarked
    {
        public Marked(IText text) : base(text)
        {
            StartTag = "<mark>";
            EndTag = "</mark>";
        }
    }
}
