
using Design_Patterns_Assignment.Decorator.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public class DecoratorApp : IDecoratorApp
    {
        public DecoratorApp(IRegularText text)
        {
            Text = text;
        }

        public IText Text { get; set; }
        

        public void Run()
        {
            var newText = Text;

            var aa = "Matte";

            Text = new Bold(Text);
            Text = new Bold(Text);
            Console.WriteLine($"Your Order Is: {Text.GetDescription()}");

            Console.WriteLine(aa);


            
            
        }
    }
}
