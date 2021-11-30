using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public class TextDecorator : IHTMLText
    {
        public IHTMLText HtmlText { get; set; }
        public string Description;

        public TextDecorator(IHTMLText htmlText)
        {
            HtmlText = htmlText;
        }
        public string DescriptionText(string input)
        {
            return Description + input + Description;
        }
    }
}
