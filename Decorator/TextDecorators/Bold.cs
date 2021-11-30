using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.TextDecorators
{
    public class Bold : TextDecorator, IBold
    {
        public Bold(IHTMLText htmlText) : base(htmlText)
        {
            Description = "<b>";
        }
    }
}
