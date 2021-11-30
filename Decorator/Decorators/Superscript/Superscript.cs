using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators.Superscript
{
    public class Superscript : TextDecorator, ISuperscript
    {
        public Superscript(IText text) : base(text)
        {
            StartTag = "<sup>";
            EndTag = "</sup>";
        }
    }
}
