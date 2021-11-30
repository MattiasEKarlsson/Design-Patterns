using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators.Subscript
{
    public class Subscript : TextDecorator, ISubscript
    {
        public Subscript(IText text) : base(text)
        {
            StartTag = "<sub>";
            EndTag = "</sub>";
        }
    }
}
