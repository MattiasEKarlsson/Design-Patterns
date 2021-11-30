using Design_Patterns_Assignment.Decorator.TextDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public class DecoratorApp : IDecoratorApp
    {
        public DecoratorApp(IRegularText htmlText)
        {
            HtmlText = htmlText;
        }

        public IHTMLText HtmlText { get; set; }

        public void Run()
        {
            var aa = "Matte";




            
            HtmlText = new Bold(HtmlText);
            Console.WriteLine($"{HtmlText.DescriptionText(aa)}");
        }
    }
}
