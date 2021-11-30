using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public abstract class TextDecorator : IText
    {
        public IText Text { get; set; }
        public string StartTag;
        public string EndTag;

        protected TextDecorator(IText text)
        {
            Text = text;
        }

        public string GetDescription()
        {
            return StartTag+ Text.GetDescription() + EndTag;
        }

        public void SetInput()
        {
            Console.WriteLine("I do nothing :(");
        }
    }
}
