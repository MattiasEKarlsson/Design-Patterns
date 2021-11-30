using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators.Insert
{
    public class Insert : TextDecorator, IInsert
    {
        public Insert(IText text) : base(text)
        {
            StartTag = "<ins>";
            EndTag = "</ins>";
        }
    }
}
